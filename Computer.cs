namespace ComputerShop
{
    public class Computer
    {
        public string Videocard { get; set; }
        public string Processor { get; set; }
        public int SSD { get; set; }

        public Computer(string videocard, string processor, int ssd)
        {
            Videocard = videocard;
            Processor = processor;
            SSD = ssd;
        }
    }
}