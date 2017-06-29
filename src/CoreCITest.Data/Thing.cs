using System;

namespace CoreCITest.Data
{
    public class Thing
    {
        public Thing(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string GetFullName()
        {
            return $"{Id}-{Name}";
        }
    }
}
