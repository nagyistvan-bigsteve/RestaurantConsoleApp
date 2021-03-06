using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantConsoleApp
{
    class Menu 
    {
        private static List<Product> _instance = new List<Product>();
        private static Menu menu = null;     
        private Menu()
        {
            CashRegister.CashRegister cashRegister = new CashRegister.CashRegister();
            _instance.Add(ProductFactory.CreateProduct("Margherita", ProductType.Pizza, 20, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Capriciosa", ProductType.Pizza, 22, cashRegister)
                .setDescription(", Mushroom"));
            _instance.Add(ProductFactory.CreateProduct("Prosciuto", ProductType.Pizza, 22, cashRegister)
                .setDescription(", Cheese"));
            _instance.Add(ProductFactory.CreateProduct("Quattro stagioni", ProductType.Pizza, 24, cashRegister)
                .setDescription(", Mushroom, Cheese ,Bacon"));

            _instance.Add(ProductFactory.CreateProduct("Carbonara", ProductType.Pasta, 13, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Sea food", ProductType.Pasta, 20, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Gnochi", ProductType.Pasta, 15, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Quattro farmoggi", ProductType.Pasta, 13, cashRegister));

            _instance.Add(ProductFactory.CreateProduct("Chicken", ProductType.Meat, 12, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Duck", ProductType.Meat, 20, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Hamburger", ProductType.Meat, 15, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Steak", ProductType.Meat, 14, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Pork chops", ProductType.Meat, 12, cashRegister));

            _instance.Add(ProductFactory.CreateProduct("Rice", ProductType.SlideDish, 5, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("French fries", ProductType.SlideDish, 6, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Mashed potatoes", ProductType.SlideDish, 5, cashRegister));

            _instance.Add(ProductFactory.CreateProduct("Ketchup", ProductType.Sauce, 0, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Mayo", ProductType.Sauce, 0.3, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Tzatziki", ProductType.Sauce, 0.5, cashRegister));

            _instance.Add(ProductFactory.CreateProduct("Lava cake", ProductType.Desert, 10, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Icecream", ProductType.Desert, 4, cashRegister));

            _instance.Add(ProductFactory.CreateProduct("Cola", ProductType.Soda, 5, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Fanta", ProductType.Soda, 5, cashRegister));

            _instance.Add(ProductFactory.CreateProduct("Water", ProductType.NaturalDrink, 3, cashRegister));
            _instance.Add(ProductFactory.CreateProduct("Lemonade", ProductType.NaturalDrink, 8, cashRegister)
                .setDescription(", with 2 lemon"));
            _instance.Add(ProductFactory.CreateProduct("Fresh", ProductType.NaturalDrink, 8, cashRegister)
                .setDescription(", with 2 orange"));
            _instance.Add(ProductFactory.CreateProduct("Coffee", ProductType.NaturalDrink, 4, cashRegister)
                .changeDescription("150 ml"));

        }
        public static List<Product> getMenuElements()
        {
            return _instance;
        }
        public static Menu Instace()
        {
            if(menu == null)
            {
                menu = new Menu();
            }
            return menu;
        }

        public override string ToString()
        {
            string result = $"The menu contains:\n";
            foreach (var i in _instance)
            {
                result += i.ToString() + "\n\n";
            }
            return result;
        }
    }
}
