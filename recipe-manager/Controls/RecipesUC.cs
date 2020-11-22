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
        DataAccess db;

        public RecipesUC(DataAccess db)
        {
            this.db = db;

            InitializeComponent();

            recipesDataGridView.DataSource = db.ListRecipes();
        }
    }
}
