using System.Text;

namespace lab1_mvc
{
    public class Handeler1
    {

        HttpContext Context;
        public Handeler1(HttpContext _Context)
        {
            Context = _Context;
        }

        public async void GetBooks()
        {
            FileStream FileStream = new FileStream("data/Book.txt",
                          FileMode.Open,
                          FileAccess.Read);
            StreamReader StreamReader = new StreamReader(FileStream);
            string line = "";
            List<Book_class> list = new List<Book_class>();

            while ((line = StreamReader.ReadLine()) != null)
            {
                string[] row = line.Split(',');
                list.Add(new Book_class()
                {
                    ID = int.Parse(row[0]),
                    Name = row[1],
                    Author = row[2],
                    Publisher = row[3]
                });
            }
            StringBuilder StringBuilder = new StringBuilder();

            foreach (var book in list)
            {
                StringBuilder.Append($"{book.ID}");
                StringBuilder.Append($"{book.Name}");
                StringBuilder.Append($"{book.Author}");
                StringBuilder.Append($"{book.Publisher}");

            }

            await Context.Response.WriteAsync(StringBuilder.ToString());


        }
    }
}
