using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models;
using Chef.Interfaces;
using Chef.Services;

namespace Chef.Models
{
    public class Waiter : Person, IWorker
    {
        public Waiter(DateTime dateTime, string firstname, string lastname, int exp, bool isbusy)
    : base(dateTime, firstname, lastname)
        {
            IsBusy = isbusy;
            ExpYears = exp;
        }

        public int ExpYears { get; set; }
        public bool IsBusy { get; set; }
        public string Order { get; set; }
    }
}
