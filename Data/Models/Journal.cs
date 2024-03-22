using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class Journal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(userID))]
        public int userID { get; set; }

        public DateOnly date { get; set; }

        public string currentMood { get; set; }

        public string previousMood { get; set; }

        public string timeScale { get; set; }
    }
}
