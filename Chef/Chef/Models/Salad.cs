using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;
using Chef.Models.Vegetables;

namespace Chef.Models
{
    public class Salad : ISalad
    {
        public Salad(IEatable[] products, string name)
        {
            Products = products;
            Name = name;
        }

        public string Name { get; }
        public bool IsReady { get; set; }

        public IEatable[] Products { get; }

        /// <summary>
        /// Method sums all the salad ingregients` caloty content.
        /// </summary>
        /// <returns>Salad calory content.</returns>
        public double CaloryContent()
        {
            double sumCal = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Vegetable)
                {
                    sumCal = sumCal + (Products[i].Weight / 100 * (Products[i] as Vegetable).CaloryContentFor100G);
                }
            }

            return sumCal;
        }

        /// <summary>
        /// Method learns if the salad contains meat.
        /// </summary>
        /// <returns>True - if salad doesnt contain meat. False - in the opposite case.</returns>
        public bool IsVegan()
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Meat)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
