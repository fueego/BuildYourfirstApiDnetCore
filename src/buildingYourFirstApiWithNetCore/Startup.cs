﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace buildingYourFirstApiWithNetCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
                    //.AddJsonOptions(o=>
                    //{
                    //    if(o.SerializerSettings.ContractResolver != null)
                    //    {
                    //        var castedResolver = o.SerializerSettings.ContractResolver as DefaultContractResolver;
                    //            castedResolver.NamingStrategy = null;
                    //    }
                    //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(); 
            }

            app.UseStatusCodePages();
            app.UseMvc();
            
        }
    }
}
