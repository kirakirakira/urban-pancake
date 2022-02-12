using System;
using System.Collections.Generic;
using Xunit;

namespace UrbanPancake.Library
{
    public class PlaceTest
    {
        [Fact]
        public void HasAName()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            Assert.Equal("Urban Pancake Donut Shop", donutShop.Name);
        }

        [Fact]
        public void HasALocation()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            Assert.Equal("1234 East Main Street", donutShop.Location);
        }

        [Fact]
        public void HasAPhoneNumber()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            Assert.Equal("555-123-4567", donutShop.PhoneNumber);
        }
    }
}
