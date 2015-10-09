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
            
            return View(new ContactInfo());
        }
        [HttpPost]
        public ActionResult Contact(ContactInfo contact)
        {

            var fullName = contact.FullName;
            var contactEmail = contact.ContactEmail;
            var contactPhone = contact.ContactPhone;
            var contactMessage = contact.ContactMessage;
          SendEmail(fullName, contactEmail, contactPhone, contactMessage);
            return RedirectToAction("Index");
        }

        public ActionResult ContactSubmited()
        {

            var result = new FilePathResult("~/Views/Home/Index.html", "text/html");
            return result;

        }


        public void SendEmail(string fullName, string contactEmail, string contactPhone, string contactMessage)
        {
            string mailgunKey = System.Configuration.ConfigurationManager.AppSettings["MAILGUN_API_KEY"];
            if (String.IsNullOrEmpty(mailgunKey))
            {
                throw new Exception("Mailgun api key missing");
            }
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                    new HttpBasicAuthenticator("api",
                                               mailgunKey);

            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                 System.Configuration.ConfigurationManager.AppSettings["MAILGUN_DOMAIN"], 
                                 ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Natalie Macellaio - inquiry <mailgun@mailgun.org>");
            request.AddParameter("to", "tosca.ragnini@gmail.com, nataliemacellaio@gmail.com");
            request.AddParameter("subject", "Natalie Macellaio - Contact Request");
            request.AddParameter("text", "FullName : " + fullName);
            request.AddParameter("text", "ContactEmail : " + contactEmail);
            request.AddParameter("text", "ContactPhone : " + contactPhone);
            request.AddParameter("text", "ContactMessage : " + contactMessage);
            request.Method = Method.POST;
            var result = client.Execute(request);
            return;
        }


    }


    public class ContactInfo
    {
        public string FullName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMessage { get; set; }

    }  
    
}
