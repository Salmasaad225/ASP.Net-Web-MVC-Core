using lab1_mvc.contact;

namespace lab1_mvc._3
{
    public static class Middlewareextention3
    {

        public static void UseMiddleWare3(this WebApplication app)
        {
            app.UseMiddleware<Middleware3>();
        }
    }
}
