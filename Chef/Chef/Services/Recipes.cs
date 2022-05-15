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
    internal class Recipes
    {
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
                        if (Assortment.AssortmentObject[i] is Tomato)
                        {
                            if (tomatoCounter >= 3)
                            {
                                continue;
                            }

                            tomatoCounter++;
                        }

                        if (Assortment.AssortmentObject[i] is Cucumber)
                        {
                            if (cucumberCounter >= 3)
                            {
                                continue;
                            }

                            cucumberCounter++;
                        }

                        result[j] = Assortment.AssortmentObject[i];
                        j++;
                    }
                }
                catch (Exception)
                {
                }
            }

            return result;
        }

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
                        if (Assortment.AssortmentObject[i] is Tomato)
                        {
                            if (tomatoCounter >= 4)
                            {
                                continue;
                            }

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

                            result[j] = Assortment.AssortmentObject[i];
                            j++;
                            meatCounter++;
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
