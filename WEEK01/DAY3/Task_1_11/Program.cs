// Task 1.11 Nullable int with HasValue;
// a method ApplyDiscount(double? discount) defaulting to 5% via ??.
// ✓ Done when: passing null applies the default; passing a value uses it.

class Program
{
    private int _cost;

    public Program(int cost)
    {
        _cost = cost;
    }

    public double ApplyDiscount(double? discount)
    {
        if (discount.HasValue)
        {
            return _cost - (_cost * discount.Value / 100);
        }
        else
        {
            return _cost - (_cost * 0.05);
        }

        // double actualDicount = discount ?? 0.05;
        // return _cost - (_cost * actualDicount);
    }

    static void Main()
    {
        Program c = new(100);
        var discountedPrice = c.ApplyDiscount(null);
        Console.WriteLine($"Null Discount: {discountedPrice}");

        discountedPrice = c.ApplyDiscount(30);
        Console.WriteLine($"30% discount: {discountedPrice}");
    }
}
