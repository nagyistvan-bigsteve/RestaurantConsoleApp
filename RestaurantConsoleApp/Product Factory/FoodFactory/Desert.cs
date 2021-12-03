using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class Desert : Product
    {
        public Desert(ProductType type, string name, double price, CashRegister.CashRegister register) : base(type, name, price,register)
        {
            this.Description = "150 gr. ";
        }
        protected override void SetVAT()
        {
            VAT = 10;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} \nDescription: {Description}";
        }
    }
}
