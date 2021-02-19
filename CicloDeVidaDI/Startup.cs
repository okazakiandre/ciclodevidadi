using CicloDeVidaDI.Combinacoes;
using CicloDeVidaDI.Contadores;
using CicloDeVidaDI.Services;
using CicloDeVidaDI.Validacoes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CicloDeVidaDI
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
            services.AddControllers();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CicloDeVidaDI",
                    Description = "API usada para demonstrar o uso de Singleton, Scoped e Transient.",
                    Contact = new OpenApiContact
                    {
                        Name = "André Okazaki",
                        Email = "andre@desenvolverideias.com"
                    }
                });
            });

            services.AddSingleton<IContadorSingleton, ContadorSingleton>();

            services.AddScoped<IContadorScoped, ContadorScoped>();
            //services.AddScoped<IContadorScoped>(f =>
            //{
            //    var s = "";
            //    return new ContadorScoped();
            //});
            //services.AddScoped<ContadorScoped>();
            //services.AddScoped(f => new ContadorScoped());
            services.AddScoped<IClienteScopedService, ClienteScopedService>();
            services.AddScoped<IProdutoScopedService, ProdutoScopedService>();

            services.AddTransient<IContadorTransient, ContadorTransient>();
            services.AddTransient<IAdvogadoTransientService, AdvogadoTransientService>();
            services.AddTransient<IJuizTransientService, JuizTransientService>();

            services.AddScoped<IValidacao, DataEntradaDaquiA5Dias>();
            services.AddScoped<IValidacao, DataSaidaPosteriorAEntrada>();
            services.AddScoped<IValidacao, EstadiaMinimaDe3Dias>();

            services.AddSingleton<IClasseSingletonScoped, ClasseSingletonScoped>();
            services.AddSingleton<IClasseSingletonTransient, ClasseSingletonTransient>();
            services.AddScoped<IClasseScopedSingleton, ClasseScopedSingleton>();
            services.AddScoped<IClasseScopedTransient, ClasseScopedTransient>();
            services.AddSingleton<IClasseSingleton, ClasseSingleton>();
            services.AddScoped<IClasseScoped, ClasseScoped>();
            services.AddTransient<IClasseTransient, ClasseTransient>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CicloDeVidaDI V1");
            });
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
