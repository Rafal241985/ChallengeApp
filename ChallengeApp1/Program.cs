using ChallengeApp1;

Employee employee1 = new Employee("Rafał", "Małkiewicz", "37");
Employee employee2 = new Employee("Paweł", "Kowalski", "45");
Employee employee3 = new Employee("Bartek", "Wrona", "25");

employee1.AddPoints(4);
employee1.AddPoints(4);
employee1.AddPoints(4);
employee1.AddPoints(4);

employee2.AddPoints(5);
employee2.AddPoints(5);
employee2.AddPoints(5);
employee2.AddPoints(5);

employee3.AddPoints(3);
employee3.AddPoints(3);
employee3.AddPoints(3);
employee3.AddPoints(3);

int maxPoints = -1;
Employee employeeWithMaxResult = null;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

foreach (var employee in employees)
{
    if(employee.Points > maxPoints)
    {
        maxPoints= employee.Points;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine($"Najlepszym pracownikiem został: {employeeWithMaxResult.name} {employeeWithMaxResult.surname}" + $" otrzymał {employeeWithMaxResult.Points} punkty");