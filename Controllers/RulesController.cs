﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEnchere.Controllers
{
    public class RulesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
