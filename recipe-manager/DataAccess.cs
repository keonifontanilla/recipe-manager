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

        public List<RecipesModel> SearchRecipes(string recipeName, RecipeType rt)
        {
            string sql;

            switch (rt)
            {
                case RecipeType.Breakfast:
                    sql = $"SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName AND RecipeType = 'Breakfast';";
                    break;
                case RecipeType.Main:
                    sql = $"SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName AND RecipeType = 'Main Course';";
                    break;
                case RecipeType.Side:
                    sql = $"SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName AND RecipeType = 'Side Dish';";
                    break;
                case RecipeType.Dessert:
                    sql = $"SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName AND RecipeType = 'Dessert';";
                    break;
                case RecipeType.Drink:
                    sql = $"SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName AND RecipeType = 'Drink';";
                    break;
                default:
                    sql = $"SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName";
                    break;
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                return connection.Query<RecipesModel>(sql, new { RecipeName = $"%{recipeName}%" }).ToList();
            }
        }

        public int CreateRecipeInfo(RecipesModel rm, List<InstructionsModel> instructions)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                var dParam = new DynamicParameters();

                dParam.Add("@RecipeName", rm.RecipeName);
                if (rm.RecipeDescription != "") dParam.Add("@RecipeDescription", rm.RecipeDescription);
                dParam.Add("@RecipeType", rm.RecipeType);
                dParam.Add("@RecipeId", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spRecipes_Insert", dParam, commandType: CommandType.StoredProcedure);

                rm.RecipeId = dParam.Get<int>("@RecipeId");

                instructions.ForEach(x => x.RecipeId = rm.RecipeId);
                connection.Execute("dbo.spInstructions_Insert @RecipeId, @Instruction", instructions);

                return rm.RecipeId;
            }
        }

        public void InsertFullRecipe(List<IngredientsModel> ingredients, int recipeID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                var dParam = new DynamicParameters();

                ingredients.ForEach(x =>
                {
                    x.RecipeId = recipeID;
                    dParam.Add("@Ingredient", x.Ingredient);
                    dParam.Add("@IngredientId", 0, DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spIngredients_Insert", dParam, commandType: CommandType.StoredProcedure);

                    x.IngredientId = dParam.Get<int>("@IngredientId");
                });

                connection.Execute("dbo.spRecipeIngredients_Insert @RecipeId, @IngredientId, @IngredientQuantity, @IngredientUnit", ingredients);
            }
        }

        public RecipesModel ViewRecipe(int recipeId, out List<IngredientsModel> ingredients, out List<InstructionsModel> instructions)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                var ingredientsModel = new IngredientsModel { RecipeId = recipeId };
                var instructionsModel = new InstructionsModel { RecipeId = recipeId };

                ingredients = connection.Query<IngredientsModel>("dbo.spRecipeIngredients_SelectSingle @RecipeID", ingredientsModel).ToList();
                instructions = connection.Query<InstructionsModel>("dbo.spInstructions_SelectSingle @RecipeID", instructionsModel).ToList();

                return connection.QuerySingle<RecipesModel>("dbo.spRecipes_SelectSingle @RecipeId", new { RecipeId = recipeId });
            }
        }

        public void UpdateRecipe(RecipesModel rm, List<IngredientsModel> ingredients, List<InstructionsModel> instructions)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                connection.Execute("dbo.spRecipes_Update @RecipeID, @RecipeName, @RecipeDescription, @RecipeType", rm);

                instructions.ForEach(x => x.RecipeId = rm.RecipeId);
                ingredients.ForEach(x => x.RecipeId = rm.RecipeId);

                connection.Execute("dbo.spInstructions_Update @RecipeId, @InstructionId, @Instruction", instructions);
                connection.Execute("dbo.spRecipeIngredients_Update @RecipeId, @IngredientId, @IngredientQuantity, @IngredientUnit, @Ingredient", ingredients);

                if (rm.deletedInstructions.Count > 0) connection.Execute("dbo.spInstructions_Delete @InstructionId", rm.deletedInstructions);
                if (rm.deletedIngredients.Count > 0) connection.Execute("dbo.spIngredientRecipes_Delete @IngredientId", rm.deletedIngredients);
            }
        }

        public void DeleteFullRecipe(int recipeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                connection.Execute("dbo.spRecipes_DeleteFullRecipe @RecipeId", new { RecipeId = recipeId });
            }
        }
    }
}
