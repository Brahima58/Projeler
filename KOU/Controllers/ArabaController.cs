using KOU.Repositories;
using Microsoft.AspNetCore.Mvc;
using KOU.Models;
using Microsoft.AspNetCore.Authorization;
namespace KOU.Controllers
{
    public class ArabaController : Controller
    {
        ArabaRepository arabaRepository = new ArabaRepository();
        [Authorize]
        public IActionResult Index()
        {
            return View(arabaRepository.PList());
        }
        [HttpGet]
        public IActionResult ArabaEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ArabaEkle(Araba a)
        {
            if (!ModelState.IsValid)
            {
                return View("ArabaEkle");
            }
            arabaRepository.PEkle(a);
            return RedirectToAction("Index");
        }

        public IActionResult ArabaSil(int id)
        {
            arabaRepository.PSil(new Araba { ArabaId = id });
            return RedirectToAction("Index");
        }
        public IActionResult ArabaGet(int id)
        {
            var x = arabaRepository.PGet(id);
            Araba ct= new Araba()
            {
             ArabaId =x.ArabaId,
             Marka=x.Marka,
             Model=x.Model,
             Plaka=x.Plaka,
             Renk=x.Renk,
             Sasi=x.Sasi,  
             Problem=x.Problem,
             Kilometre=x.Kilometre,
             Islem=x.Islem,
             IslemUcret=x.IslemUcret,
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult ArabaGuncelle(Araba p)
        {
            var x = arabaRepository.PGet(p.ArabaId);
            x.Marka= p.Marka;
            x.Model=p.Model;
            x.Plaka=p.Plaka;
            x.Renk=p.Renk; 
            x.Sasi=p.Sasi;
            x.Problem=p.Problem;
            x.Kilometre=p.Kilometre;
            x.Islem=p.Islem;
            x.IslemUcret=p.IslemUcret;
            arabaRepository.PGuncel(x);
            return RedirectToAction("Index");
        }

    }
}
