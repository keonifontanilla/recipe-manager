using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace recipe_manager.API
{
    public class ApiRecipeModel
    {
        private string summary = "";

        public string Title { get; set; }
        public string Summary 
        {
            get { return Regex.Replace(summary, "<.*?>", String.Empty); }
            set { summary = value; }
        }
        public string[] DishTypes { get; set; }
        public string DishType 
        {
            get 
            {
                var dishType = "";
                
                foreach(var type in DishTypes)
                {
                    if (type.Contains(RecipeType.Breakfast.ToString().ToLower())
                        || type.Contains(RecipeType.Main.ToString().ToLower())
                        || type.Contains(RecipeType.Side.ToString().ToLower())
                        || type.Contains(RecipeType.Dessert.ToString().ToLower())
                        || type.Contains(RecipeType.Drink.ToString().ToLower()))
                    {
                        dishType = type;
                        break;
                    }
                    else
                    {
                        dishType = "side";
                    }
                }

                return dishType;
            } 
        }
        public string SourceUrl { get; set; }

        public List<ApiIngredientsModel> ExtendedIngredients { get; set; }
        public List<ApiInstructionsModel> AnalyzedInstructions { get; set; }
    }
}
