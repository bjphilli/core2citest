using System.Collections.Generic;

namespace CoreCITest.Data
{
    public class Hello
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public IReadOnlyList<Post> Posts { get; set; }
    }
}
