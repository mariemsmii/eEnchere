using eEnchere.Data;
using eEnchere.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
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
                var i = 0;
                do
                {
                    if (username == allClients[i].Pseudo && password == allClients[i].MotDePasse)
                    {
                        identity = new ClaimsIdentity(new[]{
                            new Claim(ClaimTypes.Name,username),
                             new Claim(ClaimTypes.PrimarySid,"1"),
                            new Claim(ClaimTypes.Role,"User")
                            }, CookieAuthenticationDefaults.AuthenticationScheme);
                        isAuthenticate = true; break;
                    }
                    //else
                    //{
                    //    return RedirectToAction("Index", "Home");
                    //}


                    i++;


                } while (username == allClients[i].Pseudo && password == allClients[i].MotDePasse);


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

                    return RedirectToAction("Index", "Rooms");
                }
                

            }



            return View();

        }
    }
}
