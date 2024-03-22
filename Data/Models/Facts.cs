using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class Facts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(cardID))]
        public int cardID { get; set; }

        public string facts { get; set; }
    }
}
