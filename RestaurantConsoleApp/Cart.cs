using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    public class Cart : List<Product>
    {
        public List<Product> cart = new List<Product>();

        public Cart()
        {}
        public Cart addProduct(List<Product> menu)
        {
            foreach(Product prod in (menu as Menu).menu)
            {
                cart.Add(prod);
            }
            return this;
        }
        public Cart addProduct(Product product)
        {
            cart.Add(product);
            return this;
        }
        public Cart removeProduct(List<Product> menu)
        {
            foreach (Product prod in (menu as Menu).menu)
            {
                cart.Remove(prod);
            }
            return this;
        }
        public Cart removeProduct(Product product)
        {
            cart.Remove(product);
            return this;
        }
        public void buy()
        {
            Seller.buyProducts(this);
            cart.Clear();
        }
        public override string ToString()
        {
            string result = $"You have in your cart:\n";
            foreach (var i in cart)
            {
                result += i.ToString() + "\n";
            }
            return result;
        }

    }
}
