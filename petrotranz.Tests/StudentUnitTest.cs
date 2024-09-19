namespace petrotranz.Tests;

public class StudentTest
{
    [Theory]
    [InlineData("world", 1)]
    [InlineData("hello", 2)]
    [InlineData("Hello", 2)]
    [InlineData("!", 0)]
    public void GetWordOccurence_ShouldReturnCorrectOccurrence_WhenGivenSmallSample(string target, int expected)
    {
        var student = new StudentDomain.Student();
        string testText = "Hello world. hello there!";
        string filePath = "testfile.txt";

        File.WriteAllText(filePath, testText);

        int count = student.GetWordOccurence(target, filePath);

        Assert.Equal(expected, count);

        File.Delete(filePath);
    }

    [Fact]
    public void GetWordOccurrence_ShouldReturnCorrectOccurrence_WhenGivenLargeSample1()
    {
        var student = new StudentDomain.Student();
        string target = "january";
        string filePath = "../../../Data/A Tale of Two Cities - Charles Dickens.txt";

        int count = student.GetWordOccurence(target, filePath);
        Assert.Equal(1, count);
    }
    [Fact]
    public void CountWords_ShouldReturnCorrectWordCount_WhenGivenSmallSample()
    {
        var student = new StudentDomain.Student();

        string testText = "[2024] Technical Test ";

        string filePath = "testfile.txt";

        File.WriteAllText(filePath, testText);

        var result = student.CountWords(filePath);

        Assert.Equal(3, result.wordCount);
    }

    [Fact]
    public void CountWords_ShouldReturnCorrectCharCount_WhenGivenSmallSample()
    {
        var student = new StudentDomain.Student();

        string testText = "[2024] Technical Test ";

        string filePath = "testfile.txt";

        File.WriteAllText(filePath, testText);

        var result = student.CountWords(filePath);

        Assert.Equal(19, result.charCount);
    }
}
