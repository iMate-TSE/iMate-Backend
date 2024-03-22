using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class FormQuestions
    {
        [Key]
        [Required]
        public int formQuestionID { get; set; }

        public string formQuestions { get; set; }

        public ICollection<string> multipleChoice { get; set; } = new List<string>();

        public bool isHappy { get; set; }
    }
}
