using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;

namespace Chef.Interfaces
{
    public interface IVegetable : IEatable
    {
        double SkinWeight { get; }
        bool IsAddingToSalat { get; }
        bool InContainVitaminA { get; }
        bool IsNormalizeMetabolism { get; }
    }
}
