using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFactsDI.Models
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