using Week_2;

Employee emp1 = new Employee("Ali", "Çoban", "Software");
emp1.SetSalary(100000);
Employee emp2 = new Employee(lastName: "Kojima", firstName: "Hideo", department: "Game Development");
emp2.SetSalary(75000);
Employee emp3 = new Employee(firstName: "Can", "Bora", "AI");
emp3.SetSalary(-150000);

emp1.DisplayInfo();
emp2.DisplayInfo();
emp3.DisplayInfo();
