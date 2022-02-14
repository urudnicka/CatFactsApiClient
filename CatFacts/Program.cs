using CatFacts.Models;
using System;
using System.Threading.Tasks;

namespace CatFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to get a cat fact? y/n");
         
            if (Console.ReadLine() == "y")
            {
                RunAsync().GetAwaiter().GetResult();
            }

        }

        static async Task RunAsync()
        {
            ApiHelper.InitialiseClient();

            while (true)
            {
                var fact = await FactProcessor.LoadFactAsync();

                Console.WriteLine($"Fact: {fact.Fact}; Length: {fact.Length}");

                Console.WriteLine("Do you want to get another cat fact? y/n");

                if (Console.ReadLine() == "y")
                    continue;
                else
                    break;
            }

        }

    }
}
