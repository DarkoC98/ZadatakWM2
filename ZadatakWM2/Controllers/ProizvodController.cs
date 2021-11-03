using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZadatakWM2.Context;
using System.Data.Entity;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace ZadatakWM2.Controllers
{
    public class ProizvodController : Controller
    {
        //JSON - Nazalost nisam se snasao sa JSON-om
        
        [HttpGet]
        public ActionResult Index()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\Darko\source\repos\ZadatakWM2\ZadatakWM2\ProizvodJSON\Proizvod.json");
            var proizvodi = JsonConvert.DeserializeObject<Proizvod>(json);
            return View(proizvodi);
        }




        //
        public ActionResult ProizvodiListJ()
        {
            return View(GetProizvods());
        }
        IEnumerable<Proizvod> GetProizvods()
        {
            using(ZadatakWMEntities db = new ZadatakWMEntities())
            {
               return db.Proizvods.ToList<Proizvod>();
            }
        }
        // GET: Proizvod

        ZadatakWMEntities dbObj = new ZadatakWMEntities();
        public ActionResult Proizvod(Proizvod obj)
        {
            if (obj != null)
            {
                return View(obj);
            }else
            {
                return View();
            }

            return View();
        }
        [HttpPost]
        public ActionResult AddProizvod(Proizvod model)
        {

            if (ModelState.IsValid)
            {

                Proizvod obj = new Proizvod();
                obj.id = model.id;
                obj.naziv = model.naziv;
                obj.opis = model.opis;
                obj.kategorija = model.kategorija;
                obj.proizvodjac = model.proizvodjac;
                obj.dobavljac = model.dobavljac;
                obj.cena = model.cena;

                if (model.id == 0)
                {


                    dbObj.Proizvods.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
            }
            ModelState.Clear();


            return View("Proizvod");



        }
    
        public ActionResult ProizvodList()
        {
            var res = dbObj.Proizvods.ToList();
            return View(res);
        }
        public ActionResult Delete(int id)
        {
            var res = dbObj.Proizvods.Where(x => x.id == id).First();
            dbObj.Proizvods.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.Proizvods.ToList();
            return View("ProizvodList", list);
        }
    }
}
