using System;
using System.Collections.Generic;

namespace Week8
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ManageSystem system = new ManageSystem();

            Console.WriteLine("=== PACKAGE DELIVERY SYSTEM ===");

            // Create packages
            StandartPackage p1 = new StandartPackage("Ali", "Ayşe", 2.5);
            ExpressPackage p2 = new ExpressPackage("Mehmet", "Zeynep", 1.2);

            // Add packages to system
            system.AddPackage(p1);
            system.AddPackage(p2);

            // Show initial state
            Console.WriteLine("\n--- Initial Package List ---");
            system.ShowAll();

            // Update status
            Console.WriteLine("\nUpdating Status for Package #1...");
            system.UpdatePackageStatus(1, DeliveryStatus.InTransit);

            Console.WriteLine("Updating Status for Package #2...");
            system.UpdatePackageStatus(2, DeliveryStatus.OutForDelivery);

            // Show final state
            Console.WriteLine("\n--- Updated Package List ---");
            system.ShowAll();

            Console.WriteLine("\n=== END ===");
        }
    }
}