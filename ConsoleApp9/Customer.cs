namespace ConsoleApp9
{
    public class Customer
    {
        public Customer(string name, string cityName)
        {
            Id = ++id;
            Name = name;
            CityName = cityName;
        }
        private static int id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string CityName { get; set; }
    }
}
