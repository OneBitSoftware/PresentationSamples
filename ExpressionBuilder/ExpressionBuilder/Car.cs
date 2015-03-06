using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBuilder
{
    public class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public string CountryOfOrigin { get; set; }
        public string CountryOfProduction { get; set; }

        public int MaxMilesPerHour { get; set; }
        public int NumberOfSeats { get; set; }
        public int MilesPerGallon { get; set; }
        public double WeightInKg { get; set; }

        public decimal BasePrice { get; set; }
        public decimal FullPrice { get; set; }
    }
}
