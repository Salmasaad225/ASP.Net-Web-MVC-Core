using lab1_mvc._2;
using lab1_mvc._3;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_mvc
{
    public class Program
    {

        static async Task HomeIndexPage(HttpContext _Context)
        {
            if (_Context.Request.Path == "/home/index")
            {

                await _Context.Response.WriteAsync("HOME");

             
            }
        }
        public static int Main()
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();


            //1111111111111111111111111111111

            //app.Run(HomeIndexPage);



            app.Run(async _Context =>
            {
                if (_Context.Request.Path == "/home/index")
                {

                    await _Context.Response.WriteAsync("HOME");


                }


            });




            //22222222222222222222222222222222222

            app.UseBookMiddleWare();
            app.UseMiddleWare3();
            app.UseMiddleWare2();


            //app.Run(async _Context =>
            //{
            //    var path = _Context.Request.Path.ToString().ToLower();
            //    switch (path)
            //    {
            //        case "/home/index":
            //            await _Context.Response.WriteAsync("home index" + " <a href='/book/get'>Book Page</a>");
            //            break;
            //        case "/home/aboutus":
            //            await _Context.Response.WriteAsync("home about us");
            //            break;
            //        case "/home/contact":
            //            await _Context.Response.WriteAsync("home contact");
            //            break;

            //        default:
            //            break;
            //    }

            //});



            app.Run();

          

            return 0;
        }


    }
}
