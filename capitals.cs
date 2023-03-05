

namespace Hom_LINQ_SQL
{
    public class capitals
    {
        public int  id { get; set;}
        public string name { get; set;}
        public int? population { get; set;}
        public virtual countries countries { get; set;}
        public capitals() { }
        public capitals( string name, int? population, countries countries)
        {
            this.name = name;
            this.population = population;
            this.countries = countries;
        }
    }
}
