using CatFacts.Models;
using System;
using System.IO;
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

            Directory.CreateDirectory(@"..\..\..\Data");
            string filePath = @"..\..\..\Data\facts.txt";
            StreamWriter sw;

            if (!File.Exists(filePath))
                sw = File.CreateText(filePath);
            else
                sw = File.AppendText(filePath);

            while (true)
            {
                var fact = await FactProcessor.LoadFactAsync();

                string factText = fact.GetFactString();
                Console.WriteLine(factText);

                try 
                { 
                    sw.WriteLine(factText);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fact not added to the file. Reason: " + e.Message);
                }

                Console.WriteLine("Do you want to get another cat fact? y/n");

                if (Console.ReadLine() == "y")
                    continue;
                else
                    break;
            }

            sw.Dispose();
        }

    }
}
