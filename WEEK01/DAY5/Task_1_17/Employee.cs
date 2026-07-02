namespace Task_1_17
{
    public partial class Employee
    {
        public string Name { get; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        partial void OnSalaryChanged(decimal oldSalary, decimal newSalary);

        public void GiveRaise(decimal amount)
        {
            decimal oldSalary = Salary;
            Salary += amount;
            OnSalaryChanged(oldSalary, Salary);
        }
    }
}
