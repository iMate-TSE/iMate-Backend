using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace iMate.API.Data.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(cardID))]
        public int cardID { get; set; }

        public string tasks { get; set; }
    }
}
