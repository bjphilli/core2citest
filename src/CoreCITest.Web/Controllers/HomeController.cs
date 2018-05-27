using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreCITest.Data;
using CoreCITest.Web.Services;

namespace CoreCITest.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoreContext _db;

        public HomeController(CoreContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DbTest()
        {
            var hello = _db.Users
                // .Include(d => d.Posts)
                .SingleOrDefault(d => d.Id == "1");

            return View();
        }

        public IActionResult CreatePosts()
        {
            var user = _db.Users
                // .Include(d => d.Posts)
                .Single(d => d.Id == "1");

            // user.Posts.Remove(user.Posts.First());

            _db.SaveChanges();

            return Ok(user);
        }
    }
}
