using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using RestaurantAPI.Models;

[assembly: OwinStartup(typeof(RestaurantAPI.App_Start.Startup))]

namespace RestaurantAPI.App_Start
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<Restaurant>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DevConnection")));
        }

        
    }
}
