using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers {
  public class AlbumsController : Controller 
  {

    [HttpGet("/albums/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/albums")]
    public ActionResult Create (string title)
    {
      Album newAlbum = new Album(title);
      return RedirectToAction("Index");
    }

    [HttpGet("/albums/{id}")]
    public ActionResult Show(int id)
    {
      Album foundAlbum = Album.Find(id);
      return View(foundAlbum);
    }
  }
}