using System.ComponentModel.DataAnnotations;

namespace iMate.API.Data.Models
{
    public class PadRanges
    {
        [Key, Required]
        public int moodID { get; set; }

        [Required]
        public string mood { get; set; } = String.Empty;

        [Required]
        public float valuePleasure { get; set; }

        [Required]
        public float valueArousal { get; set; }

        [Required]
        public float valueDominance { get; set; }

        public PadRanges(int moodID, string mood, float valuePleasure, float valueArousal, float valueDominance)
        {
            this.moodID = moodID;
            this.mood = mood;
            this.valuePleasure = valuePleasure;
            this.valueArousal = valueArousal;
            this.valueDominance = valueDominance;
        }
    }
}
