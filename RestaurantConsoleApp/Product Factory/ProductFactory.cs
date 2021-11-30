using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    public static class ProductFactory
    {
        public static Product CreateProduct(string name, ProductType type, double price)
        {
            switch (type)
            {
                case ProductType.NaturalDrink:
                    return new NaturalDrink(type, name, price);
                case ProductType.Soda:
                    return new Soda(type, name, price);
                case ProductType.Pizza:
                    return new Pizza(type, name, price);
                case ProductType.Pasta:
                    return new Pasta(type, name, price);
                case ProductType.Meat:
                    return new Meat(type, name, price);
                case ProductType.Desert:
                    return new Desert(type, name, price);
                case ProductType.Sauce:
                    return new Sauce(type, name, price);
                case ProductType.SlideDish:
                    return new SlideDish(type, name, price);
                default:
                    return null;
            }
        }
    }
}
