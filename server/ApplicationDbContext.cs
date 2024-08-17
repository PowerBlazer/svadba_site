using Microsoft.EntityFrameworkCore;
using Action = server.Models.Action;

namespace server;

public sealed class ApplicationDbContext: DbContext
{
    public DbSet<Action> Actions => Set<Action>();
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions): base(dbContextOptions)
    {
        Database.EnsureCreated();
        
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
}