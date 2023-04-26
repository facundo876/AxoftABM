using AxoftABM.Interfaces;
using AxoftABM.Repositorys;
using AxoftABM.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AxoftABM
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

            //Dapper sql
            //services.AddScoped<IDbConnection>(db => new SqlConnection(Configuration.GetConnectionString("DefaultConnection")));

            //dapper memory
            services.AddSingleton<IDbConnection>(sp =>
            {
                var connection = new SqliteConnection(Configuration.GetConnectionString("MemoryConnection"));
                connection.Open();
                return connection;
            });
            services.AddScoped<ITareaService, TareaService>();
            services.AddScoped<ITareaRepository, TareaRepository>();
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Tareas}/{action=Index}/{id?}");
            });

            CrearTablaTareas(app);
        }

        private void CrearTablaTareas(IApplicationBuilder app)
        {
            // Aquí puedes llamar a tu servicio de intermediario o directamente ejecutar el código
            // para crear la tabla y los datos en la base de datos
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var tareaService = scope.ServiceProvider.GetService<ITareaService>();
                tareaService.CrearTablaTareas();
            }
        }
    }
}
