using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;

namespace Chef.Models
{
    public class Chef : Person, IWorker
    {
        public Chef(DateTime dateTime, string firstname, string lastname, int exp, bool isbusy)
: base(dateTime, firstname, lastname)
        {
            IsBusy = isbusy;
            ExpYears = exp;
        }

        public int ExpYears { get; set; }
        public bool IsBusy { get; set; }
        public void StartCooking()
        {
            IsBusy = true;
        }

        public void StopCooking()
        {
            IsBusy = false;
        }
    }
}
