using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
    // A DbContext represents a session with the database
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    /*
    public DbSet<User> Users
        {
            get { return Set<User>(); }
        }

    */
    public DbSet<User> Users => Set<User>();
    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<Category> Categories => Set<Category>();

    // We aren't doing anything in this override it's in case we want to alter
    // This is where we can configure things like table names, keys, relationships
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}