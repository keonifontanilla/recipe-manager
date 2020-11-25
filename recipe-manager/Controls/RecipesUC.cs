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
        private TextBox viewRecipeTextBox = new TextBox();

        private DataAccess db = null;

        public RecipesUC(DataAccess db)
        {
            this.db = db;

            InitializeComponent();

            recipesDataGridView.DataSource = db.ListRecipes();
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
            var ingredients = new List<IngredientsModel>();
            var instructions = new List<InstructionsModel>();

            var rowIndex = recipesDataGridView.CurrentRow.Index;
            var recipeId = (int)recipesDataGridView.Rows[rowIndex].Cells["RecipeId"].Value;

            var recipesModel = db.ViewRecipe(recipeId, out ingredients, out instructions);

            nameLabel.Text = recipesModel.RecipeName;
            descriptionTextBox.Text = recipesModel.RecipeDescription;
            typeLabel.Text = $"Type: {recipesModel.RecipeType}";

            ingredients.ForEach(x => ingredientsTextBox.Text += x.IngredientInfo);
            instructions.ForEach(x => instructionsTextBox.Text += x.InstructionInfo);
        }

        private void ResetViewRecipe()
        {
            nameLabel.Text = "";
            descriptionTextBox.Text = "";
            typeLabel.Text = "";
            ingredientsTextBox.Text = "";
            instructionsTextBox.Text = "";
        }
    }
}
