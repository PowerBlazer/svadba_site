using Microsoft.EntityFrameworkCore;
using Action = server.Models.Action;

namespace server;

public class DbContext: Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Action> Actions => Set<Action>();
    
    public DbContext(DbContextOptions<DbContext> dbContextOptions): base(dbContextOptions)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
}