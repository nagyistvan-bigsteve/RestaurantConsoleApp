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

        public Cart addProduct(Product product)
        {
            bool inStock = true;
            if (product.GetType().Equals(typeof(NaturalDrink)))
            {
                inStock = Seller.checkStock(product.Name);
            }
            if (inStock)
                cart.Add(product);
            else
                Console.WriteLine("We don't have on stock");
            if (product.GetType().Equals(typeof(Meat))) 
            {
                cart.Add(ProductFactory.CreateProduct("Rice", ProductType.SlideDish, 5));
                Console.WriteLine("With your Meat '"+product.Name+"' Menu, you get Rice. You can change it");
            }
            return this;
        }

        public Cart changeSlideDish(Product slideDish)
        {
            bool changed = true;
            foreach(Product slide in cart)
            {
                if(slide.Name == "Rice")
                {
                    changed = false;
                    cart.Remove(slide);
                    cart.Add(slideDish);
                    Console.WriteLine("The slide dish is changed");
                    break;
                }
            }
            if (changed)
                Console.WriteLine("The slide dish is not rice");
            return this;
        }

        public Cart removeProduct(Product product)
        {
            if (cart.Contains(product))
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
            if (!cart.Any()) result = "Your cart is empty";
            return result;
        }

    }
}
