using hrm_api.Configurattion;
using Microsoft.EntityFrameworkCore;


namespace hrm_api.Data;

public class AppDbContext : DbContext
{
    
    
    
    
    
    
    public AppDbContext()
    {

    }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var appConfig = new AppConfigService().GetAppConfig();
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(appConfig.ConnectionStrings);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    }

}