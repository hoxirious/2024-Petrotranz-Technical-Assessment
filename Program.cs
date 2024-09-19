using LibrarianDomain;
using StudentDomain;
using BusinessAnalystDomain;

class Program
{
    static void Main(string[] args)
    {
        int pageNum = Librarian.calculatePage(50000, 250);

        Console.WriteLine("Total Page: "+ pageNum);

        TextStatistic book = Student.countWords("Data/A Tale of Two Cities - Charles Dickens.txt");

        Console.WriteLine("Total words: "+ book.wordCount + "; Total characters: " + book.charCount);

        int wordOccurrence = Student.getWordOccurence("revolution", "Data/A Tale of Two Cities - Charles Dickens.txt");
        Console.WriteLine("The word revolution: " + wordOccurrence);

        string[] topWords = BusinessAnalyst.getTenMostFrequencies("Data/A Tale of Two Cities - Charles Dickens.txt");

        Console.WriteLine("Top 10 most frequent words:");
        foreach (var word in topWords) Console.WriteLine(word);
    }
}
