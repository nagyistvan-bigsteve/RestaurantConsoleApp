using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class Soda : Product
    {
        public Soda(ProductType type, string name, double price) : base(type, name, price)
        {
            this.Description = "250 ml.";
        }
        protected override void SetVAT()
        {
            VAT = 12;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} \nDescription: {Description}";
        }
    }
}
