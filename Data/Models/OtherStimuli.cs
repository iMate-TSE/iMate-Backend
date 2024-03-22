using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class OtherStimuli
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(cardID))]
        public int cardID { get; set; }

        public string stimuliPath { get; set; }
    }
}
