using JsonApiDotNetCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Webpage.API.Data;

namespace Webpage.API
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


            services.Configure<WebpageSettings>(Configuration);

            //var server = Configuration["DatabaseServer"];
            //var database = Configuration["DatabaseName"];
            //var user = Configuration["DatabaseUser"];
            //var password = Configuration["DatabaseUserPassword"];
            //var connectionString = String.Format("Server={0};Database={1};User={2};Password={3};", server, database, user, password);
            var connectionString = String.Format("Server={0};Database={1};User={2};Password={3};", "localhost", "webpagesdb", "sa", "TeKa.6162");



            services.AddDbContext<WebpageDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            }, ServiceLifetime.Transient);


            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    // Enum as string and Ignore null values
                    // options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                    // options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            // Open API
            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "ServicesOG - Webpages API",
                    Version = "V1",
                    Description = "Description - TODO",
                    TermsOfService = "Terms of Service - TODO"
                });
            });



            services.AddJsonApi<WebpageDbContext>(options =>
            {
                options.Namespace = "api/v1";
                options.DefaultPageSize = 20;
            });
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

            // app.UseHttpsRedirection();

            app.UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/v1/swagger.json", "Webpages API V1");
                });



            app.UseJsonApi();
        }
    }
}
