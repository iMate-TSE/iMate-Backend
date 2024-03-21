# James and Daniel Notes
- These need to be converted to model files
- They can be individual they don't have to be
- James has an example to use

### The User 
- This table also should have an age and gender attribute
```cs 
    public class user
    {
        public int userID;
        public string userName;
        public int credits;
        public int streak;
        public string avatarPath;
    }
```

### The Journal 
- This looks like it stores 2 moods? can we make it a range so we can graph it?
- It can be an array (see example)
- In this case userID is a foreign key, so we need another key to be primary like `JournalID`

```cs
    public class journal
    {
        public int userID;
        public string currentMood;
        public string previousMood;
        public string timeScale;
        public string date;
    }
```

### Settings
- In this case userID is a foreign key, so we need another key to be primary like `SettingID`
- Add an attribute to store the time of the reminder 

```cs
    public class settings
    {
        public int userID;
        public bool soundEffects;
        public bool smsReminder;
        public bool motivationalMessages;
        public bool practiceReminder;
        public bool smartScheduling;
    }
```

### Mood Update?
- I don't think we need this one
- We can just send the data don't need to store it that's what the journal is for 

```cs
    public class moodUpdate
    {
        public int updateID;
        public int customerID;
        public float cardValueValence;
        public float cardValueArousal;
        public float cardValueDominance;
    }
```

### Forms 
- Leaving these for now because idk what the data will look like yet
- If `updateID` is a FK does it need a PK?
 
```cs
    public class slidersInput
    {
        public int updateID;
        public float cardValueValence;
        public float cardValueArousal;
        public float cardValueDominance;
    }

    public class formInput
    {
        public int updateID;
        public string formAnswers;
        public float cardValueValence;
        public float cardValueArousal;
        public float cardValueDominance;
    }

    public class sliderQuestions
    {
        public int updateID;
        public string sliderQuestions;
    }

    public class formQuestions
    {
        public int updateID;
        public string formQuestions;
    }
```

### Cards 
- If you can justify this decision then fine, but does this need to be two tables?
- Maybe it does? can two cards have the same PAD and credit values?
- Normalisation fr xddd

```cs
    public class tarotCards
    {
        public int cardID;
        public int updateID;
        public int cardCreditsValue;
        public float cardValueValence;
        public float cardValueArousal;
        public float cardValueDominance;
    }


    public class tasks
    {
        public int cardID;
        public string task;
    }
```

### Other 
- I have no comments here so just typing this to make it look uniform
```cs

    public class facts
    {
        public int cardID;
        public string fact;
    }

    public class otherStimuli
    {
        public int cardID;
        public string stimuliPath;
    }
}
```