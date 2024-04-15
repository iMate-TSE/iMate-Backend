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

        public string? Category { get; set; }

        public static int id = 0;
        
        public FormQuestions(string Question, string Category)
        {
            id++;
            this.formQuestionID = id;
            this.Question = Question;
            this.Category = Category;
        }
    }
}
