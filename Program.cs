using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hom_LINQ_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DB_Context())
            {
                var countries = new countries()
                {
                    name = "Riga",
                    population = 123441,
                    area = 214431,
                    part_of_the_world = "Europe"
                };
                var countries2 = new countries()
                {
                    name = "Польша",
                    population = 123441,
                    area = 214431,
                    part_of_the_world = "Europe"
                };
                context.Countries.Add(countries);
                context.Countries.Add(countries2);
                context.SaveChanges();

                
                
                //ICollection<cities> colCities = new List<cities>();
                //cities city1 = new cities();
                //cities city2 = new cities();
                //colCities.Add(city1);
                //colCities.Add(city2);
                //ICollection<capitals> colCountry = new List<capitals>();
                //colCountry.Add(new capitals());
                //countries country = new countries("Russia", 0, 5000000, 1000, "Asia", colCities, colCountry);
                //// создаем два объекта User

                //context.countries.Add(country);
                //context.capitals.Add(new capitals());
                //context.cities.Add(new cities());
                //context.cities.Add(new cities());
                //// добавляем их в бд

                //context.SaveChanges();
                // получаем объекты из бд и выводим на консоль

            }
            
        }
    }
}
