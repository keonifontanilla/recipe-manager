﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.API
{
    public class ApiRecipeResultModel
    {
        public List<ApiRecipeModel> Results { get; set; } = new List<ApiRecipeModel>();
    }
}