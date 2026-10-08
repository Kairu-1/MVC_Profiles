using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var ProfileModel = new CarlProfile
            {
                Fullname = "Carl Gabriel B. Briones",
                Address = "52 Masikap Street, Barangay Pinyahan, Quezon City",
                ContactNumber = "09981891975",
                DateOfBirth = new DateTime(2004, 12, 31)
            };
            return View(ProfileModel);
        }
    }
}
