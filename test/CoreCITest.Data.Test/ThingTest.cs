using Xunit;

namespace CoreCITest.Data.Test
{
    public class ThingTest
    {
        [Fact]
        public void Thing_HasFullName()
        {
            var myThing = new Thing(1, "hello");
            var fullName = myThing.GetFullName();

            Assert.Equal("1-hello", fullName);
        }
    }
}
