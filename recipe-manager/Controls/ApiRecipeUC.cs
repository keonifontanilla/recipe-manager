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
        }

        private async void apiSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var searchTerm = apiSearchTextBox.Text;
                var (apiRecipes, totalResults) = await ApiRecipeProcessor.LoadRecipes(searchTerm);
                this.recipes = apiRecipes;

                apiRecipesDataGridView.DataSource = null;
                if (totalResults != 0)
                {
                    apiRecipesDataGridView.DataSource = this.recipes;
                }

                MessageBox.Show($"Max Number of recipes displayed is 10. Results found: {totalResults}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                descriptionTextBox.Text = $"{recipeModel.Summary}{Environment.NewLine}Visit recipe site here: {recipeModel.SourceUrl}";
                typeLabel.Text = $"Type: {recipeModel.DishType}";

                var count = 1;
                recipeModel.ExtendedIngredients.ForEach(ing => ingredientsTextBox.Text += ing.Original + Environment.NewLine);
                recipeModel.AnalyzedInstructions.ForEach(ins =>
                    ins.Steps.ForEach(step =>
                        instructionsTextBox.Text += $"Step {count++}: {step.Step} {Environment.NewLine}"));
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
