namespace Week8
{
    // Ayrı Package.cs dosyası olacak.
    public abstract class Package : ITrackable
    {
        private static int globalPackageId = 1;   // Auto-increment ID

        public int PackageId { get; private set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public double Weight { get; set; }

        private DeliveryStatus status;

        protected Package(string sender, string receiver, double weight)
        {
            PackageId = globalPackageId++;
            Sender = sender;
            Receiver = receiver;
            Weight = weight;
            status = DeliveryStatus.Processing;
        }

        public void UpdateStatus(DeliveryStatus newStatus)
        {
            status = newStatus;
        }

        public DeliveryStatus GetStatus()
        {
            return status;
        }

        public abstract double CalculateCost();
        public abstract void PrintInfo();
    }
}