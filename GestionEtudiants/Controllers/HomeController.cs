using Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Admin.Context;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

using Newtonsoft.Json;
using OfficeOpenXml;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        [Obsolete]
        private readonly IHostingEnvironment _hostEnvironment;

        private myContext db = new myContext();

        [Obsolete]
        public HomeController(ILogger<HomeController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult AddEtudiant()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<Etudiant>> AddEtudiant(IFormFile file)
        {
            var listP = new List<Etudiant>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;
                    for (int row = 1; row < rowcount; row++)
                    {
                        if(worksheet.Cells[row, 2].Value != null) { 
                            db.Add(new Etudiant()
                            {
                                cne = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                email = worksheet.Cells[row, 3].Value.ToString().Trim(),
                                cin = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                firstname = worksheet.Cells[row, 5].Value.ToString().Trim(),
                                lastname = worksheet.Cells[row, 6].Value.ToString().Trim(),
                                classeId = 1

                            });
                        }
                    }
                    db.SaveChanges();
                }
            }
            return null;
        }


        //professeur
        public IActionResult AddProfesseur()
        {
            var departements = db.departements.ToList();
            ViewBag.dep = departements;
            return View();
        }
        public IActionResult StoreProfesseur(string nom,string prenom,string email, int departement, string password)
        {
            var prof = new Professeur { nom = nom, prenom = prenom, email = email, departementId = departement, password = password };
            db.Professeurs.Add(prof);
            db.SaveChanges();

            return Redirect("AddProfesseur");
        }
        public IActionResult TrombinoscopeProf()
        {
            var departements = db.departements.ToList();
            ViewBag.dep = departements;
            return View();
        }

        public IActionResult DisplayProfesseur()
        {
            var professeurs = db.Professeurs.Include(p => p.departement).Include(p => p.modules).ToList();
            ViewBag.profs = professeurs;
            return View();
        }

        public IActionResult DeleteProfesseur(int id)
        {
            if (db.Professeurs.Find(id) != null)
            {
                db.Professeurs.Remove(db.Professeurs.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction(controllerName:"Home", actionName: "DisplayProfesseur");
        }

        //departement
        public IActionResult AddDepartement()
        {
            return View();
        }

        public IActionResult StoreDepartement(string nom)
        {
            var dep = new Departement { nom = nom };
            db.departements.Add(dep);
            db.SaveChanges();

            return RedirectToAction(actionName:"AddDepartement");
        }
        
        public IActionResult DisplayDepartement()
        {
            var departements = db.departements.ToList();
            ViewBag.dep = departements;
            return View();
        }
        public IActionResult DeleteDepartement(int id)
        {
            db.departements.Remove(db.departements.Find(id));
            db.SaveChanges();

            return RedirectToAction(controllerName:"Home",actionName: "DisplayFiliere") ;
        }
        //filiere
        public IActionResult AddFiliere()
        {
            var departements = db.departements.ToList();
            ViewBag.dep = departements;
            return View();
        }

        public IActionResult StoreFiliere(string nom, int departement)
        {
            var filiere = new Filiere { nom = nom, departementId = departement };
            db.Filieres.Add(filiere);
            db.SaveChanges();

            return RedirectToAction(actionName:"AddFiliere");
        }

        public IActionResult DisplayFiliere()
        {
            var filieres = db.Filieres.Include(f => f.departement).ToList();
            ViewBag.fil = filieres;
            return View();
        }
        public IActionResult DeleteFiliere(int id)
        {
            if (db.Filieres.Find(id) != null)
            {
                db.Filieres.Remove(db.Filieres.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction(controllerName: "Home",actionName:"DisplayFiliere");
        }

        //fonctions trombinoscope
        public JsonResult getProfByDep(int departementId)
        {
            List<Professeur> professeurs = db.Professeurs.Include(p => p.departement).Where(p => p.departementId == departementId).ToList();
            return Json(professeurs);
        }

        public JsonResult ProfEmails(int departementId)
        {
            var professeurs = db.Professeurs.Where(p => p.departementId == departementId);
            var emails = new List<String>();
            foreach (var e in professeurs)
            {
                emails.Add(e.email);
            }
            return Json(emails);
        }


        public IActionResult ActiveApps()
        {
            var etts = (from e in db.etats select e).ToList();
            ViewData["etts"] = etts;
            return View();
        }

        [HttpPost]
        public IActionResult ActiveApps(bool ee, bool i, bool ep, bool cdf)
        {
            var esp = (from p in db.etats where p.Id == 1 select p).SingleOrDefault();
            esp.etat = ee ? 1 : 0;

            esp = (from p in db.etats where p.Id == 2 select p).SingleOrDefault();
            esp.etat = i ? 1 : 0;

            esp = (from p in db.etats where p.Id == 3 select p).SingleOrDefault();
            esp.etat = ep ? 1 : 0;

            esp = (from p in db.etats where p.Id == 4 select p).SingleOrDefault();
            esp.etat = cdf ? 1 : 0;
            return RedirectToAction("ActiveApps","Home");
        }
    }
}
