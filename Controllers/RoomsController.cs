using eEnchere.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Controllers
{
    public class RoomsController : Controller
    { 
        private readonly AppDbContext _context;
    public RoomsController ( AppDbContext context)
    {
        context = _context;
    }
   
        public async Task <IActionResult> Index()
        {
            var allRooms = await _context.Rooms.ToListAsync();
            return View(allRooms);
            
        }
    }
}
