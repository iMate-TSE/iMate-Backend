using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class FormQuestions
    {
        [Key]
        [Required]
        [ForeignKey(nameof(updateID))]
        public int updateID { get; set; }

        public string formQuestions { get; set; }
    }
}
