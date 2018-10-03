using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Store
    {
        private Cart cart;
        private List<Product> product;
        private List<Costumer> costumer;

        public Store()
        {
            product = new List<Product>();
            cart = new Cart();
            costumer = new List<Costumer>();
        }

        public void AddToProduct(Product newProduct)
        {
            product.Add(newProduct);
        }
        
        public void ShowProduct()
        {
            for(int i = 0; i<product.Count; i++)
            {
                product[i].Show();
            }
        }

        public Product SearchProduct(string id)
        {
            for(int i = 0; i<product.Count; i++)
            {
                if(id == product[i].ProductId.ToString())return product[i];
            }
            return null;
        }
        
        public void SetCostumer(Costumer newCostumer)
        {
            costumer.Add(newCostumer);
        }

        public void AddToCart(Product newProduct)
        {
            cart.AddToCart(newProduct);
        }

        public void ShowCart()
        {
            cart.Show();
        }

    }
}
