﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BT_HVT_MVC_01.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BT_HVT_MVC_01.Controllers
{
    public class RegisterController : Controller
    {
        private IHostingEnvironment hosting;

        public RegisterController(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy(Person p, IFormFile FHinh)
        {
            if (FHinh != null)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                string path = Path.Combine(hosting.WebRootPath + "/img");
                using (var filestream = new FileStream(Path.Combine(path, filename), Filename.Create)
                {
                    FHinh.CopyTo(filestream);
              }
            return View();
        }
        }
           
  }
  }
       
    
    

