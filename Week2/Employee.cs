public class Employee
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _department;
    private float _salary;
    private DateTime _startDate;
    private Company _company;

    private Employee()
    {
        _id += 1;
        _salary = 0;
        _startDate = DateTime.Now;
    }

    public Employee(string firstName, string lastName, string department, Company company)
        : this()
    {
        _firstName = firstName;
        _lastName = lastName;
        _department = department;
        _company = company;
    }

    public string GetFullName() => _firstName + " " + _lastName;

    public void SetSalary(float salary)
    {
        if (salary < 0)
        {
            _salary = 0;
            return;
        }
        _salary = salary;
    }

    public void DisplayInfo() => Console.WriteLine($"{_id} {GetFullName()} {_department} {_salary} {_startDate}");
}