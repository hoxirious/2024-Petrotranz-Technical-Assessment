using System.Text.RegularExpressions;
using HelperDomain;
using System.Linq;

namespace BusinessAnalystDomain
{
    public class BusinessAnalyst
    {
        // Assumptions:
        // - If result's length < 10, return all
        // - Only take alphabetic words
        public string[] GetTenMostFrequencies(string input, bool isFilePath)
        {
            if (isFilePath)
                input = HelperDomain.Helper.ReadAllText(input);
            return Execute(input);
        }

        private string[] Execute(string text)
        {
            string[] words = text.Split(new[] { ' ', '\r', '\n', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> freqMap = new Dictionary<string, int>();

            Regex regex = new Regex("[^a-zA-Z]");

            // Create frequencies map
            foreach (string word in words)
            {
                string newWord = regex.Replace(word, "").ToLower();

                if (string.IsNullOrWhiteSpace(newWord)) continue;

                if (freqMap.ContainsKey(newWord)) freqMap[newWord]++;
                else freqMap[newWord] = 1;
            }

            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();
            // Get 10 most occurent words
            foreach (var entry in freqMap)
            {
                pq.Enqueue(entry.Key, entry.Value);

                if (pq.Count > 10) pq.Dequeue();
            }

            // Return result
            List<string> result = new List<string>();
            while (pq.Count > 0)
            {
                result.Add(pq.Dequeue());
            }

            result.Reverse();
            return result.ToArray();

        }
    }
}
