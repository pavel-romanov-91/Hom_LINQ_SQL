
using System.Collections.Generic;

namespace Hom_LINQ_SQL
{
    public class countries
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? capital_id { get; set; }
        public int? population { get; set; }
        public int area { get; set;}
        public string part_of_the_world { get; set;}

        public virtual ICollection<cities> cities { get; set; }
        public virtual ICollection<capitals> capitals { get; set; }

        public countries( string name, int? capital_id, int? population, int area, string part_of_the_world, ICollection<cities> cities, ICollection<capitals> capitals)
        {

            this.name = name;
            this.capital_id = capital_id;
            this.population = population;
            this.area = area;
            this.part_of_the_world = part_of_the_world;
            this.cities = cities;
            this.capitals = capitals;
        }

        public countries() { }
    }
}
