// Task 1.16 Student class: validated properties (age 5–100), parameterized
// + chained constructor (: this(...)), overloaded CalculateGrade().
//  Add const vs readonly fields and show which can't change where.
// ✓ Done when: validation rejects an out-of-range age and constructor chaining works

class Student
{
    // const field
    public const string CollegeName = "ABC College";

    // readonly field
    public readonly DateTime AdmissionDate;

    private int age;

    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 5 && value <= 100)
                age = value;
            else
                throw new ArgumentException("Age must be between 5 and 100.");
        }
    }

    // Default constructor
    public Student()
    {
        AdmissionDate = DateTime.Now;
    }

    // Parameterized constructor with chaining
    public Student(string name, int age)
        : this()
    {
        Name = name;
        Age = age;
    }

    // Overloaded methods
    public string CalculateGrade(int marks)
    {
        return marks >= 50 ? "Pass" : "Fail";
    }

    public string CalculateGrade(int marks, int bonus)
    {
        return CalculateGrade(marks + bonus);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Alice", 20);

        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("College: " + Student.CollegeName);
        Console.WriteLine("Admission Date: " + student.AdmissionDate);

        Console.WriteLine();

        Console.WriteLine("Grade: " + student.CalculateGrade(45));
        Console.WriteLine("Grade with Bonus: " + student.CalculateGrade(45, 10));

        Console.WriteLine();

        try
        {
            Student s2 = new Student("Bob", 120);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Validation Error: " + ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Const field (CollegeName) cannot be changed anywhere.");
        Console.WriteLine(
            "Readonly field (AdmissionDate) can only be assigned in the constructor."
        );

        // These statements would cause compile-time errors:
        // Student.CollegeName = "XYZ College";
        // student.AdmissionDate = DateTime.Now;
    }
}
