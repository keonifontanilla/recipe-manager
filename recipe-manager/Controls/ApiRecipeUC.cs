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
        public ApiRecipeUC()
        {
            InitializeComponent();

            apiRecipesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

        private async void apiSearchButton_Click(object sender, EventArgs e)
        {
            var searchTerm = apiSearchTextBox.Text;
            var recipes = await ApiRecipeProcessor.LoadRecipes(searchTerm);

            apiRecipesDataGridView.DataSource = recipes;
            apiRecipesDataGridView.AutoResizeColumns();
        }
    }
}
