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
        /// <summary>
        /// Method fills the ProductsForSalad property of the chefService object by products based on recipe #1.
        /// </summary>
        /// <param name="chefService">Object of chefService.</param>
        public void TakeProductsForSalad1(ChefService chefService)
        {
            chefService.ProductsForSalad = Recipes.RecipeSalad1();
        }

        /// <summary>
        /// Method fills the ProductsForSalad property of the chefService object by products based on recipe #2.
        /// </summary>
        /// <param name="chefService">Object of chefService.</param>
        public void TakeProductsForSalad2(ChefService chefService)
        {
            chefService.ProductsForSalad = Recipes.RecipeSalad2();
        }
    }
}
