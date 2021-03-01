using Jaeger;
using Jaeger.Samplers;
using MediatR;
using MicroservicesBus.Appointment.Data.Context;
using MicroservicesBus.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OpenTracing;
using OpenTracing.Util;
using Steeltoe.Discovery.Client;
using Steeltoe.Discovery.Eureka;
using System;
using System.Linq;
using System.Reflection;

namespace MicroservicesBus.Appointment.API
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

            services.AddDbContext<AppointmentDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppointmentDbConnection"));
            });
            services.AddSingleton<ITracer>(serviceProvider =>
            {
                string serviceName = Assembly.GetEntryAssembly().GetName().Name;

                ILoggerFactory loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

                ISampler sampler = new ConstSampler(sample: true);

                ITracer tracer = new Tracer.Builder(serviceName)
                    .WithLoggerFactory(loggerFactory)
                    .WithSampler(sampler)
                    .Build();

                GlobalTracer.Register(tracer);

                return tracer;
            });

            services.AddOpenTracing();
            services.AddControllers();
            services.AddMediatR(typeof(Startup));
            services.AddDiscoveryClient(Configuration);
            services.AddHealthChecks();
            services.AddSingleton<IHealthCheckHandler, ScopedEurekaHealthCheckHandler>();
            //Method call for registering IoC Container
            RegisterServices(services);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AppointmentAPI", Version = "v1" });
            });

        }


        /// <summary>
        /// Method to inject IoC to Project
        /// </summary>
        /// <param name="services"></param>
        private void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IMediator mediator)
        {
            if (mediator == null)
            {
                throw new ArgumentNullException(nameof(mediator));
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
         
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AppointmentAPI v1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseDiscoveryClient();
            app.UseHealthChecks("/api2/appointment");

        }

    }
}
