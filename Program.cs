using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { };
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.UnitPrice = 100;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, 
                CategoryId = 4,
                UnitPrice = 35, 
                UnitInStock = 50,
                ProductName="kitap" };


            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
           


        }
    }
}
