// Mini Q1 — Product Catalog: Product { Name, Price, Category(enum) },
//  5 objects printed grouped by category.
//  ✓ Done when: output is grouped correctly by category.

enum Category
{
    Electronics,
    Grocery,
    Clothing,
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }
}

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product
            {
                Name = "Laptop",
                Price = 65000,
                Category = Category.Electronics,
            },
            new Product
            {
                Name = "Phone",
                Price = 25000,
                Category = Category.Electronics,
            },
            new Product
            {
                Name = "Rice",
                Price = 80,
                Category = Category.Grocery,
            },
            new Product
            {
                Name = "Shirt",
                Price = 1200,
                Category = Category.Clothing,
            },
            new Product
            {
                Name = "Oil",
                Price = 180,
                Category = Category.Grocery,
            },
        };

        var groups = products.GroupBy(p => p.Category);

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key);

            foreach (var product in group)
            {
                Console.WriteLine(product.Name + " - " + product.Price);
            }

            Console.WriteLine();
        }
    }
}
