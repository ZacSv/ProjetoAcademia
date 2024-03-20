namespace ProjetoSiteAcademia.Views
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using ProjetoSiteAcademia.Controllers;
    using ProjetoSiteAcademia.Data;


        public class Startup
        {
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            // Este método é chamado durante a execução. Use este método para adicionar serviços ao contêiner.
            public void ConfigureServices(IServiceCollection services)
            {

            // Outros serviços podem ser adicionados aqui
        }

            // Este método é chamado durante a execução. Use este método para configurar o pipeline de requisição.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    // Configurações para ambientes de produção
                    // Exemplo: app.UseExceptionHandler("/Home/Error");
                }

                // Configurações adicionais do pipeline podem ser adicionadas aqui

                app.UseRouting();

                app.UseEndpoints(endpoints =>
                {
                    // Configuração de endpoints (rotas) para a aplicação
                    // Exemplo: endpoints.MapControllerRoute(...)
                });
            }
        }
}
