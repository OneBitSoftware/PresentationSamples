using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressionBuilderHelper;

namespace ExpressionBuilder
{
    public class Program
    {
        public static List<Car> cars = new List<Car> {
            new Car
            {
                BasePrice=20000,
                CountryOfOrigin="Italy",
                CountryOfProduction="Serbia",
                FullPrice=30000,
                Make="Fiat",
                MaxMilesPerHour=190,
                MilesPerGallon=40,
                Model="Punto",
                NumberOfSeats=5,
                WeightInKg=1000
            },
            new Car
            {
                BasePrice=60000,
                CountryOfOrigin="Germany",
                CountryOfProduction="Spain",
                FullPrice=100000,
                Make="Mercedes",
                MaxMilesPerHour=230,
                MilesPerGallon=20,
                Model="S320CDI",
                NumberOfSeats=5,
                WeightInKg=2000
            },
            new Car
            {
                BasePrice=35000,
                CountryOfOrigin="Japan",
                CountryOfProduction="China",
                FullPrice=60000,
                Make="Honda",
                MaxMilesPerHour=220,
                MilesPerGallon=30,
                Model="Accord",
                NumberOfSeats=5,
                WeightInKg=1800
            },
            new Car
            {
                BasePrice=15000,
                CountryOfOrigin="Romania",
                CountryOfProduction="Romania",
                FullPrice=30000,
                Make="Dacia",
                MaxMilesPerHour=180,
                MilesPerGallon=35,
                Model="Duster",
                NumberOfSeats=5,
                WeightInKg=1600
            },
            new Car
            {
                BasePrice=20000,
                CountryOfOrigin="Czech Republic",
                CountryOfProduction="Czech Republic",
                FullPrice=40000,
                Make="Skoda",
                MaxMilesPerHour=190,
                MilesPerGallon=38,
                Model="Fabia",
                NumberOfSeats=5,
                WeightInKg=1200
            },
            new Car
            {
                BasePrice=50000,
                CountryOfOrigin="Germany",
                CountryOfProduction="Germany",
                FullPrice=120000,
                Make="BMW",
                MaxMilesPerHour=250,
                MilesPerGallon=20,
                Model="330i",
                NumberOfSeats=5,
                WeightInKg=1800
            },
            new Car
            {
                BasePrice=45000,
                CountryOfOrigin="Germany",
                CountryOfProduction="Germany",
                FullPrice=110000,
                Make="AUDI",
                MaxMilesPerHour=240,
                MilesPerGallon=25,
                Model="A4",
                NumberOfSeats=5,
                WeightInKg=1750
            },
            new Car
            {
                BasePrice=25000,
                CountryOfOrigin="France",
                CountryOfProduction="France",
                FullPrice=70000,
                Make="Citroen",
                MaxMilesPerHour=200,
                MilesPerGallon=35,
                Model="DS5",
                NumberOfSeats=5,
                WeightInKg=1500
            },
            new Car
            {
                BasePrice=20000,
                CountryOfOrigin="France",
                CountryOfProduction="France",
                FullPrice=40000,
                Make="Citroen",
                MaxMilesPerHour=180,
                MilesPerGallon=45,
                Model="Megane",
                NumberOfSeats=5,
                WeightInKg=1200
            }
        };

        static void Main(string[] args)
        {
            var filters = new List<ExpressionFilter> 
            { 
                new ExpressionFilter
                {
                    PropertyName="CountryOfOrigin",
                    Comparison=Comparison.StartsWith,
                    Value="Fr"
                },
                new ExpressionFilter
                {
                    PropertyName="MaxMilesPerHour",
                    Comparison=Comparison.GreaterThanOrEqual,
                    Value=190
                }
            };

            var expressionTree= ExpressionBuilderHelper.ExpressionBuilder.ConstructAndExpressionTree<Car>(filters);
            var anonymousFunc = expressionTree.Compile();
            var result = cars.Where(anonymousFunc);
        }
    }
}
