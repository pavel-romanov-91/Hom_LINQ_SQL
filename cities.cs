

namespace Hom_LINQ_SQL
{
    public class cities
    {
        public int id { get; set; }  
        public string name { get; set; }
        public int? population { get; set; }
        public int? country_id { get; set; }
        public virtual countries countries { get; set; }

        public cities( string name, int? population, int? country_id, countries countries)
        {

            this.name = name;
            this.population = population;
            this.country_id = country_id;
            this.countries = countries;
        }

        public cities() { }
    }
}
