using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;
using Chef.Models.Vegetables;

namespace Chef
{
    public static class MyExtentions
    {
        public static IVegetable[] SearchForPinkTomatoes(this ISalad salad)
        {
            int lngth = 0;
            for (int i = 0; i < salad.Products.Length; i++)
            {
                if (salad.Products[i] is Tomato == false)
                {
                    continue;
                }

                if ((salad.Products[i] as Tomato).TomatoColor == "Pink")
                {
                    lngth++;
                }
            }

            int j = 0;
            IVegetable[] pinkTomatoes = new IVegetable[lngth];
            for (int i = 0; i < salad.Products.Length; i++)
            {
                if (salad.Products[i] is Tomato && (salad.Products[i] as Tomato).TomatoColor == "Pink")
                {
                    pinkTomatoes[j] = salad.Products[i] as IVegetable;
                    j++;
                }
            }

            return pinkTomatoes;
        }
    }
}
