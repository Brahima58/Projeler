using KOU.Repositories;
using Microsoft.AspNetCore.Mvc;
using KOU.Models;
using Microsoft.AspNetCore.Authorization;
namespace KOU.Controllers
{
    public class ParcaController : Controller
    {
        ParcaRepository parcaRepository = new ParcaRepository();
        [Authorize]
        public IActionResult Index()
        {
            return View(parcaRepository.PList());
        }
        [HttpGet]
        public IActionResult ParcaEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParcaEkle(Parca a)
        {
            if (!ModelState.IsValid)
            {
                return View("ArabaSahibiEkle");
            }
            parcaRepository.PEkle(a);
            return RedirectToAction("Index");
        }
        public IActionResult ParcaSil(int id)
        {
            parcaRepository.PSil(new Parca { ParcaId = id });
            return RedirectToAction("Index");
        }
        public IActionResult ParcaGet(int id)
        {
            var x = parcaRepository.PGet(id);
            Parca v = new Parca()
            {
                ParcaId = x.ParcaId,
                ParcaIsim = x.ParcaIsim,
                ParcaStok = x.ParcaStok,
                ParcaTur = x.ParcaTur,
                
            };
            return View(v);
        }
        [HttpPost]
        public IActionResult ParcaGuncelle(Parca p)
        {
            var x = parcaRepository.PGet(p.ParcaId);
            x.ParcaIsim = p.ParcaIsim;
            x.ParcaStok = p.ParcaStok;
            x.ParcaTur = p.ParcaTur;
            parcaRepository.PGuncel(x);
            return RedirectToAction("Index");
        }
    }
}