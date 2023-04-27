

namespace lab2.model.country
{
    public class country
    {

        public int ID { get; set; }
        public string Name { get; set; }
       
        public int continant_ID { get; set; }

        public model.continent.continent continent { get; set; }
        public ICollection<model.city.city> city { get; set; }
    }
}
