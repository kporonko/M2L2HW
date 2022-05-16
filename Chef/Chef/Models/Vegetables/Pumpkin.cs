using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables
{
    internal class Pumpkin : Vegetable
    {
        public Pumpkin(int id, double skinWeight, bool isAddingToSalat, bool inContainVitaminA, bool isNormalizeMetabolism, double price, DateTime expirationDate, string foodName, double weight, string pumpShape, string pumpKind, bool isHal)
    : base(id, skinWeight, isAddingToSalat, inContainVitaminA, isNormalizeMetabolism, price, expirationDate, foodName, weight, 26)
        {
            PumpkinShape = pumpShape;
            PumpkinKind = pumpKind;
            PumpkinKind = pumpKind;
            IsForHaloween = isHal;
        }

        public string PumpkinShape { get; }
        public string PumpkinKind { get; }
        public bool IsForHaloween { get; }
    }
}
