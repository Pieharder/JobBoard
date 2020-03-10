using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult JobForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string title, string description, string contact)
    {
      Item myItem = new Item(title, description, contact);
      return RedirectToAction("Index");
    }

  }
}