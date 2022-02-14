using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFacts.Models
{
    public class FactModel
    {
        public string Fact { get; set; }
        public int Length { get; set; }

        public string GetFactString()
        {
            return $"Fact: {Fact} - length: {Length}";
        }
    }
}
