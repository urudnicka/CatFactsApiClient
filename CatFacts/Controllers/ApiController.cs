using CatFacts.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatFacts
{
    class ApiController
    {   
        public static HttpClient ApiClient { get; set; }

        public static void InitialiseClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://catfact.ninja/");
        }
        public static async Task<FactModel> LoadFactAsync()
        {
            using (HttpResponseMessage response = await ApiClient.GetAsync("fact"))
            {
                if (response.IsSuccessStatusCode)
                {
                    FactModel fact = await response.Content.ReadAsAsync<FactModel>();

                    return fact;
                }
                else
                {
                    throw new Exception(response.StatusCode + ": " + response.ReasonPhrase);
                }
            }
        }
    }
}
