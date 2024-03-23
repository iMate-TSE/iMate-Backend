using iMate.API.Data.Models;

namespace iMate.API.Services
{
    using PADCoordinateVector = (float, float, float);

    public class EmotionClassifier
    {
        private Dictionary<PADCoordinateVector, string> pad_ranges;

        public EmotionClassifier(List<PadRanges> ranges)
        {
            this.pad_ranges = new Dictionary<PADCoordinateVector, string>();

            // Construct a dictionary from the data from the database
            for (int i = 0; i < ranges.Count; i++)
            {
                PadRanges moodValue = ranges[i];

                PADCoordinateVector vec = new PADCoordinateVector(
                    moodValue.valuePleasure, 
                    moodValue.valueArousal, 
                    moodValue.valueDominance
                );

                this.pad_ranges[vec] = moodValue.mood;
            }
        }

        private float Euclidian_Distance(PADCoordinateVector pointA, PADCoordinateVector pointB)
        {
            // compute the euclidian distance between points
            float x_square = (float)Math.Pow((pointA.Item1 - pointB.Item1), 2);
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
