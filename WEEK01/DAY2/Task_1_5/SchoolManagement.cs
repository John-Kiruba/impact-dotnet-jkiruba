namespace SchoolManagement
{
    public class Student
    {
        public required string Name { get; set; }
        public void Display()
        {
            Console.WriteLine($"Student's Name: {this.Name}");
        }
    }
}