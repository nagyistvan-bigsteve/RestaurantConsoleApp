using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    public abstract class Product
    {
            public string Name { get; set; }
            public ProductType Type { get; }
            public double Price { get; set; }
            public string Description { get; set; } = "";
            public double VAT { get; protected set; } = 9;

            protected Product(ProductType type, string name, double price)
            {
                Name = name;
                Type = type;
                Price = price;
                SetVAT();
            }
            public Product setDescription(string description)
            {
                this.Description = description;
                return this;
             }

            protected abstract void SetVAT();

            public override string ToString()
            {
                return $"{Type} with name: {Name} -> price: {Price} \r Description: {Description}";
            }
    }
}
