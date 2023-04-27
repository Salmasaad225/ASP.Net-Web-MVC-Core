namespace lab1_mvc
{
    public static class MiddleWareExtension
    {
        public static void UseBookMiddleWare(this WebApplication app)
        {
            app.UseMiddleware<Middleware1>();
        }
    }
}
