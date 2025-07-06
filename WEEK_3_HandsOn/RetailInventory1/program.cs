using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        Console.WriteLine("\n📦 All Products:");
        var products = await context.Products.ToListAsync();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        Console.WriteLine("\n🔍 Find Product by ID (1):");
        var productById = await context.Products.FindAsync(1);
        Console.WriteLine(productById != null
            ? $"Found: {productById.Name}"
            : "Product not found");

        Console.WriteLine("\n💰 First Product with Price > 50,000:");
        var expensiveProduct = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine(expensiveProduct != null
            ? $"Expensive Product: {expensiveProduct.Name} - ₹{expensiveProduct.Price}"
            : "No expensive product found.");
    }
}


