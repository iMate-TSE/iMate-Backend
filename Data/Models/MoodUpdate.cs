using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class MoodUpdate
    {
        [Key]
        [Required]
        public int updateID { get; set; }

        [Key]
        [Required]
        [ForeignKey(nameof(userID))]
        public int userID { get; set; }

        public float answerValueValance { get; set; }

        public float answerValueArousal { get; set; }

        public float answerValueDominance { get; set; }
    }
}
