namespace Week8
{
    // Ayrı ExpressPackage.cs dosyası olacak.
    public class ExpressPackage : Package
    {
        public ExpressPackage(string sender, string receiver, double weight)
            : base(sender, receiver, weight) { }

        public override double CalculateCost()
        {
            return (Weight * 2.5) + 15;  // express surcharge
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"[EXPRESS] Package #{PackageId}");
            Console.WriteLine($"Sender: {Sender}");
            Console.WriteLine($"Receiver: {Receiver}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Cost: {CalculateCost():0.00}₺");
            Console.WriteLine($"Status: {GetStatus()}");
            Console.WriteLine("---------------------------");
        }
    }
}