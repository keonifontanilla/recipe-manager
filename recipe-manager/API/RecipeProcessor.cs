using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.API
{
    public class RecipeProcessor
    {
        public static async Task<List<ApiRecipeModel>> LoadRecipes(string searchTerm)
        {
            var apiKey = ConfigurationManager.AppSettings["APIKey"];
            var url = $"recipes/complexSearch?apiKey={apiKey}&query={searchTerm}&addRecipeInformation=true";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<ApiRecipeResultModel>();

                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
