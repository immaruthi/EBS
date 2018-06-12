using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace OpenHouse.API
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
            services.AddMvc();

            services.AddSwaggerGen(sw =>
            {
                sw.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Open API",
                    Description = "Open API Services",
                    TermsOfService = "copy rights from Sapient",
                    Contact = new Contact
                    {
                        Email = "maruthi@iamgood.in",
                        Name = "Maruthi Pallamalli",
                        Url = "https://msdn.com"
                    },
                    License = new License
                    {
                        Name = "Use under Sapient Corporation",
                        Url = "https://example.com"
                    }
                });
            });

                //services.AddMvc().AddWebApiConventions();
            }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(sw =>
            {
                sw.SwaggerEndpoint("/swagger/v1/swagger.json", "Open API");
            });

            //app.UseMvc(routes =>
            //{
            //    routes.MapWebApiRoute("Default", "api/{controler}/{id?}");
            //});
        }
    }
}
