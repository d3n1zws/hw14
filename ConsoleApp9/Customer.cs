namespace ConsoleApp9
{
    internal class Customer
    {
        public Customer(string id, string name, string cityName)
        {
            Id = id;
            Name = name;
            CityName = cityName;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
    }
}
