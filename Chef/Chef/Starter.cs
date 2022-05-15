using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;
using Chef.Models;
using Chef.Services;

namespace Chef
{
    internal class Starter
    {
        public static void Run()
        {
            ClientCommunication.Welcome();
            RestaurantService restaurantService = new RestaurantService();
            (Waiter waiter, Models.Chef chef) = restaurantService.CreatingEmployees();
            WaiterService waiterService = new WaiterService(waiter);

            if (waiter == null || chef == null)
            {
                return;
            }

            waiterService.TakeOrder();
            ChefService chefService = waiterService.PassTheOrderToChef(chef);
            chefService.ProductsChoosing(waiter.Order);
            chefService.CutProducts(chefService.ProductsForSalad);

            Salad orderedSalad = chefService.CreateSalad(chefService.ProductsForSalad);
            waiterService.BringOrder(orderedSalad);

            // Extention method here:
            IVegetable[] pinkTomatoes = orderedSalad.SearchForPinkTomatoes();
            Console.WriteLine();
        }
    }
}
