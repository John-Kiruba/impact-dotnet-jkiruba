// Mini Q2 — Temperature Converter: value + unit → the other two units,
//  using method overloading.
// ✓ Done when: all three units convert correctly.
class TemperatureConverter
{
    public void Convert(double value)
    {
        Console.WriteLine("Celsius to Fahrenheit = " + (value * 9 / 5 + 32));
        Console.WriteLine("Celsius to Kelvin = " + (value + 273.15));
    }

    public void Convert(double value, char unit)
    {
        if (unit == 'F')
        {
            Console.WriteLine("Fahrenheit to Celsius = " + ((value - 32) * 5 / 9));
            Console.WriteLine("Fahrenheit to Kelvin = " + (((value - 32) * 5 / 9) + 273.15));
        }
        else if (unit == 'K')
        {
            Console.WriteLine("Kelvin to Celsius = " + (value - 273.15));
            Console.WriteLine("Kelvin to Fahrenheit = " + ((value - 273.15) * 9 / 5 + 32));
        }
    }
}

class Program
{
    static void Main()
    {
        TemperatureConverter tc = new TemperatureConverter();

        tc.Convert(25);

        Console.WriteLine();

        tc.Convert(98.6, 'F');

        Console.WriteLine();

        tc.Convert(300, 'K');
    }
}
