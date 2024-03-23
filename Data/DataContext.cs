using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // define all the tables
        public DbSet<FormQuestions> FormQuestions { get; set; }

        public DbSet<MoodEntry> MoodEntry { get; set; }

        public DbSet<PadRanges> PadRanges { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<SlidersQuestions> SlidersQuestions { get; set; }

        public DbSet<TarotCards> TarotCards { get; set; }

        public DbSet<User> User { get; set; }

        // seed on creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

    }
}
