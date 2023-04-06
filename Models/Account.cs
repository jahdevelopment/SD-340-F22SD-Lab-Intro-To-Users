using System.Reflection.Metadata;

namespace SD_340_F22SD_Lab_Intro_To_Users.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }  
    }
}
