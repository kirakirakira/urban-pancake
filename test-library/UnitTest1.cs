using System;
using Xunit;

namespace library
{
    public class UnitTest1
    {
        [Fact]
        public void TestThing()
        {
            Assert.Equal(42, new Thing().Get(19, 23));
        }
    }
}
