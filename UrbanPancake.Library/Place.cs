namespace UrbanPancake.Library
{
    public class Place
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public Place(
            string name,
            string location,
            string phoneNumber
        )
        {
            Name = name;
            Location = location;
            PhoneNumber = phoneNumber;
        }
    }
}
