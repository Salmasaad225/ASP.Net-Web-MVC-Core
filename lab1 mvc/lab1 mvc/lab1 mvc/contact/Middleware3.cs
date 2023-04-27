namespace lab1_mvc.contact
{
    public class Middleware3
    {


        RequestDelegate Next;
        public Middleware3(RequestDelegate _Next)
        {
            Next = _Next;
        }

        public async Task InvokeAsync(HttpContext _Context)
        {
            var path3 = _Context.Request.Path.ToString().ToLower();
            switch (path3)
            {
                case "/home/contact":
                    var handel = new handler3(_Context);
                    handel.Getinfo();

                    break;

                default:
                    await Next(_Context);
                    break;
            }

        }
    }
}
