using System;

namespace LeetSpeak
{
  public class IsLeet
  {
    private readonly char[] leetChar = new char[]{'e','o','I','t','s'};

    public char[] getLeetChar()
    {
      return leetChar;
    }

    public bool LeetCheck(string myStr)
    {
      string[] checkArrStr = myStr.Split(null);
      for(int i = 0; i < checkArrStr.Length; i++)
      {
        for(int j = 0; j < checkArrStr[i].Length; j++)
        {
          if(Array.IndexOf(leetChar, checkArrStr[i][j]) > -1)
          {
            return true;
          }
        }
      }
      return false;
    }

    public char LeetConvert(char myChar)
    {
      switch(myChar){
        case 'e':
          return '3';
        case 'o':
          return '0';
        case 'I':
          return '1';
        case 't':
          return '7';
        case 's':
          return 'z';
      }
      return '~'; //Failure
    }

    public string LeetMakeStr(string myStr)//Uses LeetCheck Logic, but actually returns the string we want
    {
      string[] checkArrStr = myStr.Split(null);
      string answerStr = "";
      for(int i = 0; i < checkArrStr.Length; i++)
      {
        for(int j = 0; j < checkArrStr[i].Length; j++)
        {
          if(Array.IndexOf(leetChar, checkArrStr[i][j]) > -1)
          {
            answerStr += LeetConvert(checkArrStr[i][j]);
          }else{
            answerStr += checkArrStr[i][j];
          }
        }
        if(i != checkArrStr.Length - 1){
          answerStr += ' ';
        }
      }
      return answerStr;
    }
  }
}
