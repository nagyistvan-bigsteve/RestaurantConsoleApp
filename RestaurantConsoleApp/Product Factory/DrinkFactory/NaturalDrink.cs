using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class NaturalDrink : Product
    {   
        public NaturalDrink(ProductType type, string name, double price) : base (type,name,price)
        {
            this.Description = "500 ml.";
        }
        protected override void SetVAT()
        {
            VAT = 5;
        }

        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} \nDescription: {Description}";
        }
    }
}
