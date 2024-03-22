using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class Settings
    {
        [Key]
        [Required]
        [ForeignKey(nameof(userID))]
        public int userID { get; set; }

        public bool soundEffects { get; set; }

        public bool smsReminder { get; set; }

        public bool motivationalMessages { get; set; }

        public bool practiceReminder { get; set; }

        public bool smartScheduling { get; set; }
    }
}
