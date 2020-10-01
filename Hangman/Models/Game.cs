using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class Game
  {
    public List<string> Word = new List<string> ();
    public List<string> Solved = new List<string>();
    public static List<string> WordList = new List<string> {"Test","Abacadabara"};

    public Game()
    {
      Word = new List<string> { };
      this.RandomWord();
      Solved = new List<string> { };
      PlayerSolved();
    }

    public void RandomWord()
    {
      Random random = new Random();
      int num = random.Next((WordList.Count- 1));
      string word = WordList[num];
      foreach(char letter in word)
      {
        this.Word.Add(letter.ToString());
      }
    }

    public void PlayerSolved()
    {
      for (int i = 0; i < Word.Count; i++)
      {
        if ( Word[i] != " ")
        {
          Solved.Add("_");
        }
        else 
        {
          Solved.Add(" ");
        }
      }
    }
    public 
    {

    }
    public void CheckPuzzle(Game game, string letter)
    {
      if (game.Word.Contains(letter))
      {

        for (int i = 0; i < game.Word.Count; i++)
        {
          if (game.Word[i] == letter)
          {
            game.Solved[i] = letter;
          }
        }
      }
    }

  }
}