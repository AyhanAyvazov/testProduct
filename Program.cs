using ProductWithCategory.Models;
using ProductWithCategory.Repositories;
using ProductWithCategory.Services;


public class Program 
{
    public static void Main() {

        

       var products  = new List<Product>()
        {
            new Product {ProductName = "A", CategoryId = 1, UnitPrice = 100, UnitsInStock=100},

            new Product {ProductName = "B", CategoryId = 2, UnitPrice = 200, UnitsInStock=200},

            new Product {ProductName = "C", CategoryId = 3, UnitPrice = 300, UnitsInStock=300},

            new Product {ProductName = "D", CategoryId = 4, UnitPrice = 400, UnitsInStock=400}
        };


    }
}