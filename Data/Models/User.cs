using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        public int userID { get; set; }

        public string userName { get; set; }

        public string avatarPath { get; set; }

        public int age { get; set; }

        public string gender { get; set; }

        public int credits { get; set; }

        public int streak { get; set; }
    }
}
