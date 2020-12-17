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
    /// <summary>
    /// Allows access to database for creating, reading, updating, and deleting records.
    /// </summary>
    public class DataAccess
    {
        private string connStr = ConfigurationManager.ConnectionStrings["RecipesDB"].ConnectionString;
        
        /// <summary>
        /// Selects all recipes from database.
        /// </summary>
        /// <returns>A list of RecipesModel.</returns>
        public List<RecipesModel> ListRecipes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                return connection.Query<RecipesModel>("dbo.spRecipes_SelectAllRecipes").ToList();
            }
        }

        /// <summary>
        /// Selects recipes from favorites table. 
        /// </summary>
        /// <returns>A list of RecipesModel.</returns>
        public List<RecipesModel> ListFavoriteRecipes()
        {
            var sql = "SELECT * FROM Recipes r INNER JOIN Favorites f ON r.RecipeId = f.RecipeId;";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                return connection.Query<RecipesModel>(sql).ToList();
            }
        }

        /// <summary>
        /// Search for a recipe buy name or filters recipes by recipe type.
        /// </summary>
        /// <param name="recipeName">The name of the recipe.</param>
        /// <param name="rt">The recipe type.</param>
        /// <returns>A list of RecipesModel.</returns>
        public List<RecipesModel> SearchRecipes(string recipeName, RecipeType rt)
        {
            var recipeType = rt.ToString();

            if (recipeType == RecipeType.Main.ToString())
            {
                recipeType = "Main Course";
            }
            else if (recipeType == RecipeType.Side.ToString())
            {
                recipeType = "Side Dish";
            }    

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                return connection.Query<RecipesModel>("dbo.spRecipes_SearchRecipes @RecipeName, @RecipeType", new { RecipeName = $"%{recipeName}%", RecipeType = recipeType }).ToList();
            }
        }

        /// <summary>
        /// Creates new recipe and inserts into database.
        /// </summary>
        /// <param name="rm">A list of RecipesModel.</param>
        /// <param name="instructions">A list of InstructionsModel.</param>
        /// <returns>A recipe id.</returns>
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

        /// <summary>
        /// Inserts the instructions and ingredients to the recipe.
        /// </summary>
        /// <param name="ingredients">A list of IngredientsModel.</param>
        /// <param name="recipeID">The id of the recipe.</param>
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

        /// <summary>
        /// Inserts a recipe into favorites table.
        /// </summary>
        /// <param name="recipeId">The id of the recipe.</param>
        public void InsertFavoriteRecipe(int recipeId)
        {
            var sql = "INSERT INTO Favorites (RecipeId) VALUES (@recipeId);";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                connection.Execute(sql, new { RecipeId = @recipeId });
            }
        }

        /// <summary>
        /// Selects a recipe to view.
        /// </summary>
        /// <param name="recipeId">The id of the recipe.</param>
        /// <param name="ingredients">A list of IngredientsModel.</param>
        /// <param name="instructions">A list of InstructionsModel.</param>
        /// <returns>A RecipesModel.</returns>
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

        /// <summary>
        /// Updates a recipe with its ingregients and instructions.
        /// </summary>
        /// <param name="rm">A RecipesModel.</param>
        /// <param name="ingredients">A list of IngredientsModel.</param>
        /// <param name="instructions">A list of InstructionsModel.</param>
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

        /// <summary>
        /// Deletes the full recipe along with the ingredients and instructions.
        /// </summary>
        /// <param name="recipeId">The id of the recipe.</param>
        public void DeleteFullRecipe(int recipeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                connection.Execute("dbo.spRecipes_DeleteFullRecipe @RecipeId", new { RecipeId = recipeId });
            }
        }

        /// <summary>
        /// Deletes the a recipes only from the favorites table.
        /// </summary>
        /// <param name="recipeId">The id of the recipe.</param>
        public void DeleteFavoriteRecipe(int recipeId)
        {
            var sql = "DELETE FROM Favorites WHERE RecipeId = @recipeId;";
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connStr))
            {
                connection.Execute(sql, new { RecipeId = @recipeId });
            }
        }
    }
}
