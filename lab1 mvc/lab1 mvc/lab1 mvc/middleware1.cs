namespace lab1_mvc
{
    public class Middleware1
    {

        RequestDelegate Next;
        public Middleware1(RequestDelegate _Next)
        {
            Next = _Next;
        }

        public async Task InvokeAsync(HttpContext _Context)
        {
            var path = _Context.Request.Path.ToString().ToLower();
            switch (path)
            {
                case "/book/get":
                    var handel = new Handeler1(_Context);
                    handel.GetBooks();
                   
                    break;

                default:
                    await Next(_Context);
                    break;
            }

        }
    }
}
