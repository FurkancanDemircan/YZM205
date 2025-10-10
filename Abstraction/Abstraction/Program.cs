using Abstraction;

Cars car1 = new Cars();
car1.Manufacturer = "BMW";
car1.Year = new DateTime(2025, 12, 12);
car1.Color = "blue";
car1.Model = "M3";
car1.Price = 45000;

car1.DisplayInfo();

Cars car2 = car1;
car2.Color = "red";
car2.Price = 150000;

car2.DisplayInfo();
car1.DisplayInfo();