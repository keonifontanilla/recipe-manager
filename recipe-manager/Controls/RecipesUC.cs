using recipe_manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_manager.Controls
{
    public partial class RecipesUC : UserControl
    {
        private List<IngredientsModel> ingredients = new List<IngredientsModel>();
        private List<InstructionsModel> instructions = new List<InstructionsModel>();
        private RecipesModel recipesModel = null;

        private Panel updatePanel = new Panel();
        private DataAccess db = null;
        private RecipeType recipeSearchType = 0;
        private bool saveFavorite = false;

        public RecipesUC(DataAccess db, RecipeType recipeSearchType, bool saveFavorite = false)
        {
            this.db = db;
            this.recipeSearchType = recipeSearchType;
            this.saveFavorite = saveFavorite;

            InitializeComponent();
            InitializeRecipesGrid();
        }

        private void InitializeRecipesGrid()
        {
            recipesDataGridView.DataSource = SetGridDatasource();

            recipesDataGridView.Columns["RecipeInfo"].Visible = false;
            recipesDataGridView.Columns["RecipeId"].HeaderText = "Id";
            recipesDataGridView.Columns["RecipeId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private List<RecipesModel> SetGridDatasource()
        {
            if (recipeSearchType != RecipeType.All)
            {
                return db.SearchRecipes("", recipeSearchType);
            }
            else if (saveFavorite)
            {
                return db.ListFavoriteRecipes();
            }
            
            return db.ListRecipes();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (viewButton.Text == "View")
            {
                ViewRecipe();

                viewPanel.Show();
                recipesDataGridView.Hide();
                viewButton.Text = "Close";
            }
            else
            {
                viewPanel.Hide();
                recipesDataGridView.Show();
                viewButton.Text = "View";

                ResetViewRecipe();
            }
        }

        private void ViewRecipe()
        {
            if (recipesDataGridView.CurrentRow != null)
            {
                var rowIndex = recipesDataGridView.CurrentRow.Index;
                var recipeId = (int)recipesDataGridView.Rows[rowIndex].Cells["RecipeId"].Value;

                recipesModel = db.ViewRecipe(recipeId, out ingredients, out instructions);

                nameLabel.Text = recipesModel.RecipeName;
                descriptionTextBox.Text = recipesModel.RecipeDescription;
                typeLabel.Text = $"Type: {recipesModel.RecipeType}";

                var count = 1;
                ingredients.ForEach(x => ingredientsTextBox.Text += x.IngredientInfo);
                instructions.ForEach(x => instructionsTextBox.Text += $"Step {count++}. {x.InstructionInfo}");
            }
        }

        private void ResetViewRecipe()
        {
            nameLabel.Text = "";
            descriptionTextBox.Text = "";
            typeLabel.Text = "";
            ingredientsTextBox.Text = "";
            instructionsTextBox.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (recipesDataGridView.CurrentRow != null)
            {
                updatePanel.Dock = DockStyle.Fill;
                updatePanel.Location = viewPanel.Location;

                this.Controls.Add(updatePanel);

                ViewRecipe();

                updatePanel.Controls.Add(new AddRecipeUC(db, recipesModel, ingredients, instructions, update: true));

                updatePanel.BringToFront();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!saveFavorite)
            {
                DeleteOrInsert(db.DeleteFullRecipe);
            }
            else
            {
                DeleteOrInsert(db.DeleteFavoriteRecipe);
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            DeleteOrInsert(db.InsertFavoriteRecipe);
        }

        private void DeleteOrInsert(Action<int> action)
        {
            if (recipesDataGridView.CurrentRow != null)
            {
                var rowIndex = recipesDataGridView.CurrentRow.Index;
                var recipeId = (int)recipesDataGridView.Rows[rowIndex].Cells["RecipeId"].Value;

                action.Invoke(recipeId);

                InitializeRecipesGrid();
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) recipesDataGridView.DataSource = db.SearchRecipes(searchTextBox.Text, recipeSearchType);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "") recipesDataGridView.DataSource = SetGridDatasource();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            var fileGenerator = new FileGenerator(saveFileDialog);

            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileGenerator.GenerateFile(recipesModel, ingredients, instructions);
            }
        }
    }
}
