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
            InitializeViewRecipe();

            recipesDataGridView.DataSource = db.ListRecipes();
        }

        private void InitializeViewRecipe()
        {
            viewRecipeTextBox.Size = recipesDataGridView.Size;
            viewRecipeTextBox.Location = recipesDataGridView.Location;
            viewRecipeTextBox.Multiline = true;
            viewRecipeTextBox.ReadOnly = true;
            this.Controls.Add(viewRecipeTextBox);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (viewButton.Text == "View")
            {
                viewRecipeTextBox.Show();
                recipesDataGridView.Hide();
                viewButton.Text = "Close";
            }
            else
            {
                viewRecipeTextBox.Hide();
                recipesDataGridView.Show();
                viewButton.Text = "View";
            }
        }
    }
}
