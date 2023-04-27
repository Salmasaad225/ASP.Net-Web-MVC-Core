using lab1_mvc.contact;
using System.Text;

namespace lab1_mvc.home
{
    public class handler2
    {
        HttpContext Context;
        public handler2(HttpContext _Context)
        {
            Context = _Context;
        }

        public async void Getinfo()
        {
            FileStream FileStream = new FileStream("data2/home.txt",
                          FileMode.Open,
                          FileAccess.Read);
            StreamReader StreamReader = new StreamReader(FileStream);
            string line = "";
            List<Home> list = new List<Home>();

            while ((line = StreamReader.ReadLine()) != null)
            {
                string[] row = line.Split(',');
                list.Add(new Home()
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
