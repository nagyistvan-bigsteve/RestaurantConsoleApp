using System;
using System.Collections.Generic;

namespace RestaurantConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = ProductFactory.CreateProduct("Duck", ProductType.Meat, 15);
            p1.setDescription("Very very good");
            (p1 as Meat).setCoock(Status.wellCooked);
            Product p2 = ProductFactory.CreateProduct("Cola", ProductType.Soda, 5);
            Product p3 = ProductFactory.CreateProduct("Limonade", ProductType.NaturalDrink, 5);
            Product p4 = ProductFactory.CreateProduct("Rice", ProductType.SlideDish, 5);
            Menu menu = new Menu("Good");
            menu.addProduct(p1).addProduct(p2).addProduct(p3).addProduct(p1);
            menu.setProduct(p1,p4);
            Cart cart = new Cart();
            cart.addProduct(menu);
            cart.addProduct(p2);
            Console.WriteLine(cart);
            cart.buy();
            cart.addProduct(p4);
            Console.WriteLine(cart);
            cart.buy();
            CashRegister.CashRegister.makeDailyBill();
            CashRegister.CashRegister.makeDailyBill();
        }
    }
}
