using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DarrylController : Controller
    {
        public IActionResult Index()
        {
            var profileData = new DarrylModel
            {
                Title = "Darryls Profile",
                LicenseNumber = "2024-01265-MN-0",
                StudentClass = "CLASS: BSCS 3-2",
                FullName = "MARC DARRYL SORIANO",
                Address = "123 MAIN STREET, LITTLEROOT TOWN",
                ContactNumber = "09760197488",
                Email = "sorianomarcdarryl@gmail.com",
                PhotoPath = "~/images/darryl-photo.jpg",
                Signature = "MSoriano",
                Credentials = new List<string>
                {
                    "PUP Sta. Mesa BS Computer Science(2024-present)",
                    "MaAnongUlam app Lead Developer(Taga-Approve ng Pull Requests)",
                    "Cy-Key Developer"
                },
                Github = "https://github.com/Dariiiiil"
            };

            return View("~/Views/Student/Darryl/Darryl.cshtml", profileData);
        }
    }
}