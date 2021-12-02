using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp.CashRegister
{
    public class CashRegister
    {
        public static double Price = 0;
        public static string Products ="";
        public static double Total = 0;
        public static string Bill ="";

        public static void bill(double price, double vat, string name)
        {
            Total += (price + price * (vat / 100));
            Bill += name + "---> price:" + price + " vat:" + vat + "% \n" +
                "total: "+ (price + price * (vat / 100))+"\n";
            dailyBill(price + (price * (vat / 100)), name);
        }
        public static void makeBill()
        {   
            Console.WriteLine("---------------");
            Console.WriteLine("Restaurant bill");
            Console.WriteLine(Bill);
            Console.WriteLine("---------------");
            Console.WriteLine("Total: "+Total);
            Console.WriteLine("---------------");
            Total = 0;
            Bill = "";
        }
        public static void dailyBill(double price, string prod)
        {
            Price += price;

            if (!Products.Contains(prod))
             Products += prod +" - "+1+"x"+price+ "\n"; 
            else
            {
                int index = Products.IndexOf(prod);

                int position = Products.IndexOf("x");

                var b ="";

                var val = 1;

                for(var i=index+prod.Length; i <= position; i++)
                {
                    if (Char.IsDigit(Products[i]))
                        b += Products[i];
                }
                if (b.Length > 0)
                    val = int.Parse(b);

                var val2 = val + 1;

                Products = Products.Replace(prod + " - "+val +"x", prod + " - "+val2 +"x");
            }

        }
        public static void makeDailyBill()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Restaurant daily bill");
            Console.WriteLine(Products);
            Console.WriteLine("---------------");
            Console.WriteLine("total: " + Price);
            Console.WriteLine("---------------");

            Price = 0;
            Products="";
        }
    }
}
