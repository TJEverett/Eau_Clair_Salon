using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/Clients")]
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(Client => client.Stylist).ToList();
      return View(model);
    }

    [HttpGet("/Clients/new")]
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Specialty");
      return View();
    }

    [HttpPost("/Clients/new")]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}