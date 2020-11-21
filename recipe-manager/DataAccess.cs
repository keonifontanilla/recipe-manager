using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager
{
    public class DataAccess
    {
        private string connStr = ConfigurationManager.ConnectionStrings["RecipesDB"].ConnectionString;
    }
}
