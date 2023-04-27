using lab2.model.country;


namespace lab2.model.city
{
    public class city
    {

       
        public int ID { get; set; }
        public string Name { get; set; }

        public int country_ID { get; set; }






        public model.country.country country { get; set; }

    }
}
