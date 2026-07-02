//Task 1.9 Copy-and-modify test with two ints, then an int[], then a Coordinate struct vs a Coordinate class.
//Explain each output in a comment.
//✓ Done when: the comment correctly explains why the array/class shared state but the int/struct did not.

class Program
{
    struct CoordinateStruct
    {
        public int X;
        public int Y;
    }

    class CoordinateClass
    {
        public int X;
        public int Y;

        public CoordinateClass(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    static void Main()
    {
        // -------------------------------
        // 1. int (Value Type)

        int initialCount = 10;
        int copiedCount = initialCount;

        copiedCount = 20;

        Console.WriteLine("=== int ===");
        Console.WriteLine($"initialCount = {initialCount}");
        Console.WriteLine($"copiedCount  = {copiedCount}");
        // Output explanation:
        // int is a value type. copiedCount receives its own copy,
        // so changing copiedCount does not affect initialCount.

        Console.WriteLine();

        // -------------------------------
        // 2. int[] (Reference Type)
        // -------------------------------
        int[] numbers1 = { 10, 20, 30 };
        int[] numbers2 = numbers1;

        numbers2[0] = 100;

        Console.WriteLine("=== int[] ===");
        Console.WriteLine($"numbers1[0] = {numbers1[0]}");
        Console.WriteLine($"numbers2[0] = {numbers2[0]}");
        // Output explanation:
        // Arrays are reference types. Both variables point to
        // the same array, so changing one affects the other.

        Console.WriteLine();

        // -------------------------------
        // 3. Struct (Value Type)
        // -------------------------------
        CoordinateStruct point1 = new() { X = 10, Y = 20 };

        CoordinateStruct point2 = point1;

        point2.X = 50;

        Console.WriteLine("=== Struct ===");
        Console.WriteLine($"point1.X = {point1.X}");
        Console.WriteLine($"point2.X = {point2.X}");
        // Output explanation:
        // Structs are value types. point2 receives a copy of point1,
        // so changing point2 does not change point1.

        Console.WriteLine();

        // -------------------------------
        // 4. Class (Reference Type)
        // -------------------------------
        CoordinateClass coord1 = new(10, 20);
        CoordinateClass coord2 = coord1;

        coord2.X = 50;

        Console.WriteLine("=== Class ===");
        Console.WriteLine($"coord1.X = {coord1.X}");
        Console.WriteLine($"coord2.X = {coord2.X}");
        // Output explanation:
        // Classes are reference types. coord1 and coord2 refer to
        // the same object, so changing coord2 also changes coord1.
    }
}

// output
// === int ===
// initialCount = 10
// copiedCount  = 20

// === int[] ===
// numbers1[0] = 100
// numbers2[0] = 100

// === Struct ===
// point1.X = 10
// point2.X = 50

// === Class ===
// coord1.X = 50
// coord2.X = 50
