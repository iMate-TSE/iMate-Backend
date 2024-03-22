using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class TarotCards
    {
        [Key]
        [Required]
        public int cardID { get; set; }

        public float answerValueValance { get; set; }

        public float answerValueArousal { get; set; }

        public float answerValueDominance { get; set; }

        public int cardCreditsValue { get; set; }

        [ForeignKey(nameof(updateID))]
        public int updateID { get; set; }
    }
}
