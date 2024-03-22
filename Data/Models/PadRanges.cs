using System.ComponentModel.DataAnnotations;

namespace iMate.API.Data.Models
{
    public class PadRanges
    {
        [Key]
        public int moodID { get; set; }

        public string mood { get; set; } = String.Empty;

        public float valuePleasure { get; set; }

        public float valueArousal { get; set; }

        public float valueDominance { get; set; }
    }
}
