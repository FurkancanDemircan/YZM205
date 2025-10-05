using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    public class Employee
    {
        private int _id = 0;
        private string _firstName;
        private string _lastName;
        private string _department;
        private DateTime _startDate;
        private float _salary;

        private Employee()
        {
            _salary = 0;
            _startDate = DateTime.Now;
        }

        public Employee(string firstName, string lastName, string department)
        : this()
        {
            _firstName = firstName;
            _lastName = lastName;
            _department = department;
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

        public void DisplayInfo() => Console.WriteLine($"{_id} {GetFullName()} {_department} {_salary} {_startDate.Date.ToShortDateString()}");
    }
}
