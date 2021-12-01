using System;
using System.Collections.Generic;
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
    }
}
