using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    public static class ProductFactory
    {
        public static Product CreateProduct(string name, ProductType type, double price, CashRegister.CashRegister register)
        {
            switch (type)
            {
                case ProductType.NaturalDrink:
                    return new NaturalDrink(type, name, price, register);
                case ProductType.Soda:
                    return new Soda(type, name, price, register);
                case ProductType.Pizza:
                    return new Pizza(type, name, price, register);
                case ProductType.Pasta:
                    return new Pasta(type, name, price, register);
                case ProductType.Meat:
                    return new Meat(type, name, price, register);
                case ProductType.Desert:
                    return new Desert(type, name, price, register);
                case ProductType.Sauce:
                    return new Sauce(type, name, price, register);
                case ProductType.SlideDish:
                    return new SlideDish(type, name, price, register);
                default:
                    return null;
            }
        }
    }
}
