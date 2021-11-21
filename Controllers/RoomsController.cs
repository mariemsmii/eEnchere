using eEnchere.Data;
using eEnchere.Models;
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
        private readonly AppDbContext _db;
    public RoomsController ( AppDbContext db )
    {
            _db = db;
    }
   
        public IActionResult Index()
        {
            IEnumerable<Room> allRooms = _db.Rooms;
            return View(allRooms);
            
        }
    }
}
