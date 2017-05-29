using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SOSTrucksMonitor.api.Entities;
using Aspnet.Core.Data;
using SOSTrucksMonitor.api.Repositories;
using SOSTrucksMonitor.api.Features.TrucksMonitor;
using Swashbuckle.Swagger.Model;

namespace SOSTrucksMonitor.api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Add framework services.
            services.AddDbContext<SOSMonitorContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SOSMonitorDatabase")));
            services.AddScoped<DbContext, SOSMonitorContext>();
            services.AddScoped<ITruckMonitorRepository, TruckMonitorRepository>();
            services.AddScoped<TrucksMonitorAppService>();

            services.AddSwaggerGen();
            services.ConfigureSwaggerGen(options =>
            {
                options.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "SOS Trucks Monitor Web API",
                    Description = "Todos los metodos compartidos del API del Truck Monitor",
                    TermsOfService = "Ninguno"
                });
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseSwagger();
            app.UseSwaggerUi();

            app.UseMvc();
        }
    }
}
