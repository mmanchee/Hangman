using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Tests
{
  [TestClass]
  public class HangmanTests : IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }

    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("test");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }