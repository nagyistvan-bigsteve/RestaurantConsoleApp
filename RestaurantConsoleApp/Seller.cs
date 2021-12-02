using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    static class Seller
    {
        public static void buyProducts(List<Product> cart)
        {
            foreach (Product prod in (cart as Cart).cart)
                CashRegister.CashRegister.bill(prod.Price, prod.VAT, prod.Name);

            CashRegister.CashRegister.makeBill();
        }
        public static bool checkStock(string name)
        {
            string readText = File.ReadAllText(@"D:\Users\NagyIstvan\source\repos\Stock\"+name+".txt");
            int quantity = int.Parse(readText);
    


            if (quantity >= 2)
            {
                quantity = quantity - 2;
                File.WriteAllText(@"D:\Users\NagyIstvan\source\repos\Stock\" + name + ".txt", quantity.ToString());
                return true;
            }

            else
                return false;
        }
    }
}
