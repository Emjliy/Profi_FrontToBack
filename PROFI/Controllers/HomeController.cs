using Microsoft.AspNetCore.Mvc;
using PROFI.DAL;
using PROFI.Models;
using PROFI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROFI.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public List<Member> Members  { get; set; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Members = _context.Members.Where(m => !m.IsDeleted).ToList()
            };
            return View(home);
        }
    }
}
