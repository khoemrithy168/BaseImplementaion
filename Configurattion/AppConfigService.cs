using DataLayer;
namespace hrm_api.Configurattion
{

    public class AppConfigService
    {
        private readonly IConfiguration _configuration;

        public AppConfigService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath: AppContext.BaseDirectory).AddJsonFile("appsettings.json");
            _configuration = builder.Build();
        }

        public AppConfig GetAppConfig()
        {
            var app = new AppConfig();
            _configuration.GetSection("AppSettings").Bind(app);
            return app;
        }
    }
}