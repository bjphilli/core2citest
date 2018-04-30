using System.Collections.Generic;

namespace CoreCITest.Data
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Address BillingAddress { get; set; }
        public IReadOnlyList<Post> Posts { get; set; }
    }
}
