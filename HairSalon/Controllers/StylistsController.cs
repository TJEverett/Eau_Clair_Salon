using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/Stylists")]
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.Include(stylist => stylist.Clients).ToList();
      return View(model);
    }

    [HttpGet("/Stylists/new")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/Stylists/new")]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("/Stylists/{id}")]
    public ActionResult Show(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }
  }
}