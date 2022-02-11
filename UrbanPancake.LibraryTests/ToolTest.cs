using System;
using System.Collections.Generic;
using Xunit;

namespace UrbanPancake.Library
{
    public class ToolTest
    {
        [Fact]
        public void HasAType()
        {
            Tool scissors = new Tool("sharp object");
            Assert.Equal("sharp object", scissors.Type);
        }

        [Fact]
        public void HasACondition()
        {
            Tool scissors = new Tool("sharp object", condition: "rusty");
            Assert.Equal("rusty", scissors.Condition);
        }
    }
}
