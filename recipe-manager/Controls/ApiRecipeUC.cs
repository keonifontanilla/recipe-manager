using recipe_manager.API;
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
    public partial class ApiRecipeUC : UserControl
    {
        private List<ApiRecipeModel> recipes = new List<ApiRecipeModel>();

        public ApiRecipeUC()
        {
            InitializeComponent();

            apiRecipesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private async void apiSearchButton_Click(object sender, EventArgs e)
        {
            var searchTerm = apiSearchTextBox.Text;
            recipes = await ApiRecipeProcessor.LoadRecipes(searchTerm);

            apiRecipesDataGridView.DataSource = recipes;
            apiRecipesDataGridView.AutoResizeColumns();
        }

        private void apiViewButton_Click(object sender, EventArgs e)
        {
            if (apiViewButton.Text == "View")
            {
                ViewRecipe();

                viewPanel.Show();
                apiRecipesDataGridView.Hide();
                apiViewButton.Text = "Close";
            }
            else
            {
                viewPanel.Hide();
                apiRecipesDataGridView.Show();
                apiViewButton.Text = "View";

                ResetViewRecipe();
            }
        }

        private void ViewRecipe()
        {
            if (apiRecipesDataGridView.CurrentRow != null)
            {
                var rowIndex = apiRecipesDataGridView.CurrentRow.Index;
                var recipeModel = recipes[rowIndex];

                nameLabel.Text = recipeModel.Title;
                descriptionTextBox.Text = recipeModel.Summary;
                typeLabel.Text = $"Type: {recipeModel.DishType}";
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
    }
}
