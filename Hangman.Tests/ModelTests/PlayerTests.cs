   using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Tests
{
  [TestClass]
  public class PlayerTests : IDisposable
  {
    public void Dispose()
    {
      Player.ClearAll();
    }
   
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player newPlayer = new Player("test player");
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }
  }
}