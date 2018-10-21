using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Parcial.Common.Infraestructure.Persistence.NHibernate;
using Parcial.Items.Application.Assembler;
using Parcial.Common.Application;
using Parcial.Items.Domain.Repository;
using Parcial.Items.Infraestructure.Persistence.NHibernate.Repository;

namespace Parcial
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton(new SessionFactory(
                Environment.GetEnvironmentVariable("PARCIAL_MYSQL_STRCON_PATTERNS", EnvironmentVariableTarget.Machine)));

            var serviceProvider = services.BuildServiceProvider();
            var mapper = serviceProvider.GetService<IMapper>();            
            services.AddSingleton(new ItemAssembler(mapper));
            services.AddScoped<IUnitOfWork, UnitOfWorkNHibernate>();

            services.AddTransient<IItemRepository, ItemNHibernateRepository>((ctx) =>
            {
                IUnitOfWork unitOfWork = ctx.GetService<IUnitOfWork>();
                return new ItemNHibernateRepository((UnitOfWorkNHibernate)unitOfWork);
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
