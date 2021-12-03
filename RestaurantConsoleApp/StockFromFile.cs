using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class StockFromFile : Stock
    {
        public override bool CheckStock(string name)
        {
            if (name != "Lemonade" && name != "Fresh")
                return true;


            string readText = File.ReadAllText(@"D:\Users\NagyIstvan\source\repos\Stock\" + name + ".txt");
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
