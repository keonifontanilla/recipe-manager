using Dapper;
using recipe_manager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager
{
    public class DataAccess
    {
        private string connStr = ConfigurationManager.ConnectionStrings["RecipesDB"].ConnectionString;

        public List<RecipesModel> ListRecipes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                return connection.Query<RecipesModel>("dbo.spRecipes_SelectAllRecipes").ToList();
            }
        }

        public void InsertRecipe()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                
            }
        }
    }
}
