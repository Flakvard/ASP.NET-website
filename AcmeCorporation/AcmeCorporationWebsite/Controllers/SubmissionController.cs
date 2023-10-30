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
    }
}
