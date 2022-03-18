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
        public void HasALocationFound()
        {
            Place bank = new Place("First National Bank", "156 Short Street", "555-111-1111");
            Tool scissors = new Tool("sharp object", condition: "rusty", locationFound: bank);
            Assert.Equal(bank, scissors.LocationFound);
        }

        [Fact]
        public void HasADateFound()
        {
            DateTime date1 = new DateTime(2022, 2, 13, 6, 45, 12);
            Tool scissors = new Tool("sharp object", condition: "rusty", dateFound: date1);
            Assert.Equal(date1, scissors.DateFound);
        }

        [Fact]
        public void HasACondition()
        {
            Tool scissors = new Tool("sharp object", condition: "rusty");
            Assert.Equal("rusty", scissors.Condition);
        }

        [Fact]
        public void HasDetails()
        {
            Tool scissors = new Tool("sharp object", details: "purple handle, nick on one blade");
            Assert.Equal("purple handle, nick on one blade", scissors.Details);
        }

        [Fact]
        public void PrintsSummaryWhenToStringCalledWithoutConditionLocationFoundOrDateFound()
        {
            Tool scissors = new Tool("sharp object", details: "purple handle, nick on one blade");
            Assert.Equal("type: sharp object\ncondition: Unknown\ndetails: purple handle, nick on one blade\nfound at: Unknown\ndate found: Unknown\n", scissors.ToString());
        }

        [Fact]
        public void PrintsSummaryWhenToStringCalledWithoutDetails()
        {
            Tool scissors = new Tool("sharp object");
            Assert.Equal("type: sharp object\ncondition: Unknown\ndetails: Unknown\nfound at: Unknown\ndate found: Unknown\n", scissors.ToString());
        }
    }
}
