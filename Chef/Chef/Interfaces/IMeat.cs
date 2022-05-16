using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;

namespace Chef.Interfaces
{
    internal interface IMeat : IEatable
    {
        double CaloryContentFor100G { get; }
        string AnimalType { get; }
        string MeatPart { get; }
        double FatContent { get; }
    }
}
