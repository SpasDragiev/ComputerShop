namespace ComputerShop
{
    public class Customer
    {
        public string Name { get; set; }
        public Computer Computer { get; set; }

        public Customer(string name, Computer computer)
        {
            Name = name;
            Computer = computer;
        }
    }
}