IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

string? connectionString = config.GetSection("ConnectionString").Value;

ServiceCollection services = new();

services.AddDbContext<ApplicationDbContext>(options=> options.UseSqlServer(connectionString));

IServiceProvider serviceProvider = services.BuildServiceProvider();

using (ApplicationDbContext? context = serviceProvider.GetService<ApplicationDbContext>())
{
    foreach (Wallet wallet in context!.Wallets)
    {
        Console.WriteLine(wallet.ToString());
    }
}
