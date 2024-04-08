using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class User
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userID { get; set; }

        [Required, MaxLength(100)]
        public string? userName { get; set; }

        public string? avatarPath { get; set; }

        public string? encryptedPassword { get; set; }

        public int? age { get; set; }

        public string? gender { get; set; }

        public int credits { get; set; }

        public int streak { get; set; }

        [ForeignKey("settingsID")]
        public int? settingsID { get; set; }

        public Settings Settings { get; set; } = null!;

        public User() { }
        public User(string userName, string encryptedPassword) 
        {
            this.userName = userName;
            this.avatarPath = null;
            this.encryptedPassword = encryptedPassword;
            this.age = null;
            this.gender = null;
            this.credits = 0;
            this.streak = 0;
            this.settingsID = null;

        }


    }
}
