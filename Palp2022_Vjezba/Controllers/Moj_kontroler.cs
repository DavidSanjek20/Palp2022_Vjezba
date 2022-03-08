using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Palp2022_Vjezba.Controllers
{
    public class Moj_kontroler : Controller
    {
        // GET: Moj_kontroler
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko veleučilište u Čakovcu";
            return View();
        }

        public ActionResult Druga()
        {
            ViewBag.Ustanova = "Međimursko veleučilište";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }

        public ActionResult Treca(string poruka, int broj = 1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }

        public ActionResult Cetvrta(string ime, string prezime, float godinaRodjenja)
        {
            ViewBag.ime = ime;
            ViewBag.prezime = prezime;
            ViewBag.godinaRodjenja = godinaRodjenja;
            return View();
        }
    }
}