namespace petrotranz.Tests;

public class LibrarianUnitTest
{
    [Fact]
    public void CalculatePage_ShouldThrowError_WhenWordsPerPageIsZero()
    {
        var lib = new LibrarianDomain.Librarian();
        int totalWords = 100;
        int wordsPerPage = 0;

        Assert.Throws<ArgumentException>(() => lib.CalculatePage(totalWords, wordsPerPage));
    }

    [Fact]
    public void CalculatePage_ShouldReturnRoundUpAndCorrectNumberOfPage_WhenDivisionIsFloat()
    {
        var lib = new LibrarianDomain.Librarian();
        int totalWords = 105;
        int wordsPerPage = 10;

        int result = lib.CalculatePage(totalWords, wordsPerPage);

        Assert.Equal(11, result);
    }
}
