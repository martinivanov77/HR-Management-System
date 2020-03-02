using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HRManagement
{
    public class Startup
    {
        private readonly IConfiguration config;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);

            //Add Dependency Injection
            services.AddTransient<IEmployeeRepository, SQLEmployeeRepository>(); 
            services.AddScoped<ICompanyRepository, MockCompanyRepository>();

            //Register the DB Context
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DbConnectionString")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

        }
    }
}
