using System;

namespace Counter
{
  public class RepeatCounter
  {
    private string _word;
    private string _string;
    private string _lowerWord;
    private string _lowerString;
    private int _wordOccurence;

    public RepeatCounter(string inputtedWord, string inputtedString)
    {
      _word = inputtedWord;
      _lowerWord = inputtedWord.ToLower();
      _string = inputtedString;
      _lowerString = inputtedString.ToLower();
      CountRepeats();
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetString()
    {
      return _string;
    }

    public int GetOccurences()
    {
      return _wordOccurence;
    }

    public bool StringContainsWord()
    {
      return _lowerString.Contains(_lowerWord);
    }

    public void CountRepeats()
    {
      if (StringContainsWord())
      {
        for (int j = 0; j < _lowerString.Length; j++)
        {
          // For each letter in String, if that letter is the same as the first letter in Word,
          // and if (j index plus Word.length) will not be an out of bounds index in String
          if (_lowerString[j] == _lowerWord[0] && j <= (_lowerString.Length - _lowerWord.Length))
          {
            // Check if the substring at that index matches the inputted word
            if (IsMatch(_lowerWord, _lowerString, j))
            {
              _wordOccurence++;
            }
          }
        }
      }
    }

    public bool IsMatch(string word, string inputtedString, int inputtedStringIndex)
    {
      bool match = true;
      for (int i = 0; i < word.Length; i++)
      {
        if (word[i] != inputtedString[inputtedStringIndex + i])
        {
          match = false;
        }
      }
      return match;
    }
  }
}
