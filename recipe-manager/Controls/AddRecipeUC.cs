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
        List<IngredientsModel> ingredients = new List<IngredientsModel>(); 
        List<InstructionsModel> instructions = new List<InstructionsModel>(); 

        DataAccess db = null;

        public AddRecipeUC(DataAccess db)
        {
            this.db = db;

            InitializeComponent();
            InitializeRecipesComboBox();
            FormatIngredientDataGridView();
        }

        private void InitializeRecipesComboBox()
        {
            typeComboBox.DataSource = new List<string> { "Any", "Breakfast", "Lunch", "Dinner", "Dessert", "Drink" };
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
            im.IngredientQuantity = quantityTextBox.Text;
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
            ingredients.Add(ingredientsModel);

            ingredientsDataGridView.Rows.Add(ingredientsModel.Ingredient, ingredientsModel.IngredientQuantity, ingredientsModel.IngredientUnit);

            ingredientsTextBox.Clear();
            quantityTextBox.Clear();
            unitTextBox.Clear();
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientsDataGridView.CurrentRow != null)
            {
                var index = ingredientsDataGridView.CurrentRow.Index;

                ingredientsDataGridView.Rows.RemoveAt(index);
                ingredients.RemoveAt(index);
            }
        }

        private void addInstructionButton_Click(object sender, EventArgs e)
        {
            var instructionsModel = new InstructionsModel();

            FillInstructionsModel(instructionsModel);
            instructions.Add(instructionsModel);

            instructionsListBox.Items.Add(instructionsModel.Instruction);

            instructionsTextBox.Clear();
        }

        private void removeInstuctionButton_Click(object sender, EventArgs e)
        {
            var index = instructionsListBox.SelectedIndex;

            if (index != -1)
            {
                instructionsListBox.Items.RemoveAt(index);
                instructions.RemoveAt(index);
            }
        }

        private int CreateRecipeInfo(RecipesModel rm)
        {
            FillRecipesModel(rm);

            return db.CreateRecipeInfo(rm, instructions);
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            var recipesModel = new RecipesModel();
            var recipesId = CreateRecipeInfo(recipesModel);

            db.InsertFullRecipe(ingredients, recipesId);
            ResetForm(recipeGroupBox);
            ResetForm(ingredientsGroupBox);
            ResetForm(instructionsGroupBox);
        }

        private void ResetForm(GroupBox groupBox)
        {
            foreach (var control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = 0;
                }

                if (control is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)control;
                    dataGridView.Rows.Clear();
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.Items.Clear();
                }
            }
            ingredients = new List<IngredientsModel>();
            instructions = new List<InstructionsModel>();
        }
    }
}
