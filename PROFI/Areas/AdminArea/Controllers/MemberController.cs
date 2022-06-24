using Microsoft.AspNetCore.Mvc;
using PROFI.DAL;
using PROFI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROFI.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class MemberController : Controller
    {
        private AppDbContext _context { get; }
        public MemberController(AppDbContext context)
        {
            _context = context;
       
        }

        public IActionResult Index()
        {
            return View(_context.Members.Where(m => !m.IsDeleted).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member members)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            await _context.Members.AddAsync(members);
            return RedirectToAction(nameof(Index));
        }
    }
}
