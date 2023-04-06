namespace SD_340_F22SD_Lab_Intro_To_Users.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public HashSet<Account> Accounts { get; set; } = new HashSet<Account>();
    }
}
