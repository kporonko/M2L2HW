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
    internal class RestaurantService
    {
        public (Waiter waiter, Models.Chef chef) CreatingEmployees()
        {
            Waiter w = null;
            Models.Chef c = null;
            for (int i = 0; i < RestaurantEmployees.Waiters.Length; i++)
            {
                if (RestaurantEmployees.Waiters[i].IsBusy == false)
                {
                    w = RestaurantEmployees.Waiters[i];
                }
            }

            for (int i = 0; i < RestaurantEmployees.Chefs.Length; i++)
            {
                if (RestaurantEmployees.Chefs[i].IsBusy == false)
                {
                    c = RestaurantEmployees.Chefs[i];
                }
            }

            if (w == null || c == null)
            {
                ClientCommunication.BusyMessage();
            }

            return (w, c);
        }
    }
}
