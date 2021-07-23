using Adopt1Dev.ASP.Tools;
using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.ASP.Services;
using Labo.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP
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
            services.AddControllersWithViews();

            services.AddSession(
                options => {
                    options.IdleTimeout = TimeSpan.FromMinutes(15);
                    options.Cookie.Name = "VaccinCookie";
                    options.Cookie.HttpOnly = true; //Important à mettre / Empecher l'utilisation du cookie coté client si true                 
                }
                );

            //Injection pour permettre l'utilisation des sessions dans les classes non mvc
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<DataContext>();
            services.AddScoped<IService<CentreModel, CentreForm>, CentreService>();
            services.AddScoped<IService<AdressModel, AdressForm>, AdressService>();
            services.AddScoped<IService<HeureOuvertureModel, HeureOuvertureForm>, HeureOuvertureService>();
            services.AddScoped<IService<PersonnelModel, PersonnelForm>, PersonnelService>();
            services.AddScoped<IService<LotVaccinModel, LotVaccinForm>, LotVaccinService>();
            services.AddScoped<IService<InjectionModel, InjectionForm>, InjectionService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();
            SessionUtils.Services = app.ApplicationServices;


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
