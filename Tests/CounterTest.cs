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
  }
}
