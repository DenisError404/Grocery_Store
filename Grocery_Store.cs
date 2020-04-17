using System;
using System.Collections.Generic;

namespace Grocery_Store
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("-----------------");

            string dayOfTheWeek = Console.ReadLine();
            decimal quantity1 = decimal.Parse(Console.ReadLine());
            string product1 = Console.ReadLine();
            decimal quantity2 = decimal.Parse(Console.ReadLine());
            string product2 = Console.ReadLine();
            decimal quantity3 = decimal.Parse(Console.ReadLine());
            string product3 = Console.ReadLine();

            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            products.Add("eggs", 1.8m);
            products.Add("bread", 1.6m);
            products.Add("milk", 0.86m);
            products.Add("peanut butter", 2.75m);
            products.Add("spinach", 3.2m);

            switch (dayOfTheWeek)
            {
                case "Monday":
                    products["eggs"] = 1.8m;
                    products["bread"] = 1.6m;
                    products["milk"] = 0.86m;
                    products["peanut butter"] = 2.75m;
                    products["spinach"] = 3.2m;
                    break;
                case "Tuesday":
                    products["eggs"] = 1.8m * 0.8m;
                    products["bread"] = 1.6m * 0.8m;
                    products["milk"] = 0.86m * 0.8m;
                    products["peanut butter"] = 2.75m;
                    products["spinach"] = 3.2m;
                    break;
                case "Wednesday":
                    products["eggs"] = 1.8m;
                    products["bread"] = 1.6m;
                    products["milk"] = 0.86m;
                    products["peanut butter"] = 2.75m * 0.9m;
                    products["spinach"] = 3.2m * 0.9m;
                    break;
                case "Thursday":
                    products["eggs"] = 1.8m * 0.7m;
                    products["bread"] = 1.6m;
                    products["milk"] = 0.86m;
                    products["peanut butter"] = 2.75m;
                    products["spinach"] = 3.2m;
                    break;
                case "Friday":
                    products["eggs"] = 1.8m * 0.9m;
                    products["bread"] = 1.6m * 0.9m;
                    products["milk"] = 0.86m * 0.9m;
                    products["peanut butter"] = 2.75m * 0.9m;
                    products["spinach"] = 3.2m * 0.9m;
                    break;
                case "Saturday":
                    products["eggs"] = 1.8m;
                    products["bread"] = 1.6m;
                    products["milk"] = 0.86m;
                    products["peanut butter"] = 2.75m;
                    products["spinach"] = 3.2m;
                    break;
                case "Sunday":
                    products["eggs"] = 1.8m * 0.95m;
                    products["bread"] = 1.6m * 0.95m;
                    products["milk"] = 0.86m * 0.95m;
                    products["peanut butter"] = 2.75m * 0.95m;
                    products["spinach"] = 3.2m * 0.95m;
                    break;
            }

            decimal sum = quantity1 * products[product1] + quantity2 * products[product2] + quantity3 * products[product3];
            Console.WriteLine("{0:F2}", sum);

        }
    }
}
