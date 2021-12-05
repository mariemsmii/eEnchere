using eEnchere.Data;
using eEnchere.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eEnchere.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        
        public AccountController(AppDbContext db)
        {
            _db = db;
           
        }
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        //login
        [HttpPost]
        public IActionResult Login(string username,string password )
        {
            List<Client> allClients = _db.Clients.ToList();



            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            if (username == "admin" && password == "admin")
            {
                identity = new ClaimsIdentity(new[]{
                    new Claim(ClaimTypes.Name,username),
                     new Claim(ClaimTypes.PrimarySid,"1"),
                    new Claim(ClaimTypes.Role,"Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
           
            else
                {

                foreach (Client element in allClients)
                {
                    if (username == element.Pseudo && password == element.MotDePasse)
                    {
                        identity = new ClaimsIdentity(new[]{
                            new Claim(ClaimTypes.Name,username),
                             new Claim(ClaimTypes.PrimarySid,"1"),
                            new Claim(ClaimTypes.Role,"User")
                            }, CookieAuthenticationDefaults.AuthenticationScheme);
                        isAuthenticate = true;
                        TempData["id"] = element.IdClient;
                        HttpContext.Session.SetString("username", username);
                        break;
                    }
                  
                }


            }
           
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                if (username == "admin" && password == "admin")
                {
                    return RedirectToAction("Index", "Home");
                }
                else  
                {
                    TempData["data"] = username;
                    
                    return RedirectToAction("Index", "Rooms");
                }
                

            }
            


            return View();

        }
        // Get Register
        public IActionResult Register()
        {
            return View();
        }
        // post create Client
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(obj);
        }
        //Logout
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            TempData["data"] = null;
            return View();
        }
    }
}
