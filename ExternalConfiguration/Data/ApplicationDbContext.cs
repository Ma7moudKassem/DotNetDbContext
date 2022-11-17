namespace ExternalConfiguration;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Wallet> Wallets { get; set; }
}
