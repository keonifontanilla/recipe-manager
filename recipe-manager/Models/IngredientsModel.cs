using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.Models
{
    /// <summary>
    /// This is class is a model for ingredients.
    /// </summary>
    public class IngredientsModel
    {
        /// <summary>
        /// This is the ingredient's id.
        /// </summary>
        public int IngredientId { get; set; }
        /// <summary>
        /// This is the ingredient.
        /// </summary>
        public string Ingredient { get; set; }
        /// <summary>
        /// This is the ingredient's quantity.
        /// </summary>
        public float IngredientQuantity { get; set; }
        /// <summary>
        /// This is the ingredient's unti.
        /// </summary>
        public string IngredientUnit { get; set; }
    }
}
