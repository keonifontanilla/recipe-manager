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
        /// The recipe's id.
        /// </summary>
        public int RecipeId { get; set; }
        /// <summary>
        /// This is the ingredient.
        /// </summary>
        public string Ingredient { get; set; }
        /// <summary>
        /// This is the ingredient's quantity.
        /// </summary>
        public string IngredientQuantity { get; set; }
        /// <summary>
        /// This is the ingredient's unit.
        /// </summary>
        public string IngredientUnit { get; set; }
        /// <summary>
        /// Displays ingredient info.
        /// </summary>
        public string IngredientInfo
        {
            get { return $"{IngredientQuantity} {IngredientUnit} {Ingredient}{Environment.NewLine}"; }
        }
    }
}
