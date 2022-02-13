using System;
using System.Collections.Generic;
using Xunit;

namespace UrbanPancake.Library
{
    public class SurveillanceFootageTest
    {
        private static Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
        private static TimeSpan duration = new TimeSpan(2, 14, 18);
        private static DateTime timestamp = new DateTime(2022, 2, 14, 12, 45, 12);
        private static Person author = new Person("Jacky", "Bubbles");
        private static SurveillanceFootage video = new SurveillanceFootage(duration, donutShop, timestamp, author);

        [Fact]
        public void HasADuration()
        {
            Assert.Equal(duration, video.Duration);
        }

        [Fact]
        public void HasALocation()
        {
            Assert.Equal(donutShop, video.Location);
        }

        [Fact]
        public void HasATimestamp()
        {
            Assert.Equal(timestamp, video.Timestamp);
        }

        [Fact]
        public void HasAnAuthor()
        {
            Assert.Equal(author, video.Author);
        }
    }
}
