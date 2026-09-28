using ComputerShop;

List<Customer> customers = new List<Customer>();

string input = Console.ReadLine();
while (input != "End")
{
    string[] parts = input.Split('/');
    string name = parts[0];
    string[] computerParts = parts[1].Split(',');
    Computer computer = new Computer(computerParts[0], computerParts[1], int.Parse(computerParts[2]));
    Customer customer = new Customer(name, computer);
    customers.Add(customer);
    input = Console.ReadLine();
}

string characteristic = Console.ReadLine();

Dictionary<string, int> videocards = new Dictionary<string, int>();
Dictionary<string, int> processors = new Dictionary<string, int>();
Dictionary<string, int> ssds = new Dictionary<string, int>();

foreach (var customer in customers)
{
    string videoCard = customer.Computer.Videocard;
    string processor = customer.Computer.Processor;
    string ssd = customer.Computer.SSD.ToString();

    if (!videocards.ContainsKey(videoCard))
    {
        videocards[videoCard] = 0;
    }
    videocards[videoCard]++;

    if (!processors.ContainsKey(processor))
    {
        processors[processor] = 0;
    }
    processors[processor]++;

    if (!ssds.ContainsKey(ssd))
    {
        ssds[ssd] = 0;
    }
    ssds[ssd]++;
}

Console.WriteLine($"Customers: {customers.Count}");
Console.WriteLine("-- Videocard:");
foreach (var vc in videocards)
{
    Console.WriteLine($"---- {vc.Key} => {vc.Value}");
}

Console.WriteLine("-- Processor:");
foreach (var pr in processors)
{
    Console.WriteLine($"---- {pr.Key} => {pr.Value}");
}

Console.WriteLine("-- SSD:");
foreach (var ssd in ssds)
{
    Console.WriteLine($"---- {ssd.Key} => {ssd.Value}");
}

Console.WriteLine($"Customers with {characteristic}:");
foreach (var customer in customers)
{
    if (customer.Computer.Videocard == characteristic ||
        customer.Computer.Processor == characteristic ||
        customer.Computer.SSD.ToString() == characteristic)
    {
        Console.WriteLine($"-- {customer.Name}");
    }
}