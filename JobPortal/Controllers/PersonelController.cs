using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortal.Models;
using JobPortal.Data;

namespace JobPortal.Controllers
{    
    public class PersonelController : Controller
    {
        private readonly JobPortalContext _context;
        public PersonelController(JobPortalContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Personel> personels = _context.Personel.ToList();
            return View(personels);
        }
    }
}
