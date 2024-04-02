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

        private string? encryptedPassword { get; set; }

        public int? age { get; set; }

        public string? gender { get; set; }

        public int credits { get; set; }

        public int streak { get; set; }

        [ForeignKey("settingsID")]
        public int? settingsID { get; set; }

        public Settings Settings { get; set; } = null!;
    }
}
