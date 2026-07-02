// Task 1.12 Show int→long→float→double (implicit) and double→int (explicit, precision loss).
//  Take a string and use is, as, Convert.ToInt32, int.TryParse, noting when each is right.
//  ✓ Done when: all four conversion approaches run and the precision-loss case is noted.

class Program
{
    static void Main()
    {
        int valueInt = 1000;
        long valueLong = valueInt;
        float valueFloat = valueLong;
        double valueDouble = valueFloat;

        Console.WriteLine(
            $"Int: {valueInt} \nLong: {valueLong} \nFloat: {valueFloat} \nDouble: {valueDouble}"
        );

        Console.WriteLine();

        double balanceDouble = 99.45;
        int balanceInt = (int)balanceDouble;

        Console.WriteLine($"Balance Double: {balanceDouble}; \nBalance Int: {balanceInt} ");

        string numberString = "123";
        int convertToInt32 = Convert.ToInt32(numberString);
        bool isNumber = int.TryParse(numberString, out int result);
        Console.WriteLine();

        Console.WriteLine(
            $"OG String: {numberString} \n"
                + $"Convert.ToInt32: {convertToInt32} \n"
                + $"int.TryParse: {isNumber}\n"
                + $"out type: {result.GetType()}"
        );
        Console.WriteLine();

        object obj = numberString;
        Console.WriteLine($"Object is integer: {obj is string}");
        Console.WriteLine($"Object is string: {obj as string}");
    }
}


// output:
// Int: 1000
// Long: 1000
// Float: 1000
// Double: 1000

// Balance Double: 99.45;
// Balance Int: 99

// OG String: 123
// Convert.ToInt32: 123
// int.TryParse: True
// out type: System.Int32

// Object is integer: True
// Object is string: 123
