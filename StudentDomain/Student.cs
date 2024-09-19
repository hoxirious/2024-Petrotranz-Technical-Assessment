using HelperDomain;
namespace StudentDomain
{

    public class TextStatistic
    {
        public int wordCount { get; set; }
        public int charCount { get; set; }
    }

    public class Student
    {

        // Assumptions:
        // - Character does not include space
        public TextStatistic CountWords(string filePath)
        {
            string extractedText = "";
            if(filePath.Length > 0){
                extractedText = Helper.ReadAllText(filePath);
            }

            int wordCount = extractedText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            // number of deliminator equals to number of words - 1
            int numSpace = wordCount - 1;

            int charCount = extractedText.Length - numSpace;

            return new TextStatistic
            {
                wordCount = wordCount,
                charCount = charCount
            };
        }

        // Search a word, return occurence;
        // Assumption:
        // - Get exact word
        public int GetWordOccurence(string target, string filePath)
        {
            string extractedText = File.ReadAllText(filePath);
            string[] words = extractedText.Split(new[] {' ', '\r', '\n', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(word => word.Equals(target, StringComparison.OrdinalIgnoreCase));
        }
    }
}
