namespace StudentDomain
{

    public class TextStatistic
    {
        public int wordCount { get; set; }
        public int charCount { get; set; }
    }

    public class Student
    {

        // Assuming the character does not include space
        public static TextStatistic countWords(string filePath)
        {
            string extractedText = File.ReadAllText(filePath);

            int wordCount = extractedText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            int numSpace = wordCount - 1;
            int charCount = extractedText.Length - numSpace;


            return new TextStatistic
            {
                wordCount = wordCount,
                charCount = charCount
            };
        }

        // Search a word, return occurence;
        public static int getWordOccurence(string target, string filePath)
        {
            string extractedText = File.ReadAllText(filePath);
            string[] words = extractedText.Split(new[] { ' ', '\r', '\n', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(word => word.Equals(target, StringComparison.OrdinalIgnoreCase));
        }
    }
}
