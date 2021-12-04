using eEnchere.Data;
using eEnchere.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Controllers
{
    public class ArticleController : Controller
    {

        private readonly AppDbContext _db;
        public ArticleController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Article> objlist = _db.Articles;
            return View(objlist);
        }

        
        //Post Articles
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateArticle(Article obj)
        {

            _db.Articles.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Get Delete 

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Articles.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        // Delete 
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var obj = _db.Articles.Find(id);
            if (obj == null)
            {
                return NotFound();
            };
            _db.Articles.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Get Update 
        public IActionResult Update(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Articles.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Update 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateArticle(Article obj)
        {

            _db.Articles.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
