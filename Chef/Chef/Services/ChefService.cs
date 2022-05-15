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
