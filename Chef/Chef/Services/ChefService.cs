using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;
using Chef.Models;
using Chef.Models.Vegetables;

namespace Chef.Services
{
    public class ChefService
    {
        public ChefService(Models.Chef chef)
        {
            Chef = chef;
        }

        public string CurrentSalad { get; set; }
        public Models.Chef Chef { get; set; }
        public IEatable[] ProductsForSalad { get; set; }

        /// <summary>
        /// Method calls the method for taking products according to clients order.
        /// </summary>
        /// <param name="salad">Client`s order - salad.</param>
        public void ProductsChoosing(string salad)
        {
            AssortmentService assortmentService = new AssortmentService();
            if (salad == "Salad 1")
            {
                assortmentService.TakeProductsForSalad1(this);
                CurrentSalad = "Salad 1";
            }
            else if (salad == "Salad 2")
            {
                assortmentService.TakeProductsForSalad2(this);
                CurrentSalad = "Salad 2";
            }
            else
            {
                ClientCommunication.DontHaveThisSalat();
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Method for cutting the pill from vegetables. Weight of ingredients is decreasing because of cutting the pill.
        /// </summary>
        /// <param name="products">Salad`s products.</param>
        public void CutProducts(IEatable[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                var vegetable = products[i] as Vegetable;
                try
                {
                    if (vegetable is Vegetable)
                    {
                        vegetable.Weight -= vegetable.SkinWeight;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Overall method of creating the salad from the ingredients taken earlier.
        /// </summary>
        /// <param name="eatable">Salad`s products.</param>
        /// <returns>Salad which is ready for consumption.</returns>
        public Salad CreateSalad(IEatable[] eatable)
        {
            Chef.StartCooking();
            Salad salad = new Salad(ProductsForSalad, CurrentSalad);
            Chef.StopCooking();
            salad.IsReady = true;
            return salad;
        }
    }
}
