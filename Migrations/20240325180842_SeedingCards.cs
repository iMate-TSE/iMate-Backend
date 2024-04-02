using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iMate.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TarotCards",
                columns: new[] { "cardID", "Content", "cardCreditsValue", "moodID", "targetMoodId" },
                values: new object[,]
                {
                    { 175, "Plan a fun outing or adventure.", 10, 2, 1 },
                    { 176, "Listen to upbeat music and dance.", 10, 2, 1 },
                    { 177, "Engage in a thrilling activity like rollerblading or rock climbing.", 10, 2, 1 },
                    { 178, "Share your excitement with friends or loved ones.", 10, 2, 1 },
                    { 179, "Watch an exciting movie or read an engaging book.", 10, 2, 1 },
                    { 180, "Try a new hobby or learn something new.", 10, 2, 1 },
                    { 181, "Exercise or go for a run to release energy.", 10, 2, 1 },
                    { 182, "Attend a live event or concert.", 10, 2, 1 },
                    { 183, "Set goals and make plans for the future.", 10, 2, 1 },
                    { 184, "Express gratitude for the things that bring you excitement.", 10, 2, 1 },
                    { 185, "Enjoy the moment: Embrace the thrill.", 10, 2, 1 },
                    { 186, "Dance it out: Move to the rhythm.", 10, 2, 1 },
                    { 187, "Visualize success: See your dreams realized.", 10, 2, 1 },
                    { 188, "Spend time with loved ones.", 30, 1, 1 },
                    { 189, "Practice gratitude by listing things you're thankful for.", 15, 1, 1 },
                    { 190, "Engage in activities that bring you joy, such as painting or cooking.", 60, 1, 1 },
                    { 191, "Exercise or go for a walk in nature.", 45, 1, 1 },
                    { 192, "Watch a comedy show or funny movie.", 30, 1, 1 },
                    { 193, "Help someone else or perform acts of kindness.", 30, 1, 1 },
                    { 194, "Reflect on past happy memories.", 15, 1, 1 },
                    { 195, "Practice mindfulness or meditation.", 20, 1, 1 },
                    { 196, "Focus on positive affirmations.", 15, 1, 1 },
                    { 197, "Treat yourself to something you enjoy, like a favourite meal or dessert.", 30, 1, 1 },
                    { 198, "Practice deep breathing or meditation for a few minutes.", 10, 1, 1 },
                    { 199, "Listen to uplifting music or a favourite playlist.", 30, 1, 1 },
                    { 200, "Read a book or listen to an audiobook.", 60, 1, 1 },
                    { 201, "Take a warm bath or shower.", 20, 1, 1 },
                    { 202, "Write down their thoughts and feelings in a journal.", 15, 1, 1 },
                    { 203, "Spend time with a pet, if available.", 15, 1, 1 },
                    { 204, "Plan a future trip or activity to look forward to.", 60, 1, 1 },
                    { 205, "Declutter and organize a small area of their living space.", 30, 1, 1 },
                    { 206, "Look at old photos or videos that bring back happy memories.", 20, 1, 1 },
                    { 207, "Try a new recipe or restaurant.", 60, 1, 1 },
                    { 208, "Create a vision board of their goals and dreams.", 30, 1, 1 },
                    { 209, "Spend quality time with loved ones.", 30, 3, 3 },
                    { 210, "Write a letter or message expressing gratitude to someone special.", 30, 3, 3 },
                    { 211, "Reflect on the positive aspects of your life.", 15, 3, 3 },
                    { 212, "Perform random acts of kindness for others.", 15, 3, 3 },
                    { 213, "Volunteer for a cause you care about.", 60, 3, 3 },
                    { 214, "Hug someone you care about.", 10, 3, 3 },
                    { 215, "Practice self-love and self-care activities.", 45, 3, 3 },
                    { 216, "Keep a gratitude journal and write down things you're thankful for.", 15, 3, 3 },
                    { 217, "Share compliments with others.", 10, 3, 3 },
                    { 218, "Count your blessings and focus on what you have rather than what you lack.", 15, 3, 3 },
                    { 219, "Recall happy memories: Bask in nostalgia.", 20, 3, 3 },
                    { 220, "Practice self-love: Treat yourself kindly.", 30, 3, 3 },
                    { 221, "Say 'I love you': Share affection openly.", 10, 3, 3 },
                    { 222, "Reflect on blessings: Gratitude brings peace.", 15, 3, 3 },
                    { 223, "Take a warm bath or shower.", 20, 4, 4 },
                    { 224, "Practice deep breathing exercises on the home page.", 15, 4, 4 },
                    { 225, "Listen to calming music or nature sounds.", 30, 4, 4 },
                    { 226, "Practice yoga or gentle stretching.", 30, 4, 4 },
                    { 227, "Spend time in nature, such as going for a walk in the park.", 45, 4, 4 },
                    { 228, "Engage in a hobby like knitting or gardening.", 60, 4, 4 },
                    { 229, "Read a book or listen to an audiobook.", 60, 4, 4 },
                    { 230, "Practice mindfulness or meditation.", 20, 4, 4 },
                    { 231, "Get a massage or practice self-massage techniques.", 30, 4, 4 },
                    { 232, "Disconnect from screens and technology for a while.", 60, 4, 4 },
                    { 233, "Unwind: Let go of tension.", 15, 4, 4 },
                    { 234, "Find a cosy spot: Nestle in comfort.", 10, 4, 4 },
                    { 235, "Listen to nature: Soothing sounds of tranquillity.", 30, 4, 4 },
                    { 236, "Drink herbal tea: Sip serenity.", 15, 4, 4 },
                    { 237, "Enjoy a bubble bath: Soak away stress.", 30, 4, 4 },
                    { 238, "Meditate: Quiet the mind.", 20, 4, 4 },
                    { 239, "Take deep breaths to calm down.", 15, 4, 5 },
                    { 240, "Remove yourself from the situation temporarily.", 15, 4, 5 },
                    { 241, "Engage in physical activity to release pent-up energy.", 45, 4, 5 },
                    { 242, "Practice mindfulness or meditation to centre yourself.", 20, 4, 5 },
                    { 243, "Write down your feelings in a journal.", 15, 4, 5 },
                    { 244, "Talk to a trusted friend or family member about what's bothering you.", 30, 4, 5 },
                    { 245, "Practice empathy and try to see the situation from another perspective.", 20, 4, 5 },
                    { 246, "Count to ten before responding to avoid saying something you might regret.", 10, 4, 5 },
                    { 247, "Channel your anger into a constructive activity like cleaning or organizing.", 30, 4, 5 },
                    { 248, "Seek professional help if anger becomes a recurring issue.", 60, 4, 5 },
                    { 249, "Find perspective: Consider the bigger picture.", 20, 4, 5 },
                    { 250, "Use humour: Lighten the mood, watch a comedy.", 30, 4, 5 },
                    { 251, "Practice forgiveness: Let go of resentment.", 20, 4, 5 },
                    { 252, "Journal anger: Write to process emotions.", 15, 4, 5 },
                    { 253, "Take breaks throughout the day to relax and recharge.", 15, 4, 6 },
                    { 254, "Prioritize tasks and break them down into smaller, manageable steps.", 15, 4, 6 },
                    { 255, "Practice deep breathing or progressive muscle relaxation.", 15, 4, 6 },
                    { 256, "Delegate responsibilities: Share the load if possible.", 30, 4, 6 },
                    { 257, "Get organized: maybe make a list of tasks to do.", 20, 4, 6 },
                    { 258, "Engage in physical activity like going for a walk or practicing yoga.", 45, 4, 6 },
                    { 259, "Limit caffeine and sugar intake.", 15, 4, 6 },
                    { 260, "Get plenty of sleep and establish a regular sleep schedule.", 60, 4, 6 },
                    { 261, "Practice time management techniques: try time blocking.", 30, 4, 6 },
                    { 262, "Talk it out: Share feelings with a friend.", 30, 4, 6 },
                    { 263, "Write it down: Journal to process emotions.", 15, 4, 6 },
                    { 264, "Set boundaries: Protect your peace.", 20, 4, 6 },
                    { 265, "Challenge negative thoughts and replace them with positive affirmations.", 20, 3, 7 },
                    { 266, "Engage in activities that distract your mind, such as puzzles or games.", 30, 3, 7 },
                    { 267, "Practice mindfulness or meditation to stay present.", 20, 3, 7 },
                    { 268, "Limit exposure to triggers like caffeine or stressful situations.", 15, 3, 7 },
                    { 269, "Talk to someone you trust about your feelings.", 30, 3, 7 },
                    { 270, "Create a calming environment with soothing music, aromatherapy or just your bed.", 30, 3, 7 },
                    { 271, "Focus on what you can control rather than what you can't.", 20, 3, 7 },
                    { 272, "Exercise to reduce anxiety levels.", 45, 3, 7 },
                    { 273, "Write worries: Release them on paper.", 15, 3, 7 },
                    { 274, "Ground yourself: 5-4-3-2-1 list 5 things you can see, 4 you can touch, 3 you can hear, 2 you can smell, and 1 you can taste.", 20, 3, 7 },
                    { 275, "Find calm: Listen to soothing music.", 30, 3, 7 },
                    { 276, "Stretch and relax: Ease tension physically.", 20, 3, 7 },
                    { 277, "Distract yourself: Engage in a hobby.", 60, 3, 7 },
                    { 278, "Use affirmations: Positive self-talk, you are amazing and you are doing so well right now.", 15, 3, 7 },
                    { 279, "Remove yourself from the source of disgust if possible.", 15, 4, 8 },
                    { 280, "Practice deep breathing to calm your physical reactions.", 15, 4, 8 },
                    { 281, "Focus on positive aspects of the situation or find humour in it.", 20, 4, 8 },
                    { 282, "Engage in a pleasurable activity to shift your focus.", 30, 4, 8 },
                    { 283, "Talk to a friend or loved one about how you're feeling.", 30, 4, 8 },
                    { 284, "Practice acceptance and acknowledge that feelings of disgust are temporary.", 20, 4, 8 },
                    { 285, "Engage in self-care activities to nurture yourself.", 45, 4, 8 },
                    { 286, "Challenge irrational thoughts that may be fuelling your disgust.", 20, 4, 8 },
                    { 287, "Seek out positive distractions like watching a funny movie or going for a walk.", 30, 4, 8 },
                    { 288, "Practice gratitude to shift your perspective.", 15, 4, 8 },
                    { 289, "Acknowledge feelings: Validate your emotions - they are valid.", 15, 4, 8 },
                    { 290, "Vent constructively: Express frustrations calmly.", 30, 4, 8 },
                    { 291, "Practice empathy: Understand different perspectives.", 20, 4, 8 },
                    { 292, "Channel disgust: Use it as motivation for change.", 20, 4, 8 },
                    { 293, "Challenge assumptions: Question underlying beliefs.", 20, 4, 8 },
                    { 294, "Reflect on triggers: Identify what causes discomfort.", 20, 4, 8 },
                    { 295, "Reach out to friends or loved ones for support.", 30, 3, 9 },
                    { 296, "Engage in activities that bring you joy or comfort, like listening to music or cooking your favourite meal.", 45, 3, 9 },
                    { 297, "Practice self-compassion and avoid self-criticism.", 20, 3, 9 },
                    { 298, "Spend time with pets, if you have them, as they can provide comfort and companionship.", 30, 3, 9 },
                    { 299, "Get outside and spend time in nature.", 45, 3, 9 },
                    { 300, "Seek professional help if sadness persists or becomes overwhelming.", 60, 3, 9 },
                    { 301, "Practice mindfulness or meditation to help regulate emotions.", 20, 3, 9 },
                    { 302, "Write down your feelings in a journal.", 15, 3, 9 },
                    { 303, "Engage in activities that give you a sense of accomplishment, like completing a small task or hobby.", 30, 3, 9 },
                    { 304, "Connect with others who may be experiencing similar feelings to feel less alone.", 30, 3, 9 },
                    { 305, "Try something new or engage in a hobby you enjoy.", 10, 4, 10 },
                    { 306, "Reach out to friends or family for social interaction.", 30, 4, 10 },
                    { 307, "Plan an outing or activity to break up the monotony.", 45, 4, 10 },
                    { 308, "Watch a movie or TV show you've been wanting to see.", 30, 4, 10 },
                    { 309, "Take a walk or explore a new area of your neighbourhood.", 45, 4, 10 },
                    { 310, "Read a book or listen to an audiobook.", 60, 4, 10 },
                    { 311, "Volunteer for a cause you care about to add purpose to your day.", 60, 4, 10 },
                    { 312, "Learn something new through online courses or tutorials.", 45, 4, 10 },
                    { 313, "Get creative by drawing, painting, or crafting.", 45, 4, 10 },
                    { 314, "Reflect on your goals and make plans to work towards them.", 30, 4, 10 },
                    { 315, "Take a short nap if possible.", 15, 1, 11 },
                    { 316, "Drink a glass of cold water or splash cold water on your face to wake up.", 15, 1, 11 },
                    { 317, "Get up and move around to increase blood flow and alertness.", 30, 1, 11 },
                    { 318, "Open windows or turn on bright lights to increase exposure to light.", 15, 1, 11 },
                    { 319, "Have a small snack with protein to boost energy levels.", 15, 1, 11 },
                    { 320, "Listen to upbeat music or engage in an activity that stimulates your mind.", 30, 1, 11 },
                    { 321, "Practice deep breathing exercises to increase oxygen flow.", 15, 1, 11 },
                    { 322, "Take a brisk walk outside to get fresh air and wake up your body.", 45, 1, 11 },
                    { 323, "Avoid caffeine late in the day to prevent disrupting your sleep schedule.", 15, 1, 11 },
                    { 324, "Splash cold water: Invigorate your senses.", 15, 1, 11 },
                    { 325, "Stretch: Increase blood flow.", 20, 1, 11 },
                    { 326, "Change environment: Move to a different room.", 20, 1, 11 },
                    { 327, "Reach out to friends or family members for a chat or video call.", 30, 3, 12 },
                    { 328, "Join a club or group with similar interests to meet new people.", 45, 3, 12 },
                    { 329, "Volunteer for a cause you care about to connect with others and make a difference.", 60, 3, 12 },
                    { 330, "Engage in activities you enjoy on your own, such as reading, cooking, or watching a movie.", 45, 3, 12 },
                    { 331, "Spend time with pets, as they can provide companionship and comfort.", 30, 3, 12 },
                    { 332, "Connect with old friends or acquaintances through social media or messaging apps.", 30, 3, 12 },
                    { 333, "Attend social events or gatherings in your community to meet new people.", 45, 3, 12 },
                    { 334, "Practice self-care activities to nurture yourself and boost your mood.", 45, 3, 12 },
                    { 335, "Engage in hobbies or activities that bring you fulfilment and joy.", 45, 3, 12 },
                    { 336, "Volunteer your time to help others, which can provide a sense of purpose and connection.", 60, 3, 12 },
                    { 337, "Write in a journal to express your thoughts and feelings, helping you process emotions.", 15, 3, 12 },
                    { 338, "Focus on building a strong relationship with yourself, practicing self-love and self-acceptance.", 20, 3, 12 },
                    { 339, "Reach out: Talk to someone you trust.", 30, 3, 13 },
                    { 340, "Practice self-care: Nurture your well-being (healthy eating, exercise, sleep hygiene).", 45, 3, 13 },
                    { 341, "Create a routine: Establish structure in your day.", 45, 3, 13 },
                    { 342, "Set small goals: Celebrate every achievement, no matter how small.", 30, 3, 13 },
                    { 343, "Stay active: Engage in physical activity, even a short walk can improve mood.", 45, 3, 13 },
                    { 344, "Take a nap (if possible): Aim for 20-30 minutes to avoid sleep inertia.", 60, 3, 13 },
                    { 345, "Limit isolation: Connect with loved ones, even virtually.", 45, 3, 13 },
                    { 346, "Express yourself: Write in a journal, talk to a therapist, or express yourself creatively.", 30, 3, 13 },
                    { 347, "Focus on the present: Mindfulness exercises can help manage overwhelming thoughts.", 20, 3, 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "TarotCards",
                keyColumn: "cardID",
                keyValue: 347);
        }
    }
}
