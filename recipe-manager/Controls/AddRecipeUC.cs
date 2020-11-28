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
        private List<IngredientsModel> ingredients = new List<IngredientsModel>(); 
        private List<InstructionsModel> instructions = new List<InstructionsModel>();
        private RecipesModel recipesModel = new RecipesModel();

        private DataAccess db = null;
        private int ingredientId = 0;
        private bool editInstructions = false;
        private bool update = false;

        public AddRecipeUC(DataAccess db)
        {
            this.db = db;

            InitializeComponent();
            InitializeRecipesComboBox();
            FormatIngredientDataGridView();
        }

        public AddRecipeUC(DataAccess db, RecipesModel rm, List<IngredientsModel> ingredients, List<InstructionsModel> instructions, bool update)
        {
            this.db = db;
            this.recipesModel = rm;
            this.ingredients = ingredients;
            this.instructions = instructions;
            this.update = update;

            InitializeComponent();
            InitializeRecipesComboBox();
            FormatIngredientDataGridView();

            nameTextBox.Text = rm.RecipeName;
            descriptionTextBox.Text = rm.RecipeDescription;
            typeComboBox.SelectedItem = rm.RecipeType;

            ingredients.ForEach(x =>
            {
                ingredientsDataGridView.Rows.Add(x.IngredientId, x.Ingredient, x.IngredientQuantity, x.IngredientUnit);
            });

            instructions.ForEach(x => instructionsListBox.Items.Add(x.Instruction));
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
            im.IngredientId = this.ingredientId++;
        }

        private void FillInstructionsModel(InstructionsModel inm)
        {
            inm.Instruction = instructionsTextBox.Text;
        }

        private void FormatIngredientDataGridView()
        {
            ingredientsDataGridView.Columns.Add("IngredientId", "Id");
            ingredientsDataGridView.Columns["IngredientId"].Visible = false;
            ingredientsDataGridView.Columns.Add("Ingredient", "Ingredient");
            ingredientsDataGridView.Columns.Add("Quantity", "Quantity");
            ingredientsDataGridView.Columns.Add("Unit", "Unit");
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientsTextBox.Text != "" && quantityTextBox.Text != "" && unitTextBox.Text != "")
            {
                var ingredientsModel = new IngredientsModel();

                FillIngredientsModel(ingredientsModel);
                ingredients.Add(ingredientsModel);

                ingredientsDataGridView.Rows.Add(ingredientsModel.IngredientId, ingredientsModel.Ingredient, ingredientsModel.IngredientQuantity, ingredientsModel.IngredientUnit);

                ingredientsTextBox.Clear();
                quantityTextBox.Clear();
                unitTextBox.Clear();
            }
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
            if (instructionsTextBox.Text != "")
            {
                var instructionsModel = new InstructionsModel();

                FillInstructionsModel(instructionsModel);
                instructions.Add(instructionsModel);

                instructionsListBox.Items.Add(instructionsModel.Instruction);

                instructionsTextBox.Clear();
            }
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
            if (nameTextBox.Text != "")
            {
                if (!update)
                {
                    var recipesModel = new RecipesModel();
                    var recipesId = CreateRecipeInfo(recipesModel);

                    db.InsertFullRecipe(ingredients, recipesId);

                    MessageBox.Show("Recipe added.");
                }
                else
                {
                    FillRecipesModel(this.recipesModel);
                    db.UpdateRecipe(this.recipesModel, ingredients, instructions);
                }
                ResetForm();
            }
            else
            {
                MessageBox.Show("Recipe requires at least a name.");
            }
        }

        private void ResetGroupBoxes(GroupBox groupBox)
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

        private void ResetForm()
        {
            ResetGroupBoxes(recipeGroupBox);
            ResetGroupBoxes(ingredientsGroupBox);
            ResetGroupBoxes(instructionsGroupBox);

            ingredientId = 0;
            ingredients = new List<IngredientsModel>();
            instructions = new List<InstructionsModel>();
            editInstructions = true;
            update = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ingredientsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ingredientsDataGridView.CurrentRow != null)
            {
                var index = ingredientsDataGridView.CurrentRow.Index;
                var cells = ingredientsDataGridView.Rows[index].Cells;
                var id = (int)cells["IngredientId"].Value;

                ingredients.ForEach(x =>
                {
                    if (x.IngredientId == id)
                    {
                        x.Ingredient = (string)cells["Ingredient"].Value;
                        x.IngredientQuantity = (string)cells["Quantity"].Value;
                        x.IngredientUnit = (string)cells["Unit"].Value;
                    }
                });
            }
        }

        private void instructionsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (instructionsListBox.SelectedIndex != -1)
            {
                instructionsTextBox.Text = instructionsListBox.SelectedItem.ToString();
                editInstructions = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var index = instructionsListBox.SelectedIndex;

            if (editInstructions)
            {
                this.instructions[index].Instruction = instructionsTextBox.Text;
                instructionsListBox.Items[index] = instructionsTextBox.Text;
                
                instructionsListBox.Refresh();

                instructionsTextBox.Text = "";
                editInstructions = false;
            }
        }

        private void instructionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            instructionsTextBox.Text = "";
            editInstructions = false;
        }
    }
}
