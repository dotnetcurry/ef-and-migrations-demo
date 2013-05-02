using MVC40_Code_First_Attribute_Based.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC40_Code_First_Attribute_Based.Controllers
{
    public class DoctorsController : Controller
    {

        HMSContext objContext;

        public DoctorsController()
        {
            objContext = new HMSContext(); 
        }

        //
        // GET: /Doctors/

        public ActionResult Index()
        {
            var Doctors = objContext.Doctors.ToList();
            return View(Doctors);
        }

        public ActionResult Create()
        {
            Doctor doc = new Doctor();
            return View(doc);
        }

        [HttpPost]
        public ActionResult Create(Doctor d)
        {
            objContext.Doctors.Add(d);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
