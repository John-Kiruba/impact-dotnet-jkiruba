namespace Task_1_17
{
    public partial class Employee
    {
        partial void OnSalaryChanged(decimal oldSalary, decimal newSalary)
        {
            Console.WriteLine($"[Notify] {Name}'s salary changed: {oldSalary:C} -> {newSalary:C}");
        }
    }
}
