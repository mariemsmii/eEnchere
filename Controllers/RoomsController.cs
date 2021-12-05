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
            List<Room> allRooms = _db.Rooms.Include(c => c.Article).ToList();
            return View(allRooms);
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ParticperALaRoom(Room obj)
        {
            if (ModelState.IsValid)
            {
                obj.NombreParticipants++;
                _db.Rooms.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Details");
            }
            return View(obj);


        }

        public ActionResult Details(int id)
        {
            var room = _db.Rooms.Find(id);
            if (room == null)
            {
                return NotFound();
            }
            Article article = _db.Articles.Find(room.IdArticle);

            return View(room);
        }

    }
}
