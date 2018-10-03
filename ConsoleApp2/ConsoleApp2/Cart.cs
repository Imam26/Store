using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Cart
    {
        private List<Product> product;

        public Cart()
        {
            product = new List<Product>();
        }
    
        public void AddToCart(Product newProduct)
        {
            product.Add(newProduct);
        }
        
        public void DeleteFromCart()
        {
            product.Clear();
        }

        public void Show()
        {
            for(int i = 0; i<product.Count; i++)
            {
                product[i].Show();
            }
        }
    }
}
