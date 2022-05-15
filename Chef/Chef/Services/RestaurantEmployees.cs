using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models;

namespace Chef
{
    internal class RestaurantEmployees
    {
        public static Waiter[] Waiters { get; set; } = new Waiter[7]
        {
            new Waiter(new DateTime(2001, 12, 12), "John", "Davis", 1, true),
            new Waiter(new DateTime(2003, 10, 1), "Ken", "Jackson", 2, true),
            new Waiter(new DateTime(1992, 9, 12), "Koby", "Gibson", 8, true),
            new Waiter(new DateTime(2000, 8, 12), "Jack", "Morrison", 4, false),
            new Waiter(new DateTime(2001, 6, 23), "Chris", "Williams", 5, true),
            new Waiter(new DateTime(2001, 8, 5), "Carla", "Peters", 3, false),
            new Waiter(new DateTime(2000, 1, 1), "Dexter", "Jones", 7, true)
        };

        public static Models.Chef[] Chefs { get; set; } = new Models.Chef[3]
        {
            new Models.Chef(new DateTime(1991, 10, 1), "Martin", "Martins", 10, true),
            new Models.Chef(new DateTime(1991, 10, 1), "Jason", "Kennedy", 12, true),
            new Models.Chef(new DateTime(1991, 10, 1), "Jason", "Obama", 14, false)
        };
    }
}
