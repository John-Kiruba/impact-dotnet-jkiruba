// Task 1.14 GetMinMax(int[]) returns named (int Min, int Max);
// an employee lookup returns (Name, Age, Department) consumed by deconstruction.
// ✓ Done when: both tuples are returned and deconstructed into separate variables.

class Program
{
    static void Main(string[] args)
    {
        // Min and Max
        var (min, max) = GetMinMax(new int[] { 12, 45, 7, 30, 18 });

        Console.WriteLine("Minimum = " + min);
        Console.WriteLine("Maximum = " + max);

        Console.WriteLine();

        // Employee tuple deconstruction
        var (name, age, department) = GetEmployee();

        Console.WriteLine("Employee Details");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + department);
    }

    static (int Min, int Max) GetMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
                min = number;

            if (number > max)
                max = number;
        }

        return (min, max);
    }

    static (string Name, int Age, string Department) GetEmployee()
    {
        return ("John", 30, "IT");
    }
}
