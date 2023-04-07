using SD_340_F22SD_Lab_Intro_To_Users.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace SD_340_F22SD_Lab_Intro_To_Users.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string Name { get; set; } = default!;

        public double Balance { get; set; } = 0;

        public string UserId { get; set; } = default!;

        public virtual BankingAppUser? User { get; set; }
    }
}
