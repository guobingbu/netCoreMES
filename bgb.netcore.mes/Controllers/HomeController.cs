﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace bgb.netcore.mes.MVC.Controllers
{
    public class HomeController : bgbmesControllerBase
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //throw new Exception("异常");
            return View();
        }
    }
}
