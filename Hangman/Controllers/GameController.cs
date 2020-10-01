using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Game.Controllers
{
  public class GameController : Controller
  {
   [HttpGet("/player")]
    public ActionResult Index()
    {
      List<Player> allPlayers = Player.GetAll();
      return View(allPlayers);
    }

    [HttpGet("/players/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/players")]
    public ActionResult Create(string playerName)
    {
      Player newPlayer = new Player(playerName);
      return RedirectToAction("Index");
    }

  }
}