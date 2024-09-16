using KOU.Repositories;
using Microsoft.AspNetCore.Mvc;
using KOU.Models;
using Microsoft.AspNetCore.Authorization;
namespace KOU.Controllers
{
    public class ArabaSahibiController : Controller
    {
        ArabaSahibiRepository arabasahibiRepository = new ArabaSahibiRepository();
        [Authorize]
        public IActionResult Index()
        {
            return View(arabasahibiRepository.PList());
        }
        [HttpGet]
        public IActionResult ArabaSahibiEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ArabaSahibiEkle(ArabaSahibi a)
        {
            if (!ModelState.IsValid)
            {
                return View("ArabaSahibiEkle");
            }
            arabasahibiRepository.PEkle(a);
            return RedirectToAction("Index");
        }
        public IActionResult ArabaSahibiSil(int id)
        {
            arabasahibiRepository.PSil(new ArabaSahibi { Id = id });
            return RedirectToAction("Index");
        }
        public IActionResult ArabaSahibiGet(int id)
        {
            var x = arabasahibiRepository.PGet(id);
            ArabaSahibi y = new ArabaSahibi()
            {
                Id = x.Id,
                ArabaSahibiAdi = x.ArabaSahibiAdi,
                ArabaId = x.ArabaId,
                Borc = x.Borc,
                Alacak = x.Alacak,
            };
            return View(y);
        }
        [HttpPost]
        public IActionResult ArabaSahibiGuncelle(ArabaSahibi p)
        {
            var x = arabasahibiRepository.PGet(p.Id);
            x.ArabaSahibiAdi = p.ArabaSahibiAdi;
            x.ArabaId = p.ArabaId;
            x.Borc = p.Borc;
            x.Alacak = p.Alacak;
            arabasahibiRepository.PGuncel(x);
            return RedirectToAction("Index");
        }
    }
}