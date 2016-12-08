using Xunit;
using Counter;

namespace TestingGrounds
{
  public class Tests
  {
    //Tests for first spec
    [Fact]
    public void Test1_WordMatches_True()
    {
      RepeatCounter testCounter = new RepeatCounter("a", "a");
      Assert.Equal(true, testCounter.WordEqualsString());
    }

    [Fact]
    public void Test2_WordMatches_False()
    {
      RepeatCounter testCounter = new RepeatCounter("a", "b");
      Assert.Equal(false, testCounter.WordEqualsString());
    }
    
    //Tests for second spec
    [Fact]
    public void Test3_WordContains_True()
    {
      RepeatCounter testCounter = new RepeatCounter("too", "tool");
      Assert.Equal(true, testCounter.StringContainsWord());
    }

    [Fact]
    public void Test4_WordContains_False()
    {
      RepeatCounter testCounter = new RepeatCounter("cat", "timothy");
      Assert.Equal(false, testCounter.StringContainsWord());
    }

    //Test for third spec
    [Theory]
    [InlineData("break", "breaking")]
    [InlineData("bReak", "BrEAkING")]
    [InlineData("BREAK", "breaking")]
    [InlineData("BREAK", "BREAKING")]
    public void Test5_WordContainsWithDifferentCases_True(string input1, string input2)
    {
      RepeatCounter testCounter = new RepeatCounter(input1, input2);
      Assert.Equal(true, testCounter.GetOccurences() == 1);
    }

    //Test for fouth spec
    [Theory]
    [InlineData("dog", "cat", 0)]
    [InlineData("word", "word", 1)]
    [InlineData("dodge","The Dodgers", 1)]
    [InlineData("cat","Cathy cannot keep all of her cats together in the cathedral", 3)]
    [InlineData("the", "The thing is, there are a lot...", 2)]
    public void Test6_CheckOccurences_ReturnOccurences(string input1, string input2, int occurences)
    {
      RepeatCounter testCounter = new RepeatCounter(input1, input2);
      Assert.Equal(occurences, testCounter.GetOccurences());
    }

    //Test for fifth spec
    [Theory]
    [InlineData("country", "state", 0)]
    [InlineData("doggie", "dog", 0)]
    public void Test7_WordLongerThanInput_ReturnOccurences(string input1, string input2, int occurences)
    {
      RepeatCounter testCounter = new RepeatCounter(input1, input2);
      Assert.Equal(occurences, testCounter.GetOccurences());
    }
  }
}
