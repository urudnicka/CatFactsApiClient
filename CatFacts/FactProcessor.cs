using CatFacts.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatFacts
{
    class FactProcessor
    {
        public static async Task<FactModel> LoadFactAsync()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("fact"))
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
