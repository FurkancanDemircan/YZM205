namespace Week8
{
    public class StandartPackage : Package
    {
        public StandartPackage(string sender, string receiver, double weight)
            : base(sender, receiver, weight) { }

        public override double CalculateCost()
        {
            return Weight * 1.2; // basic cost example
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"[STANDARD] Package #{PackageId}");
            Console.WriteLine($"Sender: {Sender}");
            Console.WriteLine($"Receiver: {Receiver}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Cost: {CalculateCost():0.00}₺");
            Console.WriteLine($"Status: {GetStatus()}");
            Console.WriteLine("---------------------------");
        }
    }
}