using DataTable.Models;
using MessagePack.Formatters;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Schema;

namespace DataTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
 
        public IActionResult Index()
        {
            var Isım = HttpContext.Session.GetString("Isım");

            Users users = new Users();

            users.Name = Isım;

            List<Users> subjects = new List<Users>();


           

            int sehend = subjects.Count;

            int total = subjects.Count + 1;



            if (sehend == 0)
            {
                subjects.Insert(sehend, users);
            }
            else
            {
                subjects.Insert(total, users);
            }



         

             
            
            

            











            return View(subjects);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string txtIsım,string txtSoyad, string txtAddres,string txtEmail)
        {


          




            HttpContext.Session.SetString("Isım", txtIsım);


            return RedirectToAction("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}