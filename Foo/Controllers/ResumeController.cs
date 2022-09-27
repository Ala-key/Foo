using Foo.Data;
using Foo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foo.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;

        public ResumeController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Applicant> applicants;

            applicants = _context.Applicants.ToList();

            return View(applicants);

        }
    }
}
