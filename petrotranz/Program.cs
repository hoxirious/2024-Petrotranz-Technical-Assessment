using LibrarianDomain;
using StudentDomain;
using BusinessAnalystDomain;

class Program
{
    static void Main(string[] args)
    {
        string file1 = "Data/A Tale of Two Cities - Charles Dickens.txt";
        string file2 = "Data/Alices Adventures in Wonderland - Lewis Carroll.txt";

        Librarian lib1 = new Librarian();
        Student student1 = new Student();
        BusinessAnalyst businessAnalyst1 = new BusinessAnalyst();

        Console.WriteLine(" A Tail of Two Cities Statistics");
        Console.WriteLine("Total Page: "+ lib1.CalculatePage(student1.CountWords(file1).wordCount, 250));
        TextStatistic book1 = student1.CountWords(file1);
        Console.WriteLine("The occurrence of word revolution: " + student1.GetWordOccurence("revolution", file1));
        Console.WriteLine("Total words: "+ book1.wordCount + "; Total characters: " + book1.charCount);
        string[] topWords1 = businessAnalyst1.GetTenMostFrequencies(file1, true);
        Console.WriteLine("Top 10 most frequent words:");
        foreach (var word in topWords1) Console.WriteLine(word);

        Console.WriteLine("--------");
        Console.WriteLine("Alices Adventures in Wonderland Statistics");
        Console.WriteLine("Total Page: "+ lib1.CalculatePage(student1.CountWords(file2).wordCount, 250));
        TextStatistic book2 = student1.CountWords(file2);
        Console.WriteLine("The occurrence of word happy: " + student1.GetWordOccurence("Happy", file2));
        Console.WriteLine("Total words: "+ book2.wordCount + "; Total characters: " + book2.charCount);
        string[] topWords2 = businessAnalyst1.GetTenMostFrequencies(file2, true);
        Console.WriteLine("Top 10 most frequent words:");
        foreach (var word in topWords2) Console.WriteLine(word);

}
}
