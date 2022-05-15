using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables
{
    internal class Tomato : Vegetable
    {
        public Tomato(int id, double skinWeight, bool isAddingToSalat, bool inContainVitaminA, bool isNormalizeMetabolism, double price, DateTime expirationDate, string foodName, double weight, string tomatoShape, string tomatoColor, string tomatoKind, bool isPickled)
            : base(id, skinWeight, isAddingToSalat, inContainVitaminA, isNormalizeMetabolism, price, expirationDate, foodName, weight, 24)
        {
            TomatoShape = tomatoShape;
            TomatoColor = tomatoColor;
            TomatoKind = tomatoKind;
            IsPickled = isPickled;
        }

        public string TomatoShape { get; }
        public string TomatoColor { get; }
        public string TomatoKind { get; }
        public bool IsPickled { get; }
    }
}
