using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class SlidersQuestions
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int silderQuestionID { get; set; }

        public string? Question { get; set; }

        public string? sliderOptionOne { get; set; }

        public string? sliderOptionTwo { get; set; }

        public bool isHappy { get; set;}
    }
}
