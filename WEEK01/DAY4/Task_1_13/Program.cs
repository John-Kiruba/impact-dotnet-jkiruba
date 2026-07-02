// Task 1.13 var reassignment compile error; dynamic reassigned string→int→bool with .GetType();
// a dynamic-param add method called with ints then strings.
//  ✓ Done when: the compile error is shown and the runtime types are printed.

class Program
{
    static void Add(dynamic p1, dynamic p2)
    {
        Console.Write($"Added Result : {p1 + p2}");
    }

    static void Main()
    {
        var name = "John";

        // name = 10;
        // Compile-time error:
        // Cannot implicitly convert type 'int' to 'string'

        dynamic item = "John";
        Console.WriteLine(item.GetType());

        item = 10;
        Console.WriteLine(item.GetType());

        item = true;
        Console.WriteLine(item.GetType());

        Add(1, 2);
        Console.WriteLine();
        Add("jo", "hn");
    }
}
