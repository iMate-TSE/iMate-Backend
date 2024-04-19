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

        public int? moodID { get; set; }

        public MoodEntry()
        {
            
        }      
        
        public MoodEntry(int userID, DateTime date, int moodID)
        {
            this.userID = userID;
            this.date = date;
            this.moodID = moodID;
        }
    }
}
