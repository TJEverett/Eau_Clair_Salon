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
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }

    [HttpGet("/Clients/new")]
    public ActionResult Create()
    {
      IEnumerable<SelectListItem> IdList = _db.Stylists.Select(s => new SelectListItem
      {
        Value = s.StylistId.ToString(),
        Text = $"{s.Specialty} ({s.NameFirst} {s.NameLast})"
      });
      ViewBag.StylistId = IdList;
      ViewBag.ListCount = IdList.Count<SelectListItem>();
      return View();
    }

    [HttpPost("/Clients/new")]
    public ActionResult Create(Client client)
    {
      if(client.StylistId != 0)
      {
        _db.Clients.Add(client);
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}