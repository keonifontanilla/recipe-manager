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
    public partial class AddRecipeUC : UserControl
    {
        DataAccess db;

        public AddRecipeUC(DataAccess db)
        {
            this.db = db;

            InitializeComponent();
            FormatIngredientDataGridView();
        }

        private void FillRecipesModel(RecipesModel rm)
        {
            rm.RecipeName = nameTextBox.Text;
            rm.RecipeDescription = descriptionTextBox.Text;
            rm.RecipeType = typeComboBox.SelectedItem.ToString();
        }

        private void FillIngredientsModel(IngredientsModel im)
        {
            im.Ingredient = ingredientsTextBox.Text;
            im.IngredientQuantity = float.Parse(quantityTextBox.Text);
            im.IngredientUnit = unitTextBox.Text;
        }

        private void FillInstructionsModel(InstructionsModel inm)
        {
            inm.Instruction = instructionsTextBox.Text;
        }

        private void FormatIngredientDataGridView()
        {
            ingredientsDataGridView.Columns.Add("Ingredient", "Ingredient");
            ingredientsDataGridView.Columns.Add("Quantity", "Quantity");
            ingredientsDataGridView.Columns.Add("Unit", "Unit");
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            var ingredientsModel = new IngredientsModel();

            FillIngredientsModel(ingredientsModel);

            ingredientsDataGridView.Rows.Add(ingredientsModel.Ingredient, ingredientsModel.IngredientQuantity, ingredientsModel.IngredientUnit);

            ingredientsTextBox.Clear();
            quantityTextBox.Clear();
            unitTextBox.Clear();
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {

        }

        private void addInstructionButton_Click(object sender, EventArgs e)
        {
            var instructionsModel = new InstructionsModel();

            FillInstructionsModel(instructionsModel);
            instructionsListBox.Items.Add(instructionsModel.Instruction);

            instructionsTextBox.Clear();
        }

        private void removeInstuctionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
