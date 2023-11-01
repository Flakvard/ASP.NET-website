using AcmeCorporationLibrary.Business;
using AcmeCorporationLibrary.Data;
using AcmeCorporationLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcmeCorporationWebsite.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly IApplicationDbContext _db;
        private readonly IDrawManager _drawManager;

        public SubmissionController(IApplicationDbContext db, IDrawManager drawManager)
        {
            _db = db;
            _drawManager = drawManager;
        }

        public IActionResult Index()
        {
            return View();
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
            // Serverside validation
            if (string.IsNullOrEmpty(obj.FirstName))
            {
                ModelState.AddModelError("FirstName", "First name is required");
            }
            if (string.IsNullOrEmpty(obj.LastName))
            {
                ModelState.AddModelError("LastName", "Last name is required");
            }
            if (string.IsNullOrEmpty(obj.Email))
            {
                ModelState.AddModelError("Email", "Email address is required");
            }

            // Validation for product serial number
            
            if (!_drawManager.CheckAndUpdateSerialNumber(obj.ProductSerialNumber))
            {
                ModelState.AddModelError("ProductSerialNumber", "The Product serial number is invalid");
            }
            if (ModelState.IsValid)
            {
                _db.Submission.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Form was submitted successfully";
                return RedirectToAction("Index","Home");
            }
            return View(obj);
        }
        // AJAX get submissions
        [HttpGet]
        public async Task<IActionResult> GetSubmissions(int page = 1, int pageSize = 10)
        {
            var query = _db.Submission.AsQueryable();
            var totalCount = await query.CountAsync();

            var submissions = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Json(new { Submissions = submissions, TotalCount = totalCount });
        }

    }
}
