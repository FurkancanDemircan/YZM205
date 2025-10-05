public partial class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee("Ali", "Çoban", "Software", new Company(0, "A"));
        emp1.SetSalary(100000);
        Employee emp2 = new Employee("Hideo", "Kojima", "Game Development", new Company(1, "B"));
        emp2.SetSalary(70000);
        Employee emp3 = new Employee("Can", "Bora", "AI", new Company(2, "C"));
        emp3.SetSalary(-100000);

        emp1.DisplayInfo();
        emp2.DisplayInfo();
        emp3.DisplayInfo();
    }
}