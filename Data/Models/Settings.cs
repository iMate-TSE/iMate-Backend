using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class Settings
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool soundEffects { get; set; }

        public bool reducedMotion { get; set; }

        public bool motivationalMessages { get; set; }

        public bool practiceReminder { get; set; }

        public bool smartScheduling { get; set; }

        public string? reminderTime { get; set; }

        // navigation reference
        public User? user { get; set; }
    }
}
