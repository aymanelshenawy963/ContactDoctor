using ContactDoctor.Data;
using ContactDoctor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactDoctor.Controllers
{
    public class DoctorController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookAppointment()
        {
            var doctors = dbContext.Doctors.ToList();
            return View(model: doctors);
        }

        public IActionResult CopmleteAppointment(int Id,string DoctorName)
        {        
            var doctor = new { Id = Id, Name = DoctorName };
            return View(model:doctor);
         
        }
        public IActionResult NotFoundPage()
        {
            return View();
        }
        public IActionResult SaveNew(Patient patiant)
        {
            dbContext.Patients.Add(patiant);
            dbContext.SaveChanges();
            return RedirectToAction("BookAppointment");
        }
        public IActionResult Display()
        {
            var patiant = dbContext.Patients.ToList();
            return View(model:patiant);
        }
    }
}
