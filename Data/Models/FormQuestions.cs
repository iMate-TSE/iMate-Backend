using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class FormQuestions
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int formQuestionID { get; set; }

        public string? Question { get; set; }

        public ICollection<string> multipleChoice { get; set; } = new List<string>();

        public bool isHappy { get; set; }
    }
}
