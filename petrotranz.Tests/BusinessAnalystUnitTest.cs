namespace petrotranz.Tests;

public class BusinessAnalystTest
{
    private BusinessAnalystDomain.BusinessAnalyst ba;
    public BusinessAnalystTest()
    {
        ba = new BusinessAnalystDomain.BusinessAnalyst();
    }
    [Fact]
    public void GetTenMostFrequencies_ShouldReturnEmptyArray_WhenInputIsEmpty()
    {
        string input = "";

        var result = ba.GetTenMostFrequencies(input, false);

        Assert.Empty(result);
    }

    [Fact]
    public void GetTenMostFrequencies_ShouldReturnTopTenMostFrequentWords()
    {
        string input = "wood mac mac oil gas  Mac wood wood oil gas gas energy wood mac hy mac apple test apple test result ";

        var result = ba.GetTenMostFrequencies(input, false);
        Assert.Equal(9, result.Length);
        Assert.Equal("mac", result[0]);
        Assert.Equal("wood", result[1]);
    }

    [Fact]
    public void GetTenMostFrequencies_ShouldCountOnlyAlphabetWords()
    {
        string input = "wood mac! mac? oil gas !Mac wood wood oil gas gas energy wood 1mac hy mac~ apple test apple test result ";

        var result = ba.GetTenMostFrequencies(input, false);
        Assert.Equal(9, result.Length);
        Assert.Equal("mac", result[0]);
        Assert.Equal("wood", result[1]);

    }

    [Fact]
    public void GetTenMostFrequencies_ShouldReturnOnlyTopTen_WhenMoreThanTenUniqueWords()
    {
        string input = "one two three four five six seven eight nine ten eleven twelve thirteen";

        var result = ba.GetTenMostFrequencies(input, false);

        Assert.Equal(10, result.Length);
    }

    [Theory]
    [InlineData("../../../Data/Alices Adventures in Wonderland - Lewis Carroll.txt")]
    [InlineData("../../../Data/A Tale of Two Cities - Charles Dickens.txt")]
    public void GetTenMostFrequencies_ShouldReturnTopTen_WhenReadInputFromFile(string filePath)
    {
        var result = ba.GetTenMostFrequencies(filePath, true);

        Assert.Equal(10, result.Length);
    }
}


