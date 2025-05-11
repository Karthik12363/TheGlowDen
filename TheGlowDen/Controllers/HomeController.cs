using Microsoft.AspNetCore.Mvc;
using TheGlowDen.Models;
using System.Collections.Generic;

namespace TheGlowDen.Controllers
{
    public class HomeController : Controller
    {
        // Home page
        public IActionResult Index()
        {
            ViewData["Active"] = "Home";  // Set 'Home' as the active link
            return View();
        }

        // Repeat for other actions...


        // Services page
        public IActionResult Services()
        {
            ViewData["Active"] = "Services";  // Set 'Service' as the active link

            var services = new List<ServiceModel>
            {
                new ServiceModel { Name = "Haircut", Description = "Stylish haircuts for men and women", Price = 50.00M },
                new ServiceModel { Name = "Facial", Description = "Glow-enhancing facial treatments", Price = 80.00M },
                new ServiceModel { Name = "Massage", Description = "Relaxing full-body massage", Price = 70.00M }
            };

            return View(services);
        }
    }
}
