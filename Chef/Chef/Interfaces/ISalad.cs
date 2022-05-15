using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Interfaces
{
    public interface ISalad
    {
        bool IsReady { get; }
        IEatable[] Products { get; }
        double CaloryContent();
        bool IsVegan();
    }
}
