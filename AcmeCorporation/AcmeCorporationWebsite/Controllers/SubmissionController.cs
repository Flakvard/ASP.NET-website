using AcmeCorporationLibrary.Data;
using AcmeCorporationLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCorporationWebsite.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SubmissionController(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public IActionResult Index()
        {
            IEnumerable<SubmissionModel> objSubmission = _db.Submission;
            return View(objSubmission);
        }

        // Get
        public IActionResult SubmitForm()
        {
            return View();
        }
        // Post
        [HttpPost]
        [ValidateAntiForgeryToken] // Prevent cross-site request forgery
        public IActionResult SubmitForm(SubmissionModel obj)
        {
            // TODO: add custom validation for product serial number
            if (obj.ProductSerialNumber == "123")
            {
                ModelState.AddModelError("ProductSerialNumber", "The Product serial number is invalid");
            }
            if (ModelState.IsValid)
            {
                _db.Submission.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

    }
}
