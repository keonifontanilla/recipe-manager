using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.Models
{
    /// <summary>
    /// This class is a model for recipes.
    /// </summary>
    public class RecipesModel
    {
        /// <summary>
        /// The recipe's id.
        /// </summary>
        public int RecipeId { get; set; }
        /// <summary>
        /// The recipe's name.
        /// </summary>
        public string RecipeName { get; set; }
        /// <summary>
        /// The recipe's description.
        /// </summary>
        public string RecipeDescription { get; set; }
        /// <summary>
        /// The recipe's type.
        /// </summary>
        public string RecipeType { get; set; }
        /// <summary>
        /// The date the recipe was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// The date the recipe was updated.
        /// </summary>
        public DateTime UpdatedDate { get; set; }
        /// <summary>
        /// List of instructions to delete.
        /// </summary>
        public List<InstructionsModel> deletedInstructions { get; set; } = new List<InstructionsModel>();
        /// <summary>
        /// List of ingredients to delete.
        /// </summary>
        public List<IngredientsModel> deletedIngredients { get; set; } = new List<IngredientsModel>();
        /// <summary>
        /// Displays recipe info.
        /// </summary>
        public string RecipeInfo
        {
            get { return $"Name: {RecipeName}{Environment.NewLine}Description: {RecipeDescription}{Environment.NewLine}Type: {RecipeType}{Environment.NewLine}"; }
        }
    }
}
