using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CommonSolutions;

namespace CarFactory
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<CarsInterfaces.ICarsRepository, CarsRepository.CarRepository>();
            services.AddScoped<CarsInterfaces.ICarsProvider, CarsProvider.CarProvider>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            WireResolutions();

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        public void WireResolutions()
        {
            List<Type> lstTypes = new List<Type>();
            //var appsTypes = new List<string>
            //{
            //        "CarsRepository.CarRepository,CarsRepository",
            //        "CarsProvider.CarProvider,CarsProvider",
            //};

            //foreach (var x in appsTypes)
            //{
            //    var type = Type.GetType(x);
            //    lstTypes.Add(type);
            //}
            //AppsObjectsBinding.InitializeTypes(lstTypes);
            
            // Added some Comments for testing

            var carsTypes = new List<string>
            {
                    "Audi.SportsCars,Audi",
                    "BMW.SedanCars,BMW",
                    "Jaguar.LuxuryCars,Jaguar"
            };
            foreach (var x in carsTypes)
            {
                var type = Type.GetType(x);
                lstTypes.Add(type);
            }
            CarsObjectBinding.InitializeTypes(lstTypes);
        }
    }
}
