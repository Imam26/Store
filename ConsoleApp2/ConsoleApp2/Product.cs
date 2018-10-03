using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product
    {
        public string Category { set; get; }
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public double Price { set; get; }

        public Product()
        {
            Thread.Sleep(200);
            Random random = new Random();
            ProductId = random.Next(100);
        }

        public Product(string category, string productName, double price)
        {
            Category = category;
            ProductName = productName;
            Price = price;
            Thread.Sleep(200);
            Random random = new Random();
            ProductId = random.Next(100);
        }

        public void Show()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("ID: {0}", ProductId);
            Console.WriteLine("Категория: {0}", Category);
            Console.WriteLine("Название продукта: {0}", ProductName);
            Console.WriteLine("Цена: {0}", Price);
        }
    }
}
