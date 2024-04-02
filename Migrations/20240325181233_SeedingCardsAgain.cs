using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCardsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 347);

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 175,
                column: "Content",
                value: "Listen to upbeat music and dance.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 176,
                column: "Content",
                value: "Engage in a thrilling activity like rollerblading or rock climbing.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 177,
                column: "Content",
                value: "Share your excitement with friends or loved ones.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 178,
                column: "Content",
                value: "Watch an exciting movie or read an engaging book.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 179,
                column: "Content",
                value: "Try a new hobby or learn something new.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 180,
                column: "Content",
                value: "Exercise or go for a run to release energy.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 181,
                column: "Content",
                value: "Attend a live event or concert.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 182,
                column: "Content",
                value: "Set goals and make plans for the future.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 183,
                column: "Content",
                value: "Express gratitude for the things that bring you excitement.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 184,
                column: "Content",
                value: "Enjoy the moment: Embrace the thrill.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 185,
                column: "Content",
                value: "Dance it out: Move to the rhythm.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 186,
                column: "Content",
                value: "Visualize success: See your dreams realized.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 187,
                columns: new[] { "Content", "cardCreditsValue", "moodID" },
                values: new object[] { "Spend time with loved ones.", 30, 1 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 188,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice gratitude by listing things you're thankful for.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 189,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that bring you joy, such as painting or cooking.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 190,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Exercise or go for a walk in nature.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 191,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Watch a comedy show or funny movie.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 192,
                column: "Content",
                value: "Help someone else or perform acts of kindness.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 193,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reflect on past happy memories.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 194,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 195,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on positive affirmations.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 196,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Treat yourself to something you enjoy, like a favourite meal or dessert.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 197,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing or meditation for a few minutes.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 198,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to uplifting music or a favourite playlist.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 199,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Read a book or listen to an audiobook.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 200,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a warm bath or shower.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 201,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write down their thoughts and feelings in a journal.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 202,
                column: "Content",
                value: "Spend time with a pet, if available.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 203,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Plan a future trip or activity to look forward to.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 204,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Declutter and organize a small area of their living space.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 205,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Look at old photos or videos that bring back happy memories.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 206,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Try a new recipe or restaurant.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 207,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Create a vision board of their goals and dreams.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 208,
                columns: new[] { "Content", "moodID", "targetMoodId" },
                values: new object[] { "Spend quality time with loved ones.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 209,
                column: "Content",
                value: "Write a letter or message expressing gratitude to someone special.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 210,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reflect on the positive aspects of your life.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 211,
                column: "Content",
                value: "Perform random acts of kindness for others.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 212,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer for a cause you care about.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 213,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Hug someone you care about.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 214,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-love and self-care activities.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 215,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Keep a gratitude journal and write down things you're thankful for.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 216,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Share compliments with others.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 217,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Count your blessings and focus on what you have rather than what you lack.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 218,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Recall happy memories: Bask in nostalgia.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 219,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-love: Treat yourself kindly.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 220,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Say 'I love you': Share affection openly.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 221,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reflect on blessings: Gratitude brings peace.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 222,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Take a warm bath or shower.", 20, 4, 4 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 223,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing exercises on the home page.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 224,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to calming music or nature sounds.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 225,
                column: "Content",
                value: "Practice yoga or gentle stretching.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 226,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time in nature, such as going for a walk in the park.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 227,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in a hobby like knitting or gardening.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 228,
                column: "Content",
                value: "Read a book or listen to an audiobook.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 229,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 230,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get a massage or practice self-massage techniques.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 231,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Disconnect from screens and technology for a while.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 232,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Unwind: Let go of tension.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 233,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Find a cosy spot: Nestle in comfort.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 234,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to nature: Soothing sounds of tranquillity.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 235,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Drink herbal tea: Sip serenity.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 236,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Enjoy a bubble bath: Soak away stress.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 237,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Meditate: Quiet the mind.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 238,
                columns: new[] { "Content", "cardCreditsValue", "targetMoodId" },
                values: new object[] { "Take deep breaths to calm down.", 15, 5 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 239,
                column: "Content",
                value: "Remove yourself from the situation temporarily.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 240,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in physical activity to release pent-up energy.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 241,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation to centre yourself.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 242,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write down your feelings in a journal.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 243,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Talk to a trusted friend or family member about what's bothering you.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 244,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice empathy and try to see the situation from another perspective.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 245,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Count to ten before responding to avoid saying something you might regret.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 246,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Channel your anger into a constructive activity like cleaning or organizing.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 247,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Seek professional help if anger becomes a recurring issue.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 248,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Find perspective: Consider the bigger picture.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 249,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Use humour: Lighten the mood, watch a comedy.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 250,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice forgiveness: Let go of resentment.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 251,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Journal anger: Write to process emotions.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 252,
                columns: new[] { "Content", "targetMoodId" },
                values: new object[] { "Take breaks throughout the day to relax and recharge.", 6 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 253,
                column: "Content",
                value: "Prioritize tasks and break them down into smaller, manageable steps.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 254,
                column: "Content",
                value: "Practice deep breathing or progressive muscle relaxation.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 255,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Delegate responsibilities: Share the load if possible.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 256,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get organized: maybe make a list of tasks to do.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 257,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in physical activity like going for a walk or practicing yoga.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 258,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Limit caffeine and sugar intake.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 259,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get plenty of sleep and establish a regular sleep schedule.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 260,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice time management techniques: try time blocking.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 261,
                column: "Content",
                value: "Talk it out: Share feelings with a friend.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 262,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write it down: Journal to process emotions.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 263,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Set boundaries: Protect your peace.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 264,
                columns: new[] { "Content", "moodID", "targetMoodId" },
                values: new object[] { "Challenge negative thoughts and replace them with positive affirmations.", 3, 7 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 265,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that distract your mind, such as puzzles or games.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 266,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation to stay present.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 267,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Limit exposure to triggers like caffeine or stressful situations.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 268,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Talk to someone you trust about your feelings.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 269,
                column: "Content",
                value: "Create a calming environment with soothing music, aromatherapy or just your bed.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 270,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on what you can control rather than what you can't.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 271,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Exercise to reduce anxiety levels.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 272,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write worries: Release them on paper.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 273,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Ground yourself: 5-4-3-2-1 list 5 things you can see, 4 you can touch, 3 you can hear, 2 you can smell, and 1 you can taste.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 274,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Find calm: Listen to soothing music.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 275,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Stretch and relax: Ease tension physically.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 276,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Distract yourself: Engage in a hobby.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 277,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Use affirmations: Positive self-talk, you are amazing and you are doing so well right now.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 278,
                columns: new[] { "Content", "moodID", "targetMoodId" },
                values: new object[] { "Remove yourself from the source of disgust if possible.", 4, 8 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 279,
                column: "Content",
                value: "Practice deep breathing to calm your physical reactions.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 280,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on positive aspects of the situation or find humour in it.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 281,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in a pleasurable activity to shift your focus.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 282,
                column: "Content",
                value: "Talk to a friend or loved one about how you're feeling.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 283,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice acceptance and acknowledge that feelings of disgust are temporary.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 284,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in self-care activities to nurture yourself.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 285,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Challenge irrational thoughts that may be fuelling your disgust.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 286,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Seek out positive distractions like watching a funny movie or going for a walk.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 287,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice gratitude to shift your perspective.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 288,
                column: "Content",
                value: "Acknowledge feelings: Validate your emotions - they are valid.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 289,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Vent constructively: Express frustrations calmly.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 290,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice empathy: Understand different perspectives.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 291,
                column: "Content",
                value: "Channel disgust: Use it as motivation for change.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 292,
                column: "Content",
                value: "Challenge assumptions: Question underlying beliefs.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 293,
                column: "Content",
                value: "Reflect on triggers: Identify what causes discomfort.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 294,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Reach out to friends or loved ones for support.", 30, 3, 9 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 295,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that bring you joy or comfort, like listening to music or cooking your favourite meal.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 296,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-compassion and avoid self-criticism.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 297,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time with pets, if you have them, as they can provide comfort and companionship.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 298,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get outside and spend time in nature.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 299,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Seek professional help if sadness persists or becomes overwhelming.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 300,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation to help regulate emotions.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 301,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write down your feelings in a journal.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 302,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that give you a sense of accomplishment, like completing a small task or hobby.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 303,
                column: "Content",
                value: "Connect with others who may be experiencing similar feelings to feel less alone.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 304,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Try something new or engage in a hobby you enjoy.", 10, 4, 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 305,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reach out to friends or family for social interaction.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 306,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Plan an outing or activity to break up the monotony.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 307,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Watch a movie or TV show you've been wanting to see.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 308,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a walk or explore a new area of your neighbourhood.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 309,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Read a book or listen to an audiobook.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 310,
                column: "Content",
                value: "Volunteer for a cause you care about to add purpose to your day.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 311,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Learn something new through online courses or tutorials.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 312,
                column: "Content",
                value: "Get creative by drawing, painting, or crafting.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 313,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reflect on your goals and make plans to work towards them.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 314,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Take a short nap if possible.", 15, 1, 11 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 315,
                column: "Content",
                value: "Drink a glass of cold water or splash cold water on your face to wake up.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 316,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get up and move around to increase blood flow and alertness.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 317,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Open windows or turn on bright lights to increase exposure to light.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 318,
                column: "Content",
                value: "Have a small snack with protein to boost energy levels.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 319,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to upbeat music or engage in an activity that stimulates your mind.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 320,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing exercises to increase oxygen flow.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 321,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a brisk walk outside to get fresh air and wake up your body.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 322,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Avoid caffeine late in the day to prevent disrupting your sleep schedule.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 323,
                column: "Content",
                value: "Splash cold water: Invigorate your senses.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 324,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Stretch: Increase blood flow.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 325,
                column: "Content",
                value: "Change environment: Move to a different room.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 326,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Reach out to friends or family members for a chat or video call.", 30, 3, 12 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 327,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Join a club or group with similar interests to meet new people.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 328,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer for a cause you care about to connect with others and make a difference.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 329,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities you enjoy on your own, such as reading, cooking, or watching a movie.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 330,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time with pets, as they can provide companionship and comfort.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 331,
                column: "Content",
                value: "Connect with old friends or acquaintances through social media or messaging apps.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 332,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Attend social events or gatherings in your community to meet new people.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 333,
                column: "Content",
                value: "Practice self-care activities to nurture yourself and boost your mood.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 334,
                column: "Content",
                value: "Engage in hobbies or activities that bring you fulfilment and joy.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 335,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer your time to help others, which can provide a sense of purpose and connection.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 336,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write in a journal to express your thoughts and feelings, helping you process emotions.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 337,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on building a strong relationship with yourself, practicing self-love and self-acceptance.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 338,
                columns: new[] { "Content", "cardCreditsValue", "targetMoodId" },
                values: new object[] { "Reach out: Talk to someone you trust.", 30, 13 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 339,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-care: Nurture your well-being (healthy eating, exercise, sleep hygiene).", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 340,
                column: "Content",
                value: "Create a routine: Establish structure in your day.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 341,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Set small goals: Celebrate every achievement, no matter how small.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 342,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Stay active: Engage in physical activity, even a short walk can improve mood.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 343,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a nap (if possible): Aim for 20-30 minutes to avoid sleep inertia.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 344,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Limit isolation: Connect with loved ones, even virtually.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 345,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Express yourself: Write in a journal, talk to a therapist, or express yourself creatively.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 346,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on the present: Mindfulness exercises can help manage overwhelming thoughts.", 20 });

            migrationBuilder.InsertData(
                table: "TarotCards",
                columns: new[] { "cardID", "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { 174, "Plan a fun outing or adventure.", 10, 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 174);

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 175,
                column: "Content",
                value: "Plan a fun outing or adventure.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 176,
                column: "Content",
                value: "Listen to upbeat music and dance.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 177,
                column: "Content",
                value: "Engage in a thrilling activity like rollerblading or rock climbing.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 178,
                column: "Content",
                value: "Share your excitement with friends or loved ones.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 179,
                column: "Content",
                value: "Watch an exciting movie or read an engaging book.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 180,
                column: "Content",
                value: "Try a new hobby or learn something new.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 181,
                column: "Content",
                value: "Exercise or go for a run to release energy.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 182,
                column: "Content",
                value: "Attend a live event or concert.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 183,
                column: "Content",
                value: "Set goals and make plans for the future.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 184,
                column: "Content",
                value: "Express gratitude for the things that bring you excitement.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 185,
                column: "Content",
                value: "Enjoy the moment: Embrace the thrill.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 186,
                column: "Content",
                value: "Dance it out: Move to the rhythm.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 187,
                columns: new[] { "Content", "cardCreditsValue", "moodID" },
                values: new object[] { "Visualize success: See your dreams realized.", 10, 2 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 188,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time with loved ones.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 189,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice gratitude by listing things you're thankful for.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 190,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that bring you joy, such as painting or cooking.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 191,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Exercise or go for a walk in nature.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 192,
                column: "Content",
                value: "Watch a comedy show or funny movie.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 193,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Help someone else or perform acts of kindness.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 194,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reflect on past happy memories.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 195,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 196,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on positive affirmations.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 197,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Treat yourself to something you enjoy, like a favourite meal or dessert.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 198,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing or meditation for a few minutes.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 199,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to uplifting music or a favourite playlist.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 200,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Read a book or listen to an audiobook.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 201,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a warm bath or shower.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 202,
                column: "Content",
                value: "Write down their thoughts and feelings in a journal.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 203,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time with a pet, if available.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 204,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Plan a future trip or activity to look forward to.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 205,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Declutter and organize a small area of their living space.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 206,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Look at old photos or videos that bring back happy memories.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 207,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Try a new recipe or restaurant.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 208,
                columns: new[] { "Content", "moodID", "targetMoodId" },
                values: new object[] { "Create a vision board of their goals and dreams.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 209,
                column: "Content",
                value: "Spend quality time with loved ones.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 210,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write a letter or message expressing gratitude to someone special.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 211,
                column: "Content",
                value: "Reflect on the positive aspects of your life.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 212,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Perform random acts of kindness for others.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 213,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer for a cause you care about.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 214,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Hug someone you care about.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 215,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-love and self-care activities.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 216,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Keep a gratitude journal and write down things you're thankful for.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 217,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Share compliments with others.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 218,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Count your blessings and focus on what you have rather than what you lack.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 219,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Recall happy memories: Bask in nostalgia.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 220,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-love: Treat yourself kindly.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 221,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Say 'I love you': Share affection openly.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 222,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Reflect on blessings: Gratitude brings peace.", 15, 3, 3 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 223,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a warm bath or shower.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 224,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing exercises on the home page.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 225,
                column: "Content",
                value: "Listen to calming music or nature sounds.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 226,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice yoga or gentle stretching.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 227,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time in nature, such as going for a walk in the park.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 228,
                column: "Content",
                value: "Engage in a hobby like knitting or gardening.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 229,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Read a book or listen to an audiobook.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 230,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 231,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get a massage or practice self-massage techniques.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 232,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Disconnect from screens and technology for a while.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 233,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Unwind: Let go of tension.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 234,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Find a cosy spot: Nestle in comfort.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 235,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to nature: Soothing sounds of tranquillity.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 236,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Drink herbal tea: Sip serenity.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 237,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Enjoy a bubble bath: Soak away stress.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 238,
                columns: new[] { "Content", "cardCreditsValue", "targetMoodId" },
                values: new object[] { "Meditate: Quiet the mind.", 20, 4 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 239,
                column: "Content",
                value: "Take deep breaths to calm down.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 240,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Remove yourself from the situation temporarily.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 241,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in physical activity to release pent-up energy.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 242,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation to centre yourself.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 243,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write down your feelings in a journal.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 244,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Talk to a trusted friend or family member about what's bothering you.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 245,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice empathy and try to see the situation from another perspective.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 246,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Count to ten before responding to avoid saying something you might regret.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 247,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Channel your anger into a constructive activity like cleaning or organizing.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 248,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Seek professional help if anger becomes a recurring issue.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 249,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Find perspective: Consider the bigger picture.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 250,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Use humour: Lighten the mood, watch a comedy.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 251,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice forgiveness: Let go of resentment.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 252,
                columns: new[] { "Content", "targetMoodId" },
                values: new object[] { "Journal anger: Write to process emotions.", 5 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 253,
                column: "Content",
                value: "Take breaks throughout the day to relax and recharge.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 254,
                column: "Content",
                value: "Prioritize tasks and break them down into smaller, manageable steps.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 255,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing or progressive muscle relaxation.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 256,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Delegate responsibilities: Share the load if possible.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 257,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get organized: maybe make a list of tasks to do.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 258,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in physical activity like going for a walk or practicing yoga.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 259,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Limit caffeine and sugar intake.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 260,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get plenty of sleep and establish a regular sleep schedule.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 261,
                column: "Content",
                value: "Practice time management techniques: try time blocking.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 262,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Talk it out: Share feelings with a friend.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 263,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write it down: Journal to process emotions.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 264,
                columns: new[] { "Content", "moodID", "targetMoodId" },
                values: new object[] { "Set boundaries: Protect your peace.", 4, 6 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 265,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Challenge negative thoughts and replace them with positive affirmations.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 266,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that distract your mind, such as puzzles or games.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 267,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation to stay present.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 268,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Limit exposure to triggers like caffeine or stressful situations.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 269,
                column: "Content",
                value: "Talk to someone you trust about your feelings.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 270,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Create a calming environment with soothing music, aromatherapy or just your bed.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 271,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on what you can control rather than what you can't.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 272,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Exercise to reduce anxiety levels.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 273,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write worries: Release them on paper.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 274,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Ground yourself: 5-4-3-2-1 list 5 things you can see, 4 you can touch, 3 you can hear, 2 you can smell, and 1 you can taste.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 275,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Find calm: Listen to soothing music.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 276,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Stretch and relax: Ease tension physically.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 277,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Distract yourself: Engage in a hobby.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 278,
                columns: new[] { "Content", "moodID", "targetMoodId" },
                values: new object[] { "Use affirmations: Positive self-talk, you are amazing and you are doing so well right now.", 3, 7 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 279,
                column: "Content",
                value: "Remove yourself from the source of disgust if possible.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 280,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing to calm your physical reactions.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 281,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Focus on positive aspects of the situation or find humour in it.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 282,
                column: "Content",
                value: "Engage in a pleasurable activity to shift your focus.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 283,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Talk to a friend or loved one about how you're feeling.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 284,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice acceptance and acknowledge that feelings of disgust are temporary.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 285,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in self-care activities to nurture yourself.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 286,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Challenge irrational thoughts that may be fuelling your disgust.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 287,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Seek out positive distractions like watching a funny movie or going for a walk.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 288,
                column: "Content",
                value: "Practice gratitude to shift your perspective.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 289,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Acknowledge feelings: Validate your emotions - they are valid.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 290,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Vent constructively: Express frustrations calmly.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 291,
                column: "Content",
                value: "Practice empathy: Understand different perspectives.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 292,
                column: "Content",
                value: "Channel disgust: Use it as motivation for change.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 293,
                column: "Content",
                value: "Challenge assumptions: Question underlying beliefs.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 294,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Reflect on triggers: Identify what causes discomfort.", 20, 4, 8 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 295,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reach out to friends or loved ones for support.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 296,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities that bring you joy or comfort, like listening to music or cooking your favourite meal.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 297,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice self-compassion and avoid self-criticism.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 298,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Spend time with pets, if you have them, as they can provide comfort and companionship.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 299,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get outside and spend time in nature.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 300,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Seek professional help if sadness persists or becomes overwhelming.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 301,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice mindfulness or meditation to help regulate emotions.", 20 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 302,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write down your feelings in a journal.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 303,
                column: "Content",
                value: "Engage in activities that give you a sense of accomplishment, like completing a small task or hobby.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 304,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Connect with others who may be experiencing similar feelings to feel less alone.", 30, 3, 9 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 305,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Try something new or engage in a hobby you enjoy.", 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 306,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reach out to friends or family for social interaction.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 307,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Plan an outing or activity to break up the monotony.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 308,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Watch a movie or TV show you've been wanting to see.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 309,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a walk or explore a new area of your neighbourhood.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 310,
                column: "Content",
                value: "Read a book or listen to an audiobook.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 311,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer for a cause you care about to add purpose to your day.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 312,
                column: "Content",
                value: "Learn something new through online courses or tutorials.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 313,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get creative by drawing, painting, or crafting.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 314,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Reflect on your goals and make plans to work towards them.", 30, 4, 10 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 315,
                column: "Content",
                value: "Take a short nap if possible.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 316,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Drink a glass of cold water or splash cold water on your face to wake up.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 317,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Get up and move around to increase blood flow and alertness.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 318,
                column: "Content",
                value: "Open windows or turn on bright lights to increase exposure to light.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 319,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Have a small snack with protein to boost energy levels.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 320,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Listen to upbeat music or engage in an activity that stimulates your mind.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 321,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Practice deep breathing exercises to increase oxygen flow.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 322,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a brisk walk outside to get fresh air and wake up your body.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 323,
                column: "Content",
                value: "Avoid caffeine late in the day to prevent disrupting your sleep schedule.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 324,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Splash cold water: Invigorate your senses.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 325,
                column: "Content",
                value: "Stretch: Increase blood flow.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 326,
                columns: new[] { "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { "Change environment: Move to a different room.", 20, 1, 11 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 327,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reach out to friends or family members for a chat or video call.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 328,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Join a club or group with similar interests to meet new people.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 329,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer for a cause you care about to connect with others and make a difference.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 330,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in activities you enjoy on your own, such as reading, cooking, or watching a movie.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 331,
                column: "Content",
                value: "Spend time with pets, as they can provide companionship and comfort.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 332,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Connect with old friends or acquaintances through social media or messaging apps.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 333,
                column: "Content",
                value: "Attend social events or gatherings in your community to meet new people.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 334,
                column: "Content",
                value: "Practice self-care activities to nurture yourself and boost your mood.");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 335,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Engage in hobbies or activities that bring you fulfilment and joy.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 336,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Volunteer your time to help others, which can provide a sense of purpose and connection.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 337,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Write in a journal to express your thoughts and feelings, helping you process emotions.", 15 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 338,
                columns: new[] { "Content", "cardCreditsValue", "targetMoodId" },
                values: new object[] { "Focus on building a strong relationship with yourself, practicing self-love and self-acceptance.", 20, 12 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 339,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Reach out: Talk to someone you trust.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 340,
                column: "Content",
                value: "Practice self-care: Nurture your well-being (healthy eating, exercise, sleep hygiene).");

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 341,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Create a routine: Establish structure in your day.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 342,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Set small goals: Celebrate every achievement, no matter how small.", 30 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 343,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Stay active: Engage in physical activity, even a short walk can improve mood.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 344,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Take a nap (if possible): Aim for 20-30 minutes to avoid sleep inertia.", 60 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 345,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Limit isolation: Connect with loved ones, even virtually.", 45 });

            migrationBuilder.UpdateData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 346,
                columns: new[] { "Content", "cardCreditsValue" },
                values: new object[] { "Express yourself: Write in a journal, talk to a therapist, or express yourself creatively.", 30 });

            migrationBuilder.InsertData(
                table: "TarotCards",
                columns: new[] { "cardID", "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[] { 347, "Focus on the present: Mindfulness exercises can help manage overwhelming thoughts.", 20, 3, 13 });
        }
    }
}
