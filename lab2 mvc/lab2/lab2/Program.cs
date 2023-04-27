using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Program
    {

        public static int Main()
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllerRoute("lab2", "{controller}/{action}");
            app.Run();

            return 0;
        }
    }
}
