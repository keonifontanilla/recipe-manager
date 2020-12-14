using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace recipe_manager.API
{
    public class ApiRecipeProcessor
    {
        public static async Task<(List<ApiRecipeModel> apiRecipes, int totalResults)> LoadRecipes(string searchTerm)
        {
            var apiKey = ConfigurationManager.AppSettings["APIKey"];
            var url = $"recipes/complexSearch?apiKey={apiKey}&query={searchTerm}&addRecipeInformation=true&addRecipeInformation=true&fillIngredients=true";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<ApiRecipeResultModel>();

                    return (result.Results, result.TotalResults);
                }
                else
                {
                    throw new Exception($"{response.ReasonPhrase}. Search again or check connection.");
                }
            }
        }
    }
}
