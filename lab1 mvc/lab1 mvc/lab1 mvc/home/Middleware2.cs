namespace lab1_mvc.home
{
    public  class Middleware2
    {

      


            RequestDelegate Next;
            public Middleware2(RequestDelegate _Next)
            {
                Next = _Next;
            }

            public async Task InvokeAsync(HttpContext _Context)
            {
                var path2 = _Context.Request.Path.ToString().ToLower();
                switch (path2)
                {
                    case "/home/aboutus":
                        var handel = new handler2(_Context);
                        handel.Getinfo();

                        break;

                    default:
                        await Next(_Context);
                        break;
                }

            }
        }
}
