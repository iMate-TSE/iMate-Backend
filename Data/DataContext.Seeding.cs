using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

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
            
            modelBuilder.Entity<FormQuestions>()
                .HasData(
                    new FormQuestions("I have felt terrible alone and isolated", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have thought of hurting myself", "Lonely/Sad/Depressed"),
                    new FormQuestions("Talking to people has felt too much for me", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have felt like crying", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have felt overwhelmed by my problems", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have thought it would be better if I were dead", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have thought I have no friends", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have felt unhappy", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have been irritable when with other people", "Lonely/Sad/Depressed"),
                    new FormQuestions("I have felt humiliated or shamed by other people", "Lonely/Sad/Depressed"),
                    
                    // Anxious/Stressed
                    new FormQuestions("I have felt tense, nervous, or anxious", "Anxious/Stressed"),
                    new FormQuestions("I have been troubled by aches, pains, or other physical problems", "Anxious/Stressed"),
                    new FormQuestions("Tension and anxiety have prevented me from doing important things", "Anxious/Stressed"),
                    new FormQuestions("I have been disturbed by unwanted thoughts and feelings", "Anxious/Stressed"),
                    new FormQuestions("I have felt panic or terror", "Anxious/Stressed"),
                    new FormQuestions("I have had difficulty getting to sleep or staying asleep", "Anxious/Stressed"),
                    new FormQuestions("Unwanted images or memories have been distressing me", "Anxious/Stressed"),
                    new FormQuestions("I have felt criticised by other people", "Anxious/Stressed"),
                    new FormQuestions("I have thought I am to blame for my problems and difficulties", "Anxious/Stressed"),

                    // Loved/Grateful
                    new FormQuestions("I have felt I have someone to turn to for support when needed", "Loved/Grateful"),
                    new FormQuestions("I have felt warmth or affection for someone", "Loved/Grateful"),

                    // Happy/Excited
                    new FormQuestions("I have been happy with the things I have done", "Happy/Excited"),
                    new FormQuestions("I have felt optimistic about my future", "Happy/Excited"),
                    new FormQuestions("I have achieved the things I wanted to do", "Happy/Excited"),

                    // Angry/Disgusted
                    new FormQuestions("I have been physically violent towards others", "Angry/Disgusted"),
                    new FormQuestions("I have threatened or intimidated another person", "Angry/Disgusted"),
                    new FormQuestions("I have hurt myself physically or taken dangerous risks with my health", "Angry/Disgusted"),

                    // Relaxed/Bored/Sleepy
                    new FormQuestions("I have felt ok about myself", "Relaxed/Bored/Sleepy"),
                    new FormQuestions("I have felt totally lacking in energy and enthusiasm", "Relaxed/Bored/Sleepy"),
                    new FormQuestions("My problems have been impossible to put to one side", "Relaxed/Bored/Sleepy"),
                    new FormQuestions("I have felt able to cope when things go wrong", "Relaxed/Bored/Sleepy")
                );

            modelBuilder.Entity<TarotCards>()
                .HasData(
                    new TarotCards(10, 1, 2, "Plan a fun outing or adventure."),
                    new TarotCards(10, 1, 2, "Listen to upbeat music and dance."),
                    new TarotCards(10, 1, 2, "Engage in a thrilling activity like rollerblading or rock climbing."),
                    new TarotCards(10, 1, 2, "Share your excitement with friends or loved ones."),
                    new TarotCards(10, 1, 2, "Watch an exciting movie or read an engaging book."),
                    new TarotCards(10, 1, 2, "Try a new hobby or learn something new."),
                    new TarotCards(10, 1, 2, "Exercise or go for a run to release energy."),
                    new TarotCards(10, 1, 2, "Attend a live event or concert."),
                    new TarotCards(10, 1, 2, "Set goals and make plans for the future."),
                    new TarotCards(10, 1, 2, "Express gratitude for the things that bring you excitement."),
                    new TarotCards(10, 1, 2, "Enjoy the moment: Embrace the thrill."),
                    new TarotCards(10, 1, 2, "Dance it out: Move to the rhythm."),
                    new TarotCards(10, 1, 2, "Visualize success: See your dreams realized."),
                    new TarotCards(30, 1, 1, "Spend time with loved ones."),  
                    new TarotCards(15, 1, 1, "Practice gratitude by listing things you're thankful for."),  // Estimated time: 15 minutes
                    new TarotCards(60, 1, 1, "Engage in activities that bring you joy, such as painting or cooking."),  // Estimated time: 60 minutes
                    new TarotCards(45, 1, 1, "Exercise or go for a walk in nature."),  // Estimated time: 45 minutes
                    new TarotCards(30, 1, 1, "Watch a comedy show or funny movie."),  // Estimated time: 30 minutes
                    new TarotCards(30, 1, 1, "Help someone else or perform acts of kindness."),  // Estimated time: 30 minutes
                    new TarotCards(15, 1, 1, "Reflect on past happy memories."),  // Estimated time: 15 minutes
                    new TarotCards(20, 1, 1, "Practice mindfulness or meditation."),  // Estimated time: 20 minutes
                    new TarotCards(15, 1, 1, "Focus on positive affirmations."),  // Estimated time: 15 minutes
                    new TarotCards(30, 1, 1, "Treat yourself to something you enjoy, like a favourite meal or dessert."),  // Estimated time: 30 minutes
                    new TarotCards(10, 1, 1, "Practice deep breathing or meditation for a few minutes."),  // Estimated time: 10 minutes
                    new TarotCards(30, 1, 1, "Listen to uplifting music or a favourite playlist."),  // Estimated time: 30 minutes
                    new TarotCards(60, 1, 1, "Read a book or listen to an audiobook."),  // Estimated time: 60 minutes (can vary)
                    new TarotCards(20, 1, 1, "Take a warm bath or shower."),  // Estimated time: 20 minutes
                    new TarotCards(15, 1, 1, "Write down their thoughts and feelings in a journal."),  // Estimated time: 15 minutes
                    new TarotCards(15, 1, 1, "Spend time with a pet, if available."),  // Estimated time: 15 minutes (can vary)
                    new TarotCards(60, 1, 1, "Plan a future trip or activity to look forward to."),  // Estimated time: 60 minutes (can vary)
                    new TarotCards(30, 1, 1, "Declutter and organize a small area of their living space."),  // Estimated time: 30 minutes
                    new TarotCards(20, 1, 1, "Look at old photos or videos that bring back happy memories."),  // Estimated time: 20 minutes
                    new TarotCards(60, 1, 1, "Try a new recipe or restaurant."),  // Estimated time: 60 minutes (can vary)
                    new TarotCards(30, 1, 1, "Create a vision board of their goals and dreams."),  // Estimated time: 30 minutes
                    new TarotCards(30, 3, 3, "Spend quality time with loved ones."),
                    new TarotCards(30, 3, 3, "Write a letter or message expressing gratitude to someone special."),
                    new TarotCards(15, 3, 3, "Reflect on the positive aspects of your life."),
                    new TarotCards(15, 3, 3, "Perform random acts of kindness for others."),
                    new TarotCards(60, 3, 3, "Volunteer for a cause you care about."),
                    new TarotCards(10, 3, 3, "Hug someone you care about."),
                    new TarotCards(45, 3, 3, "Practice self-love and self-care activities."),
                    new TarotCards(15, 3, 3, "Keep a gratitude journal and write down things you're thankful for."),
                    new TarotCards(10, 3, 3, "Share compliments with others."),
                    new TarotCards(15, 3, 3, "Count your blessings and focus on what you have rather than what you lack."),
                    new TarotCards(20, 3, 3, "Recall happy memories: Bask in nostalgia."),
                    new TarotCards(30, 3, 3, "Practice self-love: Treat yourself kindly."),
                    new TarotCards(10, 3, 3, "Say 'I love you': Share affection openly."),
                    new TarotCards(15, 3, 3, "Reflect on blessings: Gratitude brings peace."),
                    new TarotCards(20, 4, 4, "Take a warm bath or shower."),
                    new TarotCards(15, 4, 4, "Practice deep breathing exercises on the home page."),  // Assuming deep breathing exercise functionality exists on the home page
                    new TarotCards(30, 4, 4, "Listen to calming music or nature sounds."),
                    new TarotCards(30, 4, 4, "Practice yoga or gentle stretching."),
                    new TarotCards(45, 4, 4, "Spend time in nature, such as going for a walk in the park."),
                    new TarotCards(60, 4, 4, "Engage in a hobby like knitting or gardening."),  // Time can vary depending on the hobby
                    new TarotCards(60, 4, 4, "Read a book or listen to an audiobook."),  // Time can vary depending on the book/audiobook length
                    new TarotCards(20, 4, 4, "Practice mindfulness or meditation."),
                    new TarotCards(30, 4, 4, "Get a massage or practice self-massage techniques."),
                    new TarotCards(60, 4, 4, "Disconnect from screens and technology for a while."),  // Time can vary
                    new TarotCards(15, 4, 4, "Unwind: Let go of tension."),
                    new TarotCards(10, 4, 4, "Find a cosy spot: Nestle in comfort."),
                    new TarotCards(30, 4, 4, "Listen to nature: Soothing sounds of tranquillity."),
                    new TarotCards(15, 4, 4, "Drink herbal tea: Sip serenity."),
                    new TarotCards(30, 4, 4, "Enjoy a bubble bath: Soak away stress."),
                    new TarotCards(20, 4, 4, "Meditate: Quiet the mind."),
                    new TarotCards(15, 5, 4, "Take deep breaths to calm down."),
                    new TarotCards(15, 5, 4, "Remove yourself from the situation temporarily."),
                    new TarotCards(45, 5, 4, "Engage in physical activity to release pent-up energy."),
                    new TarotCards(20, 5, 4, "Practice mindfulness or meditation to centre yourself."),
                    new TarotCards(15, 5, 4, "Write down your feelings in a journal."),
                    new TarotCards(30, 5, 4, "Talk to a trusted friend or family member about what's bothering you."),
                    new TarotCards(20, 5, 4, "Practice empathy and try to see the situation from another perspective."),
                    new TarotCards(10, 5, 4, "Count to ten before responding to avoid saying something you might regret."),
                    new TarotCards(30, 5, 4, "Channel your anger into a constructive activity like cleaning or organizing."),
                    new TarotCards(60, 5, 4, "Seek professional help if anger becomes a recurring issue."),  // Time can vary depending on session length
                    new TarotCards(20, 5, 4, "Find perspective: Consider the bigger picture."),
                    new TarotCards(30, 5, 4, "Use humour: Lighten the mood, watch a comedy."),
                    new TarotCards(20, 5, 4, "Practice forgiveness: Let go of resentment."),
                    new TarotCards(15, 5, 4, "Journal anger: Write to process emotions."),
                    new TarotCards(15, 6, 4, "Take breaks throughout the day to relax and recharge."),
                    new TarotCards(15, 6, 4, "Prioritize tasks and break them down into smaller, manageable steps."),
                    new TarotCards(15, 6, 4, "Practice deep breathing or progressive muscle relaxation."),
                    new TarotCards(30, 6, 4, "Delegate responsibilities: Share the load if possible."),
                    new TarotCards(20, 6, 4, "Get organized: maybe make a list of tasks to do."),
                    new TarotCards(45, 6, 4, "Engage in physical activity like going for a walk or practicing yoga."),
                    new TarotCards(15, 6, 4, "Limit caffeine and sugar intake."),
                    new TarotCards(60, 6, 4, "Get plenty of sleep and establish a regular sleep schedule."),  // Time can vary depending on sleep needs
                    new TarotCards(30, 6, 4, "Practice time management techniques: try time blocking."),
                    new TarotCards(30, 6, 4, "Talk it out: Share feelings with a friend."),
                    new TarotCards(15, 6, 4, "Write it down: Journal to process emotions."),
                    new TarotCards(20, 6, 4, "Set boundaries: Protect your peace."),
                    new TarotCards(20, 7, 3, "Challenge negative thoughts and replace them with positive affirmations."),
                    new TarotCards(30, 7, 3, "Engage in activities that distract your mind, such as puzzles or games."),
                    new TarotCards(20, 7, 3, "Practice mindfulness or meditation to stay present."),
                    new TarotCards(15, 7, 3, "Limit exposure to triggers like caffeine or stressful situations."),
                    new TarotCards(30, 7, 3, "Talk to someone you trust about your feelings."),
                    new TarotCards(30, 7, 3, "Create a calming environment with soothing music, aromatherapy or just your bed."),
                    new TarotCards(20, 7, 3, "Focus on what you can control rather than what you can't."),
                    new TarotCards(45, 7, 3, "Exercise to reduce anxiety levels."),
                    new TarotCards(15, 7, 3, "Write worries: Release them on paper."),
                    new TarotCards(20, 7, 3, "Ground yourself: 5-4-3-2-1 list 5 things you can see, 4 you can touch, 3 you can hear, 2 you can smell, and 1 you can taste."),
                    new TarotCards(30, 7, 3, "Find calm: Listen to soothing music."),
                    new TarotCards(20, 7, 3, "Stretch and relax: Ease tension physically."),
                    new TarotCards(60, 7, 3, "Distract yourself: Engage in a hobby."),
                    new TarotCards(15, 7, 3, "Use affirmations: Positive self-talk, you are amazing and you are doing so well right now."),
                    new TarotCards(15, 8, 4, "Remove yourself from the source of disgust if possible."),
                    new TarotCards(15, 8, 4, "Practice deep breathing to calm your physical reactions."),
                    new TarotCards(20, 8, 4, "Focus on positive aspects of the situation or find humour in it."),
                    new TarotCards(30, 8, 4, "Engage in a pleasurable activity to shift your focus."),
                    new TarotCards(30, 8, 4, "Talk to a friend or loved one about how you're feeling."),
                    new TarotCards(20, 8, 4, "Practice acceptance and acknowledge that feelings of disgust are temporary."),
                    new TarotCards(45, 8, 4, "Engage in self-care activities to nurture yourself."),
                    new TarotCards(20, 8, 4, "Challenge irrational thoughts that may be fuelling your disgust."),
                    new TarotCards(30, 8, 4, "Seek out positive distractions like watching a funny movie or going for a walk."),
                    new TarotCards(15, 8, 4, "Practice gratitude to shift your perspective."),
                    new TarotCards(15, 8, 4, "Acknowledge feelings: Validate your emotions - they are valid."),
                    new TarotCards(30, 8, 4, "Vent constructively: Express frustrations calmly."),  // Time can vary depending on conversation length
                    new TarotCards(20, 8, 4, "Practice empathy: Understand different perspectives."),
                    new TarotCards(20, 8, 4, "Channel disgust: Use it as motivation for change."),
                    new TarotCards(20, 8, 4, "Challenge assumptions: Question underlying beliefs."),
                    new TarotCards(20, 8, 4, "Reflect on triggers: Identify what causes discomfort."),
                    new TarotCards(30, 9, 3, "Reach out to friends or loved ones for support."),
                    new TarotCards(45, 9, 3, "Engage in activities that bring you joy or comfort, like listening to music or cooking your favourite meal."),
                    new TarotCards(20, 9, 3, "Practice self-compassion and avoid self-criticism."),
                    new TarotCards(30, 9, 3, "Spend time with pets, if you have them, as they can provide comfort and companionship."),
                    new TarotCards(45, 9, 3, "Get outside and spend time in nature."),
                    new TarotCards(60, 9, 3, "Seek professional help if sadness persists or becomes overwhelming."),  // Time can vary depending on session length
                    new TarotCards(20, 9, 3, "Practice mindfulness or meditation to help regulate emotions."),
                    new TarotCards(15, 9, 3, "Write down your feelings in a journal."),
                    new TarotCards(30, 9, 3, "Engage in activities that give you a sense of accomplishment, like completing a small task or hobby."),
                    new TarotCards(30, 9, 3, "Connect with others who may be experiencing similar feelings to feel less alone."),
                    new TarotCards(10, 10, 4, "Try something new or engage in a hobby you enjoy."),
                    new TarotCards(30, 10, 4, "Reach out to friends or family for social interaction."),
                    new TarotCards(45, 10, 4, "Plan an outing or activity to break up the monotony."),
                    new TarotCards(30, 10, 4, "Watch a movie or TV show you've been wanting to see."),
                    new TarotCards(45, 10, 4, "Take a walk or explore a new area of your neighbourhood."),
                    new TarotCards(60, 10, 4, "Read a book or listen to an audiobook."),  // Time can vary depending on book/audiobook length
                    new TarotCards(60, 10, 4, "Volunteer for a cause you care about to add purpose to your day."),  // Time can vary depending on volunteering activity
                    new TarotCards(45, 10, 4, "Learn something new through online courses or tutorials."),
                    new TarotCards(45, 10, 4, "Get creative by drawing, painting, or crafting."),
                    new TarotCards(30, 10, 4, "Reflect on your goals and make plans to work towards them."),
                    new TarotCards(15, 11, 1, "Take a short nap if possible."),
                    new TarotCards(15, 11, 1, "Drink a glass of cold water or splash cold water on your face to wake up."),
                    new TarotCards(30, 11, 1, "Get up and move around to increase blood flow and alertness."),
                    new TarotCards(15, 11, 1, "Open windows or turn on bright lights to increase exposure to light."),
                    new TarotCards(15, 11, 1, "Have a small snack with protein to boost energy levels."),
                    new TarotCards(30, 11, 1, "Listen to upbeat music or engage in an activity that stimulates your mind."),
                    new TarotCards(15, 11, 1, "Practice deep breathing exercises to increase oxygen flow."),
                    new TarotCards(45, 11, 1, "Take a brisk walk outside to get fresh air and wake up your body."),
                    new TarotCards(15, 11, 1, "Avoid caffeine late in the day to prevent disrupting your sleep schedule."),
                    new TarotCards(15, 11, 1, "Splash cold water: Invigorate your senses."),
                    new TarotCards(20, 11, 1, "Stretch: Increase blood flow."),
                    new TarotCards(20, 11, 1, "Change environment: Move to a different room."),
                    new TarotCards(30, 12, 3, "Reach out to friends or family members for a chat or video call."),
                    new TarotCards(45, 12, 3, "Join a club or group with similar interests to meet new people."),
                    new TarotCards(60, 12, 3, "Volunteer for a cause you care about to connect with others and make a difference."),  // Time can vary depending on volunteering activity
                    new TarotCards(45, 12, 3, "Engage in activities you enjoy on your own, such as reading, cooking, or watching a movie."),
                    new TarotCards(30, 12, 3, "Spend time with pets, as they can provide companionship and comfort."),
                    new TarotCards(30, 12, 3, "Connect with old friends or acquaintances through social media or messaging apps."),
                    new TarotCards(45, 12, 3, "Attend social events or gatherings in your community to meet new people."),
                    new TarotCards(45, 12, 3, "Practice self-care activities to nurture yourself and boost your mood."),
                    new TarotCards(45, 12, 3, "Engage in hobbies or activities that bring you fulfilment and joy."),
                    new TarotCards(60, 12, 3, "Volunteer your time to help others, which can provide a sense of purpose and connection."),  // Time can vary depending on volunteering activity
                    new TarotCards(15, 12, 3, "Write in a journal to express your thoughts and feelings, helping you process emotions."),
                    new TarotCards(20, 12, 3, "Focus on building a strong relationship with yourself, practicing self-love and self-acceptance."),
                    new TarotCards(30, 13, 3, "Reach out: Talk to someone you trust."),
                    new TarotCards(45, 13, 3, "Practice self-care: Nurture your well-being (healthy eating, exercise, sleep hygiene)."),
                    new TarotCards(45, 13, 3, "Create a routine: Establish structure in your day."),
                    new TarotCards(30, 13, 3, "Set small goals: Celebrate every achievement, no matter how small."),
                    new TarotCards(45, 13, 3, "Stay active: Engage in physical activity, even a short walk can improve mood."),
                    new TarotCards(60, 13, 3, "Take a nap (if possible): Aim for 20-30 minutes to avoid sleep inertia."),  // Note about nap duration
                    new TarotCards(45, 13, 3, "Limit isolation: Connect with loved ones, even virtually."),
                    new TarotCards(30, 13, 3, "Express yourself: Write in a journal, talk to a therapist, or express yourself creatively."),
                    new TarotCards(20, 13, 3, "Focus on the present: Mindfulness exercises can help manage overwhelming thoughts.")

                );
        }
    }
}
