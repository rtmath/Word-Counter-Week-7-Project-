using System;

namespace Counter
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _stringToCheck;

    public RepeatCounter(string input1, string input2)
    {
      _inputWord = input1;
      _stringToCheck = input2;
    }

    public bool ContainsWord()
    {
      return _stringToCheck.Contains(_inputWord);
    }

    public int CounterRepeats()
    {
      return 1;
    }
  }
}
