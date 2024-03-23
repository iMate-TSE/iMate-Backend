using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;


/*

            { (1.0f, 1.0f, 1.0f), "Excited" },
            { (1.0f, 0.5f, 1.0f), "Happy" },
            { (0.9f, 0.2f, 0.8f), "Loved/ Grateful" },
            { (0.9f, 0.2f, 0.2f), "Relaxed" },
            { (0.1f, 0.9f, 1.0f), "Angry" },
            { (0.2f, 0.9f, 0.7f), "Stressed" },
            { (0.1f, 0.6f, 0.4f), "Anxious" },
            { (0.0f, 0.7f, 0.45f), "Disgust" },
            { (0.1f, 0.1f, 0.1f), "Sad" },
            { (0.2f, 0.1f, 0.3f), "Bored" },
            { (0.4f, 0.4f, 0.4f), "Sleepy" },
            { (0.1f, 0.3f, 0.0f), "Lonely" },
            { (0.0f, 0.0f, 0.0f), "Depressed" },

*/

namespace iMate.API.Data
{
    public partial class DataContext
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PadRanges>()
                .HasData(
                    //                 mood      P     A    D
                    new PadRanges(1, "Excited", 1.0f, 1.0f, 1.0f),
                    new PadRanges(2, "Happy", 1.0f, 0.5f, 1.0f),
                    new PadRanges(3, "Loved/ Grateful", 0.9f, 0.2f, 0.8f),
                    new PadRanges(4, "Relaxed", 0.9f, 0.2f, 0.2f),
                    new PadRanges(5, "Angry", 0.1f, 0.9f, 1.0f),
                    new PadRanges(6, "Stressed", 0.2f, 0.9f, 0.7f),
                    new PadRanges(7, "Anxious", 0.1f, 0.6f, 0.4f),
                    new PadRanges(8, "Disgust", 0.0f, 0.7f, 0.45f),
                    new PadRanges(9, "Sad", 0.1f, 0.1f, 0.1f),
                    new PadRanges(10, "Bored", 0.2f, 0.1f, 0.3f),
                    new PadRanges(11, "Sleepy", 0.4f, 0.4f, 0.4f),
                    new PadRanges(12, "Lonely", 0.1f, 0.3f, 0.0f),
                    new PadRanges(13, "Depressed", 0.0f, 0.0f, 0.0f)
                );
        }
    }
}
