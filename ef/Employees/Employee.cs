namespace Employees
{
    class Employee
    {
        public int Id { get; private set;}
        public string Name {get; set;}
        public double Salary {get; private set;}

        public Employee(int id, string name, double salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Increase(double percentage)
        {
            Salary *= 1 + (percentage / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary:F2}";
        }
    }
}
