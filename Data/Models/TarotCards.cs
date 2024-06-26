﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iMate.API.Data.Models
{
    public class TarotCards
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cardID { get; set; } = 0;

        public int cardCreditsValue { get; set; }

        public int targetMoodId { get; set; }

        public PadRanges targetMood { get; set; } = null!;

        public int moodID { get; set; }

        public PadRanges mood { get; set; } = null!;

        // Fact or Task or Other resource
        public string? Content { get; set; }

        public static int id = 0;
        
        public TarotCards(int cardCreditsValue, int targetMoodId, int moodID, string Content)
        {
            id++;
            this.cardID = id;
            this.cardCreditsValue = cardCreditsValue;
            this.targetMoodId = targetMoodId;
            this.moodID = moodID;
            this.Content = Content;
        }
    }
}
