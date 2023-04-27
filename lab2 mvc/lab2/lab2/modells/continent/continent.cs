using lab2.model.country;

namespace lab2.model.continent
{
    public class continent
    {
      
            public int ID { get; set; }
            public string Name { get; set; }



            public ICollection<model.country.country> country { get; set; }
        
    }
}
