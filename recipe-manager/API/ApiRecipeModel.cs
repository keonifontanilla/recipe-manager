using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.API
{
    public class ApiRecipeModel
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string[] DishTypes { get; set; }
    }
}
