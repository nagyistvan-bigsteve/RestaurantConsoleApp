using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class StockNotify
    {
        private static StockNotify stockNotify = null;
        public event EventHandler<Product> Notify;
        private StockNotify() { }
        public static StockNotify Instance()
        {
            if (stockNotify == null)
                stockNotify = new StockNotify();
            return stockNotify;
        }

        public void OutProduct(Product prod)
        {
            if (Notify != null)
            {
                Notify(this,prod);
            }
        }

    }
}
