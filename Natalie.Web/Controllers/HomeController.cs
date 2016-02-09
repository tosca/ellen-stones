using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {

       public ActionResult Index()
        {
            return View();
       }
    
       public ActionResult Scribbles()
        {
           return View();
        }
        public ActionResult KidsRings()
        {

            return View();
        }
        
        public ActionResult PiercingPieces()
        {

            return View();
        }
        public ActionResult NewWork()
        {

            return View();
        }
        public ActionResult ResinBalls()
        {

            return View();
        }
        public ActionResult RoachStudy()
        {

            return View();
        }
        public ActionResult Bump()
        {

            return View();
        }
        public ActionResult Brood()
        {

            return View();
        }
        public ActionResult Bulge()
        {

            return View();
        }
        public ActionResult BoilingOver()
        {

            return View();
        }
        public ActionResult Crack()
        {

            return View();
        }
        public ActionResult Shifting()
        {

            return View();
        }
        public ActionResult Occupancy()
        {

            return View();
        }

        public ActionResult Combat()
        {

            return View();
        }

        public ActionResult Phenomenon()
        {

            return View();
        }

        public ActionResult MetalPods()
        {

            return View();
        }
        
        public ActionResult About()
        {

            return View();
        }
        public ActionResult TheMotherLoadProject()
        {

            return View();
        }
        public ActionResult Wannabe()
        {

            return View();
        }
        public ActionResult PetiteShow()
        {

            return View();
        }
        public ActionResult TheMerger()
        {

            return View();
        }
        public ActionResult TrestleDesigns()
        {

            return View();
        }


      
 
       
    [HttpGet]
        public ActionResult Contact()
        { 
            ViewBag.Message = "Your contact page.";
            
            return View();
        }
       

        public ActionResult ContactSubmited()
        {

            var result = new FilePathResult("~/Views/Home/Index.html", "text/html");
            return result;

        }

         

    }

     
    
}
