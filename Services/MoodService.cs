namespace iMate.API.Services
{
    using PADCoordinateVector = (float, float, float);
    
    public class MoodService 
    {
        Dictionary<PADCoordinateVector, string> pad_ranges = new Dictionary<PADCoordinateVector, string>()
        {
            /* 0-0.4 = Low
             * 0.5-0.7 = Moderate
             * 0.8-1.0 = High 
             */
            //  P     A     D
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
        };

        private float Euclidian_Distance(PADCoordinateVector pointA, PADCoordinateVector pointB)
        {
            // compute the euclidian distance between points
            float x_square = (float)Math.Pow((pointA.Item1 -  pointB.Item1), 2);
            float y_square = (float)Math.Pow((pointA.Item2 - pointB.Item2), 2);
            float z_square = (float)Math.Pow((pointA.Item3 - pointB.Item3), 2);
            return float.Sqrt(x_square + y_square + z_square);
        }

        private string KNN(PADCoordinateVector point)
        {
            // store the distances to each point
            Dictionary<string, float> distances = new Dictionary<string, float>();

            foreach (PADCoordinateVector coord in pad_ranges.Keys)
            {
                // compute the distance to the current point 
                float dist = Euclidian_Distance(point, coord);
                distances.Add(pad_ranges[coord], dist);
            }

            // Sort the dictionary 
            var sortedDict = distances.OrderBy(distance => distance.Value);

            //  return the key of the smallest distance
            return sortedDict.First().Key;
        }

        public string ClassifyEmotionByPAD(int PleasureDispleasure, int ArousalNonArousal, int DominantSubmissive)
        {
            //  normalise values placing range from 0-1
            float PD_n = PleasureDispleasure / 10f;
            float AN_n = ArousalNonArousal / 10f;
            float DS_n = DominantSubmissive / 10f;

            PADCoordinateVector coords = new PADCoordinateVector(PD_n, AN_n, DS_n);

            // get the mood
            string mood = KNN(coords);

            return mood;

        }
    }
}