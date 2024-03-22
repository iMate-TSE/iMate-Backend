using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class SlidersQuestions
    {
        [Key]
        [Required]
        public int silderQuestionID { get; set; }

        public string sliderQuestions { get; set; }

        public string sliderOption1 { get; set; }

        public string sliderOption2 { get; set; }

        public bool isHappy { get; set;}
    }
}
