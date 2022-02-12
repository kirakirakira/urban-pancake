using System;
using System.Collections.Generic;
using Xunit;

namespace UrbanPancake.Library
{
    public class ReceiptTest
    {
        [Fact]
        public void HasATotalAmount()
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(23.46m, donuts);
            Assert.Equal(23.46m, receipt1.TotalAmount);
        }

        [Fact]
        public void HasDonutsPurchased() // items purchased
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(23.46m, donuts);
            Assert.Equal(donuts, receipt1.ItemsPurchased);
        }

        [Fact]
        public void HasALocationFound()
        {

        }

        [Fact]
        public void HasADateFound()
        {
        }

        [Fact]
        public void HasACondition()
        {
        }

        [Fact]
        public void HasDetails()
        {
        }

        [Fact]
        public void PrintsSummaryWhenToStringCalledWithoutConditionLocationFoundOrDateFound()
        {
        }

        [Fact]
        public void PrintsSummaryWhenToStringCalledWithoutDetails()
        {
        }
    }
}
