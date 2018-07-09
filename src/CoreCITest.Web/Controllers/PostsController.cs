using System.Linq;
using CoreCITest.Data;
using CoreCITest.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreCITest.Web
{
    [Route("/api/posts")]
    public class  PostsController : Controller
    {
        private readonly BlogContext _context;

        public PostsController(BlogContext context)
        {
            _context = context;
        }

        [Route("{userId:int}")]
        [HttpPost]
        public IActionResult AddPost(int userId, [FromBody]Post post)
        {
            var user = _context
                .Users
                .Include(u => u.Posts)
                .Single(u => u.Id == userId);

            user.AddPost(post);

            _context.SaveChanges();

            return Ok(user);
        }

        [Route("{userId:int}/{postId:int}")]
        [HttpDelete]
        public IActionResult DeletePost(int userId, int postId)
        {
            var user = _context
                .Users
                .Include(u => u.Posts)
                .Single(u => u.Id == userId);

            user.DeletePost(postId);

            _context.SaveChanges();

            return Ok(user);
        }
    }
}
