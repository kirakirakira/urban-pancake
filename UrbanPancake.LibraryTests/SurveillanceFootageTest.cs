using System;
using System.Collections.Generic;
using Xunit;

namespace UrbanPancake.Library
{
    public class SurveillanceFootageTest
    {
        [Fact]
        public void HasADuration()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            TimeSpan duration = new TimeSpan(2, 14, 18);
            DateTime timestamp = new DateTime(2022, 2, 14, 12, 45, 12);
            Person author = new Person("Jacky", "Bubbles");

            SurveillanceFootage video = new SurveillanceFootage(duration, donutShop, timestamp, author);
            Assert.Equal(duration, video.Duration);
        }

        [Fact]
        public void HasALocation()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            TimeSpan duration = new TimeSpan(2, 14, 18);
            DateTime timestamp = new DateTime(2022, 2, 14, 12, 45, 12);
            Person author = new Person("Jacky", "Bubbles");

            SurveillanceFootage video = new SurveillanceFootage(duration, donutShop, timestamp, author);
            Assert.Equal(donutShop, video.Location);
        }

        [Fact]
        public void HasATimestamp()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            TimeSpan duration = new TimeSpan(2, 14, 18);
            DateTime timestamp = new DateTime(2022, 2, 14, 12, 45, 12);
            Person author = new Person("Jacky", "Bubbles");

            SurveillanceFootage video = new SurveillanceFootage(duration, donutShop, timestamp, author);
            Assert.Equal(timestamp, video.Timestamp);
        }

        [Fact]
        public void HasAnAuthor()
        {
            Place donutShop = new Place("Urban Pancake Donut Shop", "1234 East Main Street", "555-123-4567");
            TimeSpan duration = new TimeSpan(2, 14, 18);
            DateTime timestamp = new DateTime(2022, 2, 14, 12, 45, 12);
            Person author = new Person("Jacky", "Bubbles");

            SurveillanceFootage video = new SurveillanceFootage(duration, donutShop, timestamp, author);
            Assert.Equal(author, video.Author);
        }
    }
}
