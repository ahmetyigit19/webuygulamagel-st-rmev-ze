using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webuygulamageliştirmevize.Controllers
{
    public class müşteriController : Controller
    {

        public IActionResult Listele()
        {
            return View(Models.müşteriveri.müşteriler);
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(Models.müşteri yeniOgrenci)
        {
            Models.müşteriveri.müşteriler.Add(yeniOgrenci);
            return RedirectToAction("Listele");
        }

        public IActionResult Guncelle(int müşteriId)
        {

            var r = Models.müşteriveri.müşteriler.FirstOrDefault(x => x.Id == müşteriId);
            return View(r);


        }

        [HttpPost]
        public IActionResult Guncelle(Models.müşteri müşteri)
        {
            var c = Models.müşteriveri.müşteriler.FirstOrDefault(x => x.Id == müşteri.Id);

            var r = Models.müşteriveri.müşteriler.FirstOrDefault(x => x.Id == müşteri.Id);
            r.Ad = müşteri.Ad;
            r.Soyad = müşteri.Soyad;
           

            Models.müşteriveri.müşteriler.Remove(c);

            Models.müşteriveri.müşteriler.Add(r);

            return RedirectToAction("listele");
        }


        public IActionResult Detay(int id)
        {
            var r = Models.müşteriveri.müşteriler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }


        public IActionResult Sil(int id)
        {
            var r = Models.müşteriveri.müşteriler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Sil(Models.müşteri müşteri)
        {
            var r = Models.müşteriveri.müşteriler.FirstOrDefault(x => x.Id == müşteri.Id);
            Models.müşteriveri.müşteriler.Remove(r);
            return RedirectToAction("Listele");
        }












    }
}