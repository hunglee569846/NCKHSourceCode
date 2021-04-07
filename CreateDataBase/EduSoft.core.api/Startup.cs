using Autofac;
using Edusoft.core.Infrastructure.AutofacModules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace EduSoft.core.api
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
            services.AddRazorPages();
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                services.AddCors();
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    //TermsOfService = "http://daotao.humg.edu.vn/",
                    Version = "v1",
                    Title = "NCKH-QLDA API",
                    Description = "HUMG-Edusoft API",
                    Contact = new OpenApiContact
                    {
                        Name = "HUMG",
                        Email = string.Empty,
                        Url = new Uri("http://daotao.humg.edu.vn/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Về chúng tôi.",
                        Url = new Uri("http://daotao.humg.edu.vn/")
                    },
                });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ApplicationModule(Configuration.GetConnectionString("WebsiteConnection")));
            builder.RegisterModule(new ValidationModule());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            #region Allow Origins
            //var allowOrigins = Configuration.GetSection("AllowOrigins")
            //    .GetChildren().Select(x => x.Value).ToArray();
            //app.UseCors(builder =>
            //{
            //    builder.WithOrigins(allowOrigins);
            //    builder.AllowAnyHeader();
            //    builder.AllowAnyMethod();
            //    builder.AllowCredentials();
            //});
            #endregion

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "HUMG API V1");
                ////options.SwaggerEndpoint("/swagger/v2/swagger.json", "My API V2");
                options.RoutePrefix = "api";
                options.DocumentTitle = "Website Api Documentation";
                options.DisplayOperationId();
                options.DisplayRequestDuration();
                options.EnableDeepLinking();
                //options.MaxDisplayedTags(20);
                options.EnableFilter();
                options.ShowExtensions();
                options.DocExpansion(DocExpansion.None);
            });

        }
    }
    }

