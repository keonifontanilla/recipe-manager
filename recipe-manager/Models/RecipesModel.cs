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
    }
}
