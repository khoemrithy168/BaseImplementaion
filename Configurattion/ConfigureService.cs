using System.Text;
using hrm_api.Configurattion;
using hrm_api.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using ServiceLayer;

namespace hrm_api.Configuration;

public class ConfigureService
{
    public static class Configuration
    {
        public static void ConfigureDatabase(IServiceCollection services)
        {
            var appConfig = new AppConfigService().GetAppConfig();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                appConfig.ConnectionStrings,
                o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)).UseLazyLoadingProxies());
            // services.AddDbContext<AppRedDbContext>(options => options.UseSqlServer(
            //     appConfig.RedsConnectionStrings,
            //     o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
            // ));

            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Logger(lc => lc
                .Filter.ByExcluding(evt =>
                {
                    // Exclude the specific log message containing the DbCommand
                    var message = evt.RenderMessage();
                    return message.Contains("Executed DbCommand");
                })
                .WriteTo.Console()
                .WriteTo.File("C:\\Logs\\NCP-API\\log-.log",
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 7,
                    shared: true,
                    flushToDiskInterval: TimeSpan.FromSeconds(1)
                )
            )

            .CreateLogger();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddSerilog(dispose: true);
            });
        }
        public static void ConfigureServices( IServiceCollection services)
        {
            // services.AddScoped<NumberRangeService>();
            // services.AddScoped<IRingpullService, RingpullService>();
            // services.AddScoped<IRewardItemService, RewardItemService>();
            // services.AddScoped<IBrandService, BrandService>();
            // services.AddScoped<IItemSKUService, ItemSKUService>();
            // services.AddScoped<IProductTypeService, ProductTypeService>();
            // services.AddScoped<IGameService, GameService>();
        }

        public static void ConfigureAuthentication(IServiceCollection services)
        {
            var appConfig = new AppConfigService().GetAppConfig();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(appConfig.SignatureKey)),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnChallenge = async (context) =>
                        {
                            context.HandleResponse();
                            context.Response.StatusCode = 401;
                            await context.Response.WriteAsJsonAsync(new ServiceResponse<string>
                            {
                                Code = 401,
                                Status = "INVALID_TOKEN",
                                Message = "Invalid access token key"
                            }).ConfigureAwait(true);
                        }
                    };
                });
        }
    }
}