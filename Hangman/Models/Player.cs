using System.Collections.Generic;

namespace Hangman.Models
{
  public class Player
  {
    public string Name { get; set; }
    public int Strikes { get; set; }
    public List<string> UsedLetters { get; set; }
    public List<string> WrongLetters { get; set; } 
    public List<string> WrongWord { get; set; } 

    public Player(string name)
    {
      Name = name;
      Strikes = 0;
      UsedLetters = new List<string> { };
      WrongLetters = new List<string> { };
      WrongWord = new List<string> { };
    }
    
  }
}