﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreCITest.Data;
using CoreCITest.Web.Services;
using Newtonsoft.Json;

namespace CoreCITest.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _context;

        public HomeController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DbTest()
        {
            var hello = _context.Users
                .Include(d => d.Posts)
                .SingleOrDefault(d => d.Id == 1);

            return View(hello?.Id ?? -5);
        }

        [Route("/api/users")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            List<User> allUsers = _context.Users
                .Include(u => u.Posts)
                .ToList();

            return Ok(allUsers);
        }

        [Route("/api/users")]
        [HttpPost]
        public IActionResult Create([FromBody]User user)
        {
            _context.Users.Add(user);

            _context.SaveChanges();

            return Ok(user.Id);
        }
    }
}
