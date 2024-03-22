using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class TarotCards
    {
        [Key]
        [Required]
        public int cardID { get; set; }

        public int cardCreditsValue { get; set; }

        public string mood { get; set; }

        public string targetMood { get; set; }

        public int moodID { get; set; }
    }
}
