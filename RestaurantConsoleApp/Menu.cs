using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class Menu : List<Product>
    {
        public List<Product> menu { get; set; } = new List<Product>();
        public string Name { get; set; }

        public Menu(string name)
        {
            this.Name = name;
        }

        public Menu(string name, Meat meat, SlideDish slideDish)
        {
            Name = name;
            menu.Add(meat);
            menu.Add(slideDish);
        }
        public Menu addProduct(Product product)
        {
            menu.Add(product);
            return this;
        }
        public Menu setProduct(Product outProd,Product inProd)
        {
            menu.Remove(outProd);
            menu.Add(inProd);
            return this;
        }
        public Menu removeProduct(Product outProd)
        {
            menu.Remove(outProd);
            return this;
        }

        public override string ToString()
        {   string result = $"The {Name} menu contains:\n";
            foreach (var i in menu)
            {
                result += i.ToString()+"\n";
            }
            return result;
        }
    }
}
