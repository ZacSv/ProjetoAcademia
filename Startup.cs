using ProjetoSiteAcademia.Services;

namespace ProjetoSiteAcademia
{
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
            services.AddControllersWithViews();
            services.AddTransient<IUserService, UserService>(); //Registrando serviço para criação do usuário
            services.AddTransient<ILoginService, LoginService>();  //Registrando serviço para login do usuário
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
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                // Configuração de endpoints (rotas) para a aplicação
                // Exemplo: endpoints.MapControllerRoute(...)
            });
        }
    }
}