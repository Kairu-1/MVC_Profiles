using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ProfileModel info = new ProfileModel(); 
            info.firstName = "Kyle";
            info.lastName = "Calixto";
            info.sex = "M";
            info.size = "Medium";
            info.weight = "143lbs";
            info.eyes = "Two";
            info.issueDate = new DateOnly(2024, 03, 29);
            info.licenseNum = "N3V43R3XP1RE";
            info.expiration = "never";
            info.address = "69 OLD PLUMLEE BLVD SPRINGFIELD, IL 622701";

            ViewData["anything daw"] = "Welcome " + info.firstName + "! Presenting: Driver's License.";

            return View(info);
        }



    }
}
