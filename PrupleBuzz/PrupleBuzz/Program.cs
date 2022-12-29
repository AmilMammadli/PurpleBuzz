using Microsoft.EntityFrameworkCore;
using PrupleBuzz.DAL;

namespace PrupleBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
            });

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseEndpoints(endspoint =>
            {
                endspoint.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}