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

        //get update
        public IActionResult ParticperALaRoom(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Rooms.Find(Id);
            if (obj == null) { return NotFound(); }
            //Room room= _db.Rooms.Find(obj.IdRoom);
            return View(obj);



        }
        // post update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ParticperALaRoom(int Id , int idClt)
        {
            idClt = 2 ;
            
            var obj = _db.Rooms.Find(Id);
            Client_Room cltRoom = new Client_Room() ;
            cltRoom.IdClient = idClt;
            cltRoom.IdRoom = Id ;
            
            
            if (ModelState.IsValid)
            {
                obj.NombreParticipants++;
                _db.Rooms.Update(obj);
                _db.Client_Rooms.Add(cltRoom);
                _db.SaveChanges();
            }
            return View(obj);


        }
    }
}
