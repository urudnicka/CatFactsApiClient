using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CatFacts
{
    class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitialiseClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://catfact.ninja/");
        }
    }
}
