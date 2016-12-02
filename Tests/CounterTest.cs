using Xunit;
using Counter;

namespace TestingGrounds
{
  public class Tests
  {
    //Tests for first spec
    [Fact]
    public void Test1_WordContains_True()
    {
      RepeatCounter testCounter = new RepeatCounter("too", "tool");
      Assert.Equal(true, testCounter.ContainsWord());
    }

    [Fact]
    public void Test2_WordContains_True()
    {
      RepeatCounter testCounter = new RepeatCounter("cat", "dog");
      Assert.Equal(false, testCounter.ContainsWord());
    }

    //Test for second spec
    [Theory]
    [InlineData("break", "breaking")]
    [InlineData("bReak", "BrEAkING")]
    [InlineData("BREAK", "breaking")]
    [InlineData("BREAK", "BREAKING")]
    public void Test3_WordContainsWithDifferentCases_True(string input1, string input2)
    {
      RepeatCounter testCounter = new RepeatCounter(input1, input2);
      Assert.Equal(true, testCounter.ContainsWord());
    }

    [Theory]
    [InlineData("dodge","The Dodgers", 1)]
    [InlineData("cat","Cathy cannot keep all of her cats together in the cathedral", 3)]
    [InlineData("the", "The thing is, there are a lot...", 2)]
    public void Test4_CheckOccurences_ReturnOccurences(string input1, string input2, int occurences)
    {
      RepeatCounter testCounter = new RepeatCounter(input1, input2);
      Assert.Equal(occurences, testCounter.CounterRepeats());
    }
  }
}
