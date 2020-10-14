using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL.Model;
using Microsoft.Ajax.Utilities;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace DM_e_Commerce_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            HttpClient ht = new HttpClient();
            var response =   await ht.GetAsync("https://localhost:44335/api/categories/");
            var output = JsonConvert.DeserializeObject<List<Category>>(response.Content.ReadAsStringAsync().Result);

            return View(output);
        }
        public async Task<PartialViewResult> Partial1Async()
        {

            HttpClient ht = new HttpClient();
            var response = await ht.GetAsync("https://localhost:44335/api/categories/");
            var output = JsonConvert.DeserializeObject<List<Category>>(response.Content.ReadAsStringAsync().Result);
            return PartialView(output);
        }
    }

    
}