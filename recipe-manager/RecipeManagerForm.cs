using recipe_manager.API;
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
        private Panel apiRecipesPanel = new Panel();

        private DataAccess db = new DataAccess();
        private bool categoriesClicked = false;

        public RecipeManagerForm()
        {
            InitializeComponent();
            InitializeAddRecipes();
            InitializeAllRecipes();
            InitializeApiRecipes();

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

        private void InitializeApiRecipes()
        {
            ApiHelper.InitializeClient();

            apiRecipesPanel.Size = homePanel.Size;
            apiRecipesPanel.Location = homePanel.Location;

            this.Controls.Add(apiRecipesPanel);
        }

        private void SetSideButtonColor(Object sender)
        {
            var defaultColor = Color.FromArgb(245, 243, 244);
            var btnSender = (Button)sender;

            homeButton.BackColor = defaultColor;
            allRecipesButton.BackColor = defaultColor;
            categoriesButton.BackColor = defaultColor;
            addRecipeButton.BackColor = defaultColor;
            searchAPIButton.BackColor = defaultColor;
            favoritesButton.BackColor = defaultColor;

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
            var recipeTypeLabel = senderButton.Parent.Controls.OfType<Label>().FirstOrDefault();
            var recipeType = senderButton.Parent is Panel ? senderButton.Text : recipeTypeLabel.Text;

            var recipesUC = senderButton.Name != "favoritesButton" ? 
                new RecipesUC(db, GetRecipeType(recipeType)) : new RecipesUC(db, RecipeType.All, saveFavorite: true);

            allRecipesPanel.Controls.Add(recipesUC);

            if (senderButton.Name == "favoritesButton") SetSideButtonColor(sender);
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
                case "Main Course":
                    rt = RecipeType.Main;
                    break;
                case "Side Dishes":
                    rt = RecipeType.Side;
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

        private void searchAPIButton_Click(object sender, EventArgs e)
        {
            RemoveOldRef(apiRecipesPanel, "ApiRecipeUC");
            apiRecipesPanel.Controls.Add(new ApiRecipeUC());

            SetSideButtonColor(sender);
            homePanel.Hide();
            addRecipePanel.Hide();
            allRecipesPanel.Hide();
            apiRecipesPanel.Show();
        }
    }
}
