using System.Text;

namespace lab1_mvc.contact
{
    public class handler3
    {
        HttpContext Context;
        public handler3( HttpContext _Context)
        {
            Context = _Context;
        }

        public async void Getinfo()
        {
            FileStream FileStream = new FileStream("data3/aboutus.txt",
                          FileMode.Open,
                          FileAccess.Read);
            StreamReader StreamReader = new StreamReader(FileStream);
            string line = "";
            List<Contact> list = new List<Contact>();

            while ((line = StreamReader.ReadLine()) != null)
            {
                string[] row = line.Split(',');
                list.Add(new Contact()
                {
                    ID = int.Parse(row[0]),
                    Name = row[1],
                    Hoppy = row[2],
                   
                });
            }
            StringBuilder S_Builder = new StringBuilder();

            foreach (var item in list)
            {
                S_Builder.Append($"{item.ID}");
                S_Builder.Append($"{item.Name}");
                S_Builder.Append($"{item.Hoppy}");
               

            }

            await Context.Response.WriteAsync(S_Builder.ToString());


        }
    }
}

