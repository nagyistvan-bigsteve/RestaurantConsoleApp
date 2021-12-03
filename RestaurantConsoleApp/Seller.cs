using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    public abstract class Seller
    {
        protected CashRegister.CashRegister register;
        public static Stock stock;

        protected Seller(CashRegister.CashRegister register)
        {
            this.register = register;
            stock = new StockFromFile();
        }

        public Seller setStock(Stock newStock)
        {
            stock = newStock;
            return this;
        }
        public abstract void BuyProduct();

        public static bool checkStock(string name)
        {
            return stock.CheckStock(name);
        }
    }
}
