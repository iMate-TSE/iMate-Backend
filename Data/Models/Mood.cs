using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class Mood
    {
        [Key]
        [Required]
        [ForeignKey(nameof(userID))]
        public int userID { get; set; }

        public DateOnly date { get; set; }

        public string mood { get; set; }
    }
}
