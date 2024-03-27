using iMate.API.Data.Models;

namespace iMate.API.Services
{
    using PADCoordinateVector = (float, float, float);

    public class EmotionClassifier
    {
        private readonly Dictionary<PADCoordinateVector, string> _padRanges;

        public EmotionClassifier(List<PadRanges> ranges)
        {
            this._padRanges = new Dictionary<PADCoordinateVector, string>();

            // Construct a dictionary from the data from the database
            foreach (var moodValue in ranges)
            {
                PADCoordinateVector vec = new PADCoordinateVector(
                    moodValue.valuePleasure, 
                    moodValue.valueArousal, 
                    moodValue.valueDominance
                );

                this._padRanges[vec] = moodValue.mood;
            }
        }

        private static float Euclidean_Distance(PADCoordinateVector pointA, PADCoordinateVector pointB)
        {
            // compute the Euclidean distance between points
            float xSquare = (float)Math.Pow((pointA.Item1 - pointB.Item1), 2);
            float ySquare = (float)Math.Pow((pointA.Item2 - pointB.Item2), 2);
            float zSquare = (float)Math.Pow((pointA.Item3 - pointB.Item3), 2);
            return float.Sqrt(xSquare + ySquare + zSquare);
        }

        private string KNN(PADCoordinateVector point)
        {
            // store the distances to each point
            Dictionary<string, float> distances = new Dictionary<string, float>();

            foreach (PADCoordinateVector coord in this._padRanges.Keys)
            {
                // compute the distance to the current point 
                float dist = Euclidean_Distance(point, coord);
                distances.Add(this._padRanges[coord], dist);
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
