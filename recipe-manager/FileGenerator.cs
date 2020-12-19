using recipe_manager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_manager
{
    /// <summary>
    /// Generates a file and saves it to the chosen location.
    /// </summary>
    public class FileGenerator
    {
        private SaveFileDialog saveFileDialog = null;

        public FileGenerator(SaveFileDialog saveFileDialog)
        {
            this.saveFileDialog = saveFileDialog;
        }

        /// <summary>
        /// Generates a file with recipe information.
        /// </summary>
        /// <param name="recipe">The recipe information.</param>
        /// <param name="ingredients">A list of recipe ingredients.</param>
        /// <param name="instructions">A list of recipe instructions.</param>
        public void GenerateFile(RecipesModel recipe, List<IngredientsModel> ingredients, List<InstructionsModel> instructions)
        {
            using(var streamWriter = new StreamWriter(saveFileDialog.FileName, false))
            {
                var counter = 1;

                streamWriter.WriteLine(recipe.RecipeInfo);
                streamWriter.WriteLine("Ingredients");
                ingredients.ForEach(x => streamWriter.WriteLine(x.IngredientInfo));
                streamWriter.WriteLine("Instructions");
                instructions.ForEach(x => streamWriter.WriteLine($"Step {counter++}: {x.InstructionInfo}"));
            }
        }
    }
}
