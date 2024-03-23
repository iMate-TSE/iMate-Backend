using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class MoodEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, ForeignKey(nameof(userID))]
        public int userID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }

        public PadRanges? mood { get; set; }
    }
}
