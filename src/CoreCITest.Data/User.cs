using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreCITest.Data
{
    public class User
    {
        public User() { }

        public long Id { get; set; }
        public string Name { get; set; }
        public Address BillingAddress { get; set; }
        public IList<Post> Posts { get; set; }

        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

        public void DeletePost(int postId)
        {
            var post = Posts.SingleOrDefault(p => p.Id == postId);

            if (post == null)
                return;

            Posts.Remove(post);
        }
    }
}
