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
            Receipt receipt1 = new Receipt(donuts, "23.46");
            Assert.Equal("23.46", receipt1.TotalAmount);
        }

        [Fact]
        public void HasItemsPurchased()
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46");
            Assert.Equal(donuts, receipt1.ItemsPurchased);
        }

        [Fact]
        public void HasALocationFound()
        {
            Place bank = new Place("First National Bank", "156 Short Street", "555-111-1111");
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46", locationFound: bank);
            Assert.Equal(bank, receipt1.LocationFound);
        }

        [Fact]
        public void HasADateFound()
        {
            DateTime date1 = new DateTime(2022, 2, 13, 6, 45, 12);
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46", dateFound: date1);
            Assert.Equal(date1, receipt1.DateFound);
        }

        [Fact]
        public void HasACondition()
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46", condition: "crumpled");
            Assert.Equal("crumpled", receipt1.Condition);
        }

        [Fact]
        public void HasDetails()
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46", details: "smiley face drawn on the back");
            Assert.Equal("smiley face drawn on the back", receipt1.Details);
        }

        [Fact]
        public void PrintsSummaryWhenToStringCalledWithoutConditionLocationFoundOrDateFound()
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46", details: "smiley face drawn on the back");
            Assert.Equal("Items purchased: chocolate donut: 3, glazed donut: 2, total: 23.46, condition: Unknown, details: smiley face drawn on the back, found at: Unknown, date found: Unknown", receipt1.ToString());
        }

        [Fact]
        public void PrintsSummaryWhenToStringCalledWithoutDetails()
        {
            Dictionary<string, int> donuts = new Dictionary<string, int>()
            {
                {"chocolate donut", 3},
                {"glazed donut", 2}
            };
            Receipt receipt1 = new Receipt(donuts, "23.46");
            Assert.Equal("Items purchased: chocolate donut: 3, glazed donut: 2, total: 23.46, condition: Unknown, details: Unknown, found at: Unknown, date found: Unknown", receipt1.ToString());

        }
    }
}
