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
        private Panel addRecipePanel = new Panel();
        private Panel allRecipesPanel = new Panel();

        private DataAccess db = new DataAccess();
        private bool categoriesClicked = false;

        public RecipeManagerForm()
        {
            InitializeComponent();
            InitializeAddRecipes();
            InitializeAllRecipes();

            topBarPanel.Controls.Add(new TopBar());
            SetSideButtonColor(homeButton);
        }

        private void InitializeAddRecipes()
        {
            addRecipePanel.Size = homePanel.Size;
            addRecipePanel.Location = homePanel.Location;
            addRecipePanel.Controls.Add(new AddRecipeUC(db));
            this.Controls.Add(addRecipePanel);
        }

        private void InitializeAllRecipes()
        {
            allRecipesPanel.Size = homePanel.Size;
            allRecipesPanel.Location = homePanel.Location;
            
            this.Controls.Add(allRecipesPanel);
        }

        private void SetSideButtonColor(Object sender)
        {
            var defaultColor = Color.FromArgb(245, 243, 244);
            var btnSender = (Button)sender;

            homeButton.BackColor = defaultColor;
            allRecipesButton.BackColor = defaultColor;
            categoriesButton.BackColor = defaultColor;
            addRecipeButton.BackColor = defaultColor;

            btnSender.BackColor = Color.LightGray;
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            SetSideButtonColor(sender);
            homePanel.Hide();
            addRecipePanel.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            SetSideButtonColor(sender);
            addRecipePanel.Hide();
            homePanel.Show();
        }

        private void recipesButton_Click(object sender, EventArgs e)
        {
            RemoveOldRef(allRecipesPanel, "RecipesUC");

            var senderButton = (Button)sender;
            var recipesUC = new RecipesUC(db, GetRecipeType(senderButton.Text));
            allRecipesPanel.Controls.Add(recipesUC);

            homePanel.Hide();
            addRecipePanel.Hide();
            allRecipesPanel.Show();
        }

        private RecipeType GetRecipeType(string recipeType)
        {
            RecipeType rt;

            switch(recipeType)
            {
                case "Breakfast":
                    rt = RecipeType.Breakfast;
                    break;
                case "Lunch":
                    rt = RecipeType.Lunch;
                    break;
                case "Dinner":
                    rt = RecipeType.Dinner;
                    break;
                case "Desserts":
                    rt = RecipeType.Dessert;
                    break;
                case "Drinks":
                    rt = RecipeType.Drink;
                    break;
                default:
                    rt = RecipeType.All;
                    break;
            }

            return rt;
        }


        private void RemoveOldRef(Panel panel, string name)
        {
            var oldRef = panel.Controls[name];
            if (oldRef != null)
            {
                panel.Controls.Remove(oldRef);
                oldRef.Dispose();
            }
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            SetSideButtonColor(sender);

            if (!categoriesClicked)
            {
                categoriesSubPanel.Show();
                categoriesClicked = true;
            }
            else
            {
                categoriesSubPanel.Hide();
                categoriesClicked = false;
            }
        }   
    }
}
