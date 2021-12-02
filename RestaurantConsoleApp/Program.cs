using System;
using System.Collections.Generic;

namespace RestaurantConsoleApp
{
    class Program
    {
        public static List<Product> list;
        public static Cart cart = new Cart();
        static void Main(string[] args)
        {

            Menu menu = Menu.Instace();
            Console.WriteLine(menu);
            list = Menu.getMenuElements();

            Console.WriteLine("Do you want to buy something?");

            string answer = Console.ReadLine();
            bool Out = true;

            do
            {   if(!Out && answer != "yes") answer = Console.ReadLine();
                switch (answer)
                {
                    case "no":
                        Console.WriteLine("Ok! Have a nice day.");
                        Out = true;
                        break;
                    case "yes":
                        Console.WriteLine("What do you want?");
                        Out = true;
                        Buy();

                        Console.WriteLine("Do you want anything else?");
                        answer = Console.ReadLine();

                        switch(answer)
                        {
                            case "no":
                                Console.WriteLine("Do you want to buy?");
                                answer = Console.ReadLine();

                                switch (answer)
                                {
                                    case "no":
                                        Console.WriteLine("Ok! Have a nice day.");
                                        break;
                                    case "yes":
                                        cart.buy();
                                        break;
                                    default:
                                        Console.WriteLine("Please type 'yes' or 'no'");
                                        Out = false;
                                        break;
                                }

                                break;
                            case "yes":
                                Out = false;
                                answer = "yes";
                                break;
                            default:
                                Console.WriteLine("Please type 'yes' or 'no'");
                                Out = false;
                                break;
                        }

                        break;
                    default:
                        Console.WriteLine("Please type 'yes' or 'no'");
                        Out = false;
                        break;
                }
            } while (!Out);


 //           CashRegister.CashRegister.makeDailyBill();
        }

        static void Buy()
        {
            string product = Console.ReadLine();
            bool stock = false;
            foreach (Product element in list) 
            {
                if (element.Name == product)
                {
                    cart.addProduct(element);
                    if (element.GetType().Equals(typeof(Meat)))
                    {
                        Console.WriteLine("Want to set slide dish?");
                        string answ = Console.ReadLine();
                        switch (answ)
                        {
                            case "yes":
                                Console.WriteLine("What do you want for slide dish?");
                                string slidedish = Console.ReadLine();
                                bool stockslide = false;
                                foreach (Product slide in list)
                                {
                                    if (slide.Name == slidedish)
                                    {
                                        cart.changeSlideDish(slide);
                                        stockslide = true;
                                    }
                                }
                                if (!stockslide)
                                    Console.WriteLine("Than remains Rice");

                                break;
                            case "no":
                                Console.WriteLine("Than remains Rice");
                                break;
                            default:
                                Console.WriteLine("Than remains Rice");
                                break;

                        }
                        Console.WriteLine("Want to set statusul?");
                        string answ2 = Console.ReadLine();
                        switch (answ2)
                        {
                            case "yes":

                                Console.WriteLine("Rare, medium or well cooked?");
                                string status = Console.ReadLine();

                                switch (status)
                                {
                                    case "rare":
                                        (element as Meat).setCoock(Status.rare);
                                        break;
                                    case "medium":
                                        (element as Meat).setCoock(Status.medium);
                                        break;
                                    case "well cooked":
                                        (element as Meat).setCoock(Status.wellCooked);
                                        break;
                                    default:
                                        Console.WriteLine("Then remains");
                                        break;
                                }

                                break;
                            case "no":
                                Console.WriteLine("Than remains");
                                break;
                            default:
                                Console.WriteLine("Than remains");
                                break;

                        }
                    }

                    stock = true;
                }
            }
            if (!stock)
                Console.WriteLine("Sorry! We don't have " + product);
        }
    }
}
