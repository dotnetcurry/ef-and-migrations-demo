using MVC40_Code_First_Attribute_Based.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC40_Code_First_Attribute_Based.Controllers
{
    public class PatientsController : Controller
    {
        
        HMSContext objContext;

        public PatientsController()
        {
            objContext = new HMSContext(); 
        }

        //
        // GET: /Patiemts/

        public ActionResult Index()
        {
            var Patients = objContext.Patients.ToList();
            return View(Patients);
        }

        public ActionResult Create()
        {
            var pat = new Patient();
            return View(pat);
        }

        [HttpPost]
        public ActionResult Create(Patient p)
        {
            objContext.Patients.Add(p);
            objContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
