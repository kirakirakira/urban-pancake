using Xunit;

namespace UrbanPancake.Library
{
    public class ViewPeopleTest
    {
        [Fact]
        public void HasAChoice()
        {
            ViewPeople viewPeople = new ViewPeople("View people");
            Assert.Equal("View people", viewPeople.Choice);
        }
    }
}
