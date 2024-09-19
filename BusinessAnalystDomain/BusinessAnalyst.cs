using System.Text.RegularExpressions;
using HelperDomain;

namespace BusinessAnalystDomain
{
    public class BusinessAnalyst
    {
        // Assumptions:
        // - if result's length < 10, return all
        // - only take alphabetic words
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

            foreach (string word in words)
            {
                string newWord = regex.Replace(word, "").ToLower();
                if (string.IsNullOrWhiteSpace(newWord)) continue;
                if (freqMap.ContainsKey(newWord)) freqMap[newWord]++;
                else freqMap[newWord] = 1;
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
