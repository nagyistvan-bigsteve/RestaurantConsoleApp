using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp { 
    class Meat : Product
    {
        private Status Status { get; set; } = Status.medium;
        public Meat(ProductType type, string name, double price) : base(type, name, price)
        {
            this.Description = "With  slide dish (by default, with Rice - 5 ron). \nYou can change the slide dish, and the status (by default medium)";
        }
        public Meat setCoock(Status status)
        {
            this.Status = status;
            return this;
        }
        protected override void SetVAT()
        {
            VAT = 9;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} \nDescription: {Description}";
        }
    }

    enum Status
    {
        rare,
        medium,
        wellCooked
    }
}
