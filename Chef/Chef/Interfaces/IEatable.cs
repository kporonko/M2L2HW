using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Interfaces
{
    public interface IEatable
    {
        public double Price { get; }
        public int Id { get; }
        public DateTime ExpirationDate { get; }
        public string FoodName { get; }
        double Weight { get; }
        public bool IsGoneOff();
    }
}
