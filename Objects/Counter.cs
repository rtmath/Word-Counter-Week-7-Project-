using System;

namespace Counter
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _stringToCheck;
    private string _lowerInputWord;
    private string _lowerStringToCheck;

    public RepeatCounter(string input1, string input2)
    {
      _inputWord = input1;
      _lowerInputWord = input1.ToLower();
      _stringToCheck = input2;
      _lowerStringToCheck = input2.ToLower();
    }

    public bool ContainsWord()
    {
      return _lowerStringToCheck.Contains(_lowerInputWord);
    }

    public int CounterRepeats()
    {
      return 1;
    }
  }
}
