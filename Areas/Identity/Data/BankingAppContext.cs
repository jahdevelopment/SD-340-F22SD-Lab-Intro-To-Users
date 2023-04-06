using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SD_340_F22SD_Lab_Intro_To_Users.Areas.Identity.Data;
using SD_340_F22SD_Lab_Intro_To_Users.Models;

namespace SD_340_F22SD_Lab_Intro_To_Users.Data;

public class BankingAppContext : IdentityDbContext<BankingAppUser>
{
    public BankingAppContext(DbContextOptions<BankingAppContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>()
            .HasMany(u => u.Accounts)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.User.Id);

        builder.Entity<Account>()
            .Property(a => a.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Entity<Account>()
            .Property(a => a.Balance)
            .IsRequired();
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }

    public List<Account> GetAccountsForUser(int userId)
    {
        return Accounts.Where(a => a.UserId == userId).ToList();
    }


    public DbSet<User> Users { get; set; } = default!;

    public DbSet<Account> Accounts { get; set; } = default!;
}
