using MediatR;
using Klient.DAO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Swashbuckle.AspNetCore.Swagger;
using Klient.WebAPI.Diagnostics;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using System;
using Serilog;
using AutoMapper;
using Klient.Application.Adresses.Commands.CreateAdres;
using FluentValidation.AspNetCore;
using Klient.Application.Klients.Commands.CreateKlient;
using Klient.Application.Infrastructure;
using FluentValidation;
using Klient.WebAPI.Filters;

namespace Klient.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration()              
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File("Logs\\KlientApp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddMediatR(typeof(CreateAdresCommand).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            services
                .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateKlientCommandValidator>());

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddDbContext<DataContext>(
                options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                });
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Info
                {
                    Title = "Klient",
                    Version = "v1"
                });
            });        
            
            var builder = new ContainerBuilder();
            builder.Populate(services);

            builder.RegisterAssemblyTypes(typeof(Startup).GetType().Assembly)
                .Where(t => t.IsClosedTypeOf(typeof(IValidator<>)))
                .AsImplementedInterfaces();            
            builder.Register<ILogger>((c, p) => 
                {
                    return Log.Logger;
                }).SingleInstance();
            ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(ApplicationContainer);
        }


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

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseMiddleware<SerilogMiddleware>();
            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Klient App");
                x.RoutePrefix = string.Empty;
            });
        }
    }
}
