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
    public class FileGenerator
    {
        private SaveFileDialog saveFileDialog = null;

        public FileGenerator(SaveFileDialog saveFileDialog)
        {
            this.saveFileDialog = saveFileDialog;
        }

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
