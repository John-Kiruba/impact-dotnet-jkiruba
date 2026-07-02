//Task 1.5 Create namespace SchoolManagement with a Student class.
//Call it from Program.cs with and without the using directive.
//✓ Done when: both call styles compile and you've noted the difference in a comment.

using SchoolManagement;

class Program
{
    static void Main()
    {
        //Student s = new();
        //s.Name = "Alice";
        //s.Display();

        //1 : With using directive
        Student student1 = new() { Name = "Tim" };
        student1.Display();

        //2 : Without using directive
        SchoolManagement.Student student2 = new() { Name = "John" };
        student2.Display();
    }
}

//Comment:
//Namespaces can be inferred to utilize the class or other elements inside them.
//Without the using directive one can explicitly use the namespace path to access its attributes.

//Findings:
//warning CS8618: Non-nullable property 'Name' must contain a non-null value when exiting constructor.
//Consider adding the 'required' modifier or declaring the property as nullable.

//Since a string is mounted as a class property its non-nullable, meaning it is by default lacks certainity of value
//Hence, when an obj is created, the value for it is null before its assigned. ( Line: 12 - 13 ) that triggers the warnign.

//Solution Options:
//assign a required clause to the string;
//add a default empty string as value so its not null
//make the string nullable.
