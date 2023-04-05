using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SD_340_F22SD_Lab_Intro_To_Users.Areas.Identity.Data;

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
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
