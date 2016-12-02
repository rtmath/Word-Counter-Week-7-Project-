using System;

namespace Counter
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _stringToCheck;
    private string _lowerInputWord;
    private string _lowerStringToCheck;
    private int _wordOccurence;

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

    public int CountRepeats()
    {
      if (ContainsWord())
      {
        for (int j = 0; j < _lowerStringToCheck.Length; j++)
        {
          if (_lowerStringToCheck[j] == _lowerInputWord[0])
          {
            if (IsMatch(_lowerInputWord, _lowerStringToCheck, j))
            {
              _wordOccurence++;
            }
          }
        }
      }
      return _wordOccurence;
    }

    public bool IsMatch(string str1, string str2, int str2index)
    {
      bool match = true;
      for (int i = 0; i < str1.Length; i++)
        if (str1[i] != str2[str2index + i])
          match = false;
      return match;
    }
  }
}
