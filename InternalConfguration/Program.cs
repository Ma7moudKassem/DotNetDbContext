using (var context = new ApplicationDbContext())
{
    foreach (Wallet wallet in context.Wallets)
    {
        Console.WriteLine(wallet);
    }
}
