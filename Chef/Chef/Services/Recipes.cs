using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;
using Chef.Models;
using Chef.Models.Vegetables;
using Chef.Services;

namespace Chef
{
    /// <summary>
    /// I think there a lot of code duplicating but i dont know how to add it to the separate method.
    /// </summary>
    internal class Recipes
    {
        /// <summary>
        /// Method that choosing the ingredients in accordance with salad recipe №1 (with conditions of normalising the metabolism and WITHOUT MEAT because of that and including 3 tomatoes and 3 cucumbers).
        /// </summary>
        /// <returns>Products array according to the recipe.</returns>
        public static IEatable[] RecipeSalad1()
        {
            IEatable[] result = new IEatable[6];
            int j = 0;
            int tomatoCounter = 0;
            int cucumberCounter = 0;
            for (int i = 0; i < Assortment.AssortmentObject.Length; i++)
            {
                var tempProduct = Assortment.AssortmentObject[i] as Vegetable;
                if (tempProduct == null)
                {
                    continue;
                }

                try
                {
                    if (Assortment.AssortmentObject[i].IsGoneOff() == false && tempProduct.IsNormalizeMetabolism == true && tempProduct.IsAddingToSalat == true)
                    {
                        // Cant separate this part bcs of parameters - Type of vegetable, counter, and 4 more variables.
                        if (Assortment.AssortmentObject[i] is Tomato)
                        {
                            if (tomatoCounter >= 3)
                            {
                                continue;
                            }

                            result[j] = Assortment.AssortmentObject[i];
                            j++;
                            tomatoCounter++;
                        }

                        if (Assortment.AssortmentObject[i] is Cucumber)
                        {
                            if (cucumberCounter >= 3)
                            {
                                continue;
                            }

                            result[j] = Assortment.AssortmentObject[i];
                            j++;
                            cucumberCounter++;
                        }
                    }
                }
                catch (Exception)
                {
                }
            }

            return result;
        }

        /// <summary>
        /// Method that choosing the ingredients in accordance with salad recipe №2 (for the people who want salad with meat but eat only chicken).
        /// </summary>
        /// <returns>Products array according to the recipe.</returns>
        public static IEatable[] RecipeSalad2()
        {
            IEatable[] result = new IEatable[8];
            int j = 0;
            int tomatoCounter = 0;
            int cucumberCounter = 0;
            int meatCounter = 0;
            for (int i = 0; i < Assortment.AssortmentObject.Length; i++)
            {
                var tempProduct = Assortment.AssortmentObject[i] as Meat;

                try
                {
                    if (Assortment.AssortmentObject[i].IsGoneOff() == false)
                    {
                        // Cant separate this part bcs of parameters - Type of vegetable, counter, and 4 more variables.
                        if (Assortment.AssortmentObject[i] is Tomato)
                        {
                            if (tomatoCounter >= 4)
                            {
                                continue;
                            }

                            // I cant separate this part because of 4 variables. It is senceless.
                            result[j] = Assortment.AssortmentObject[i];
                            j++;
                            tomatoCounter++;
                        }
                        else if (Assortment.AssortmentObject[i] is Cucumber)
                        {
                            if (cucumberCounter >= 3)
                            {
                                continue;
                            }

                            result[j] = Assortment.AssortmentObject[i];
                            j++;
                            cucumberCounter++;
                        }
                        else if (Assortment.AssortmentObject[i] is Meat)
                        {
                            if (meatCounter >= 1)
                            {
                                continue;
                            }

                            if (tempProduct.AnimalType == "Chicken")
                            {
                                result[j] = Assortment.AssortmentObject[i];
                                j++;
                                meatCounter++;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }

            return result;
        }
    }
}
