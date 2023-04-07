using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SD_340_F22SD_Lab_Intro_To_Users.Models;

namespace SD_340_F22SD_Lab_Intro_To_Users.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BankingAppUser class
public class BankingAppUser : IdentityUser
{
    [Required(AllowEmptyStrings = false)]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = default!;

    public virtual HashSet<Account> Accounts { get; set; } = new HashSet<Account>();
}

