using recipe_manager.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_manager
{
    public partial class RecipeManagerForm : Form
    {
        private Panel AddRecipePanel = new Panel();
        private Panel AllRecipesPanel = new Panel();

        DataAccess db = new DataAccess();

        public RecipeManagerForm()
        {
            InitializeComponent();

            topBarPanel.Controls.Add(new TopBar());
            this.Controls.Add(AddRecipePanel);
            this.Controls.Add(AllRecipesPanel);
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipePanel.Size = homePanel.Size;
            AddRecipePanel.Location = homePanel.Location;
            AddRecipePanel.Controls.Add(new AddRecipeUC(db));

            homePanel.Hide();
            AddRecipePanel.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AddRecipePanel.Hide();
            homePanel.Show();
        }

        private void allRecipesButton_Click(object sender, EventArgs e)
        {
            AllRecipesPanel.Size = homePanel.Size;
            AllRecipesPanel.Location = homePanel.Location;
            AllRecipesPanel.Controls.Add(new RecipesUC(db));

            homePanel.Hide();
            AllRecipesPanel.Show();
        }
    }
}
