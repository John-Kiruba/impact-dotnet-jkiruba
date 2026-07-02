// Task 1.15 Pattern matching: an object-param method handling int/string/double/null;
//  a grade calculator via switch expression with relational patterns;
//  Order { Status, Amount } discount via property patterns.
// ✓ Done when: each pattern path prints the correct branch

class Order
{
    public required string Status { get; set; }
    public double Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pattern Matching");

        CheckObject(25);
        CheckObject("Hello");
        CheckObject(99.5);
        CheckObject(null);

        Console.WriteLine();

        Console.WriteLine("Grade Calculator");

        Console.WriteLine("95 : " + GetGrade(95));
        Console.WriteLine("82 : " + GetGrade(82));
        Console.WriteLine("74 : " + GetGrade(74));
        Console.WriteLine("65 : " + GetGrade(65));
        Console.WriteLine("40 : " + GetGrade(40));

        Console.WriteLine();

        Order order1 = new Order { Status = "Premium", Amount = 1500 };
        Order order2 = new Order { Status = "Premium", Amount = 700 };
        Order order3 = new Order { Status = "Regular", Amount = 1200 };
        Order order4 = new Order { Status = "Regular", Amount = 500 };

        Console.WriteLine(GetDiscount(order1));
        Console.WriteLine(GetDiscount(order2));
        Console.WriteLine(GetDiscount(order3));
        Console.WriteLine(GetDiscount(order4));
    }

    static void CheckObject(object obj)
    {
        switch (obj)
        {
            case int i:
                Console.WriteLine("Integer: " + i);
                break;

            case string s:
                Console.WriteLine("String: " + s);
                break;

            case double d:
                Console.WriteLine("Double: " + d);
                break;

            case null:
                Console.WriteLine("Object is null");
                break;

            default:
                Console.WriteLine("Unknown Type");
                break;
        }
    }

    static string GetGrade(int marks)
    {
        return marks switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F",
        };
    }

    static string GetDiscount(Order order)
    {
        return order switch
        {
            { Status: "Premium", Amount: >= 1000 } => "20% Discount",
            { Status: "Premium" } => "10% Discount",
            { Amount: >= 1000 } => "5% Discount",
            _ => "No Discount",
        };
    }
}
