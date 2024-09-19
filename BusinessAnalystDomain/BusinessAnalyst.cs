using System.Text.RegularExpressions;

namespace BusinessAnalystDomain
{
    public class BusinessAnalyst
    {
        // Assumption: if result's length < 10, return all
        public static string[] getTenMostFrequencies(string filePath)
        {

            string extractedText = File.ReadAllText(filePath);
            string[] words = extractedText.Split(new[] { ' ', '\r', '\n', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> freqMap = new Dictionary<string, int>();
            Regex regex = new Regex("[^a-zA-Z]");
            // Todo: ignore special characters;
            foreach (string word in words)
            {
                string lowerCase = regex.Replace(word, "").ToLower();
                if (string.IsNullOrWhiteSpace(lowerCase)) continue;
                if (freqMap.ContainsKey(lowerCase)) freqMap[lowerCase]++;
                else freqMap[lowerCase] = 1;
            }

            PriorityQueue<string, int> top10 = new PriorityQueue<string, int>();

            foreach (var entry in freqMap)
            {
                top10.Enqueue(entry.Key, entry.Value);

                if (top10.Count > 10) top10.Dequeue();
            }
            List<string> result = new List<string>();
            while (top10.Count > 0)
            {
                result.Add(top10.Dequeue());
            }

            result.Reverse();
            return result.ToArray();
        }
    }
}
