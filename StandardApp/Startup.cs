using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using StandardApp.Models;
using StandardApp.Services;
namespace StandardApp
{
    public class Startup
    {
        /// <summary>
        /// The Startups is having an access to Application Configuration
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. 
        //Use this method to add services for DI to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // register the DbContext in the Container
            services.AddDbContext<EkatmERPContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("EkatmDbConnection"));
            });

            // define cors service injection
            services.AddCors(options => 
                    options.AddPolicy("corspolicy", policy=>policy.AllowAnyOrigin()
                                        .AllowAnyMethod()
                                        .AllowAnyHeader()));


            // register all services aka repositories in DI
            services.AddScoped<IEkatmService<UserMaster,Guid>, UserMasterService>();
            services.AddScoped<IEkatmService<StateMaster, string>, StateMasterService>();
            services.AddScoped<IEkatmService<DeptMaster, string>, DeptMasterService>();

            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver
              = new DefaultContractResolver())
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // use the CORS Middleware
            app.UseCors("corspolicy");
            app.UseMvc();
        }
    }
}
