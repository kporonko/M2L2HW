using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Interfaces
{
    internal interface IWorker
    {
        public int ExpYears { get; set; }
        public bool IsBusy { get; set; }
    }
}
