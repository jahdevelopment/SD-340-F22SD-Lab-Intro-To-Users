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


    }

    public DbSet<Account>? Accounts { get; set; }
}
