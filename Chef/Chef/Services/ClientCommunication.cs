using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models;
using Chef.Models.Vegetables;

namespace Chef
{
    internal class ClientCommunication
    {
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to our salad restaurant");
        }

        /// <summary>
        /// Method that asking the client which salad he choses.
        /// </summary>
        /// <returns>The name of chosen salad.</returns>
        public static string SaladChoosing()
        {
            string order = string.Empty;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Which salad do you prefer ? Salad 1 or Salad 2");
            try
            {
                order = Console.ReadLine();
                if (order.Contains("1") && !order.Contains("2"))
                {
                    return "Salad 1";
                }
                else if (order.Contains("2") && !order.Contains("1"))
                {
                    return "Salad 2";
                }
            }
            catch (Exception)
            {
            }

            return order;
        }

        /// <summary>
        /// Method says that we dont have the ordered salad.
        /// </summary>
        public static void DontHaveThisSalat()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("We dont have this salad. Sorry.");
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(1);
        }

        /// <summary>
        /// Ifall the chefs or waiters are busy - we say that message.
        /// </summary>
        public static void BusyMessage()
        {
            Console.WriteLine("Sorry our chefs or waiters are busy");
        }

        /// <summary>
        /// Methos describing all the salad characteristics and some characteristics of the ingredients.
        /// </summary>
        /// <param name="salad">Finished salad.</param>
        public static void DescribeSaladIngredients(Salad salad)
        {
            bool isNullProduct = false;
            Console.WriteLine("\n\tHere is your order:\n");
            Console.WriteLine($"Salad name: {salad.Name}\nSalad calories = {salad.CaloryContent()}\nIs it for vegans? {salad.IsVegan()}\n\n\tIngredients:\n");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < salad.Products.Length; i++)
            {
                if (salad.Products[i] is null)
                {
                    isNullProduct = true;
                    continue;
                }

                sb.Append($"Product name: {salad.Products[i].FoodName}\n");
                if (salad.Products[i] is Tomato)
                {
                    var tom = salad.Products[i] as Tomato;
                    sb.Append($"Expiration date: {tom.ExpirationDate}\nPrice: {tom.Price}\nIs it pickled: {tom.IsPickled}\nDoes it contains vitamin A: {tom.InContainVitaminA}\nDoes it normalize metabolism{tom.IsNormalizeMetabolism}\nTomato kind: {tom.TomatoKind}\nTomato shape: {tom.TomatoShape}\nTomato color: {tom.TomatoColor}\n\n");
                }
                else if (salad.Products[i] is Cucumber)
                {
                    var cuc = salad.Products[i] as Cucumber;
                    sb.Append($"Expiration date: {cuc.ExpirationDate}\nPrice: {cuc.Price}\nDoes it contains vitamin A: {cuc.InContainVitaminA}\nDoes it normalize metabolism{cuc.IsNormalizeMetabolism}\nCucumber kind: {cuc.CucumberKind}\nCucumber shape: {cuc.CucumberShape}\n\n");
                }
                else if (salad.Products[i] is Meat)
                {
                    var m = salad.Products[i] as Meat;
                    sb.Append($"Expiration date: {m.ExpirationDate}\nPrice: {m.Price}\nPart of animal: {m.MeatPart}\nKind of animal: {m.AnimalType}\nFat content: {m.FatContent}%\n\n");
                }
            }

            if (isNullProduct)
            {
                sb.Append("\n\nWe are so sorry. We didnt have some ingredients and we done the salad without them. The salad is on the house)");
            }

            Console.WriteLine(sb);
        }
    }
}
