using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models;
using Chef.Services;

namespace Chef
{
    internal class WaiterService
    {
        public WaiterService(Waiter waiter)
        {
            Waiter = waiter;
        }

        public Waiter Waiter { get; set; }
        public void TakeOrder()
        {
            Waiter.IsBusy = true;
            Waiter.Order = ClientCommunication.SaladChoosing();
        }

        public void BringOrder(Salad salad)
        {
            if (salad.IsReady)
            {
                ClientCommunication.DescribeSaladIngredients(salad);
            }

            Waiter.IsBusy = false;
        }

        public ChefService PassTheOrderToChef(Models.Chef chef)
        {
            return new ChefService(chef);
        }
    }
}
