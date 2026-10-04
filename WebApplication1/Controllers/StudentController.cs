using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentModel stud = new StudentModel();
            stud.id = 1;
            stud.firstName = "Carl";
            stud.lastName = "Briones";
            stud.address = "Batasan";
            stud.contactNum = "09123456789";
            stud.dateofBirth = new DateOnly(2000, 01, 10);

            ViewData["KahitAnoBahalaKayo"] = "Welcome " + stud.firstName + "! Mabuhay ka hanggat gusto mo!";

            return View(stud);
        }

        public IActionResult StudentList()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel
            {
                id = 1,
                firstName = "Carl",
                lastName = "Briones",
                address = "Batasan",
                contactNum = "09123456789",
                dateofBirth = new DateOnly(2000, 01, 10)
            });
            students.Add(new StudentModel
            {
                id = 2,
                firstName = "Karl",
                lastName = "Buban",
                address = "",
                contactNum = "09123456789",
                dateofBirth = new DateOnly(2001, 10, 10)
            });

            students.Add(new StudentModel
            {
                id = 3,
                firstName = "Karl",
                lastName = "Buban",
                address = "",
                contactNum = "09123456799",
                dateofBirth = new DateOnly(2000, 01, 10)
            });


            StudentModel stud = new StudentModel();
            stud.id = 4;
            stud.firstName = "Carl";
            stud.lastName = "Briones";
            stud.address = "Batasan";
            stud.contactNum = "09123456789";
            stud.dateofBirth = new DateOnly(2000, 01, 10);

            students.Add(stud);

            return View(students);

        }
    }
}
