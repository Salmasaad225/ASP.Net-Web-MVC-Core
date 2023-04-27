using lab1_mvc.contact;
using lab1_mvc.home;

namespace lab1_mvc._2
{
    public static class Middlewareextention2
    {
        public static void UseMiddleWare2(this WebApplication app)
        {
            app.UseMiddleware<Middleware2>();
        }
    }
}
