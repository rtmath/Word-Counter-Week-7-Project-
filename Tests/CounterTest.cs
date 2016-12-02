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


  }
}
