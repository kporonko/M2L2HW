using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;

namespace Chef.Services
{
    internal class AssortmentService
    {
        public void TakeProductsForSalad1(ChefService chefService)
        {
            chefService.ProductsForSalad = Recipes.RecipeSalad1();
        }

        public void TakeProductsForSalad2(ChefService chefService)
        {
            chefService.ProductsForSalad = Recipes.RecipeSalad2();
        }
    }
}
