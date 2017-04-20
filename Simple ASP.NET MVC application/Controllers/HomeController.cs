
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        List<Footballer> footballerlist;
        public ActionResult Index()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\ITGigant\documents\visual studio 2013\Projects\WebApplication2\WebApplication2\App_Data\footballer.json", Encoding.Default);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            footballerlist = ser.Deserialize<List<Footballer>>(json);
            return View(footballerlist);
            
        }
     
    }
}