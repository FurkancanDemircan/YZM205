
namespace Week8
{
    public class ManageSystem
    {
        private List<Package> packages = new();

        public void AddPackage(Package p)
        {
            packages.Add(p);
            Console.WriteLine($"Package #{p.PackageId} added.");
        }

        public void UpdatePackageStatus(int id, DeliveryStatus status)
        {
            foreach (var p in packages)
            {
                if (p.PackageId == id)
                {
                    p.UpdateStatus(status);
                    Console.WriteLine($"Package #{id} status updated to {status}");
                    return;
                }
            }
            Console.WriteLine("Package not found.");
        }

        public void ShowAll()
        {
            Console.WriteLine("\n--- Package List ---");
            foreach (var p in packages)
                p.PrintInfo();
        }
    }
}