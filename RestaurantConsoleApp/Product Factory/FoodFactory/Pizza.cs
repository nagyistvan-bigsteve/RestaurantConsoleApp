using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class Pizza : Product
    {   
        public Pizza(ProductType type, string name, double price, CashRegister.CashRegister register) : base(type, name, price, register)
        {
            this.Description = "400 gr. ,Sos, Salam";
        }
        protected override void SetVAT()
        {
            VAT = 9;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price+Price*(VAT/100)} \nDescription: {Description}";
        }
    }
}
