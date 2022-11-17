IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

string? connectionString = config.GetSection("ConnectionString").Value;

DbContextOptionsBuilder optionBuilder = new DbContextOptionsBuilder();

optionBuilder.UseSqlServer(connectionString);

DbContextOptions options = optionBuilder.Options; 

using (ApplicationDbContext context = new ApplicationDbContext(options))
{
    foreach (Wallet wallet in context.Wallets)
    {
        Console.WriteLine(wallet.ToString());
    }
}