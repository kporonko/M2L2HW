using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables
{
    internal class Cucumber : Vegetable
    {
        public Cucumber(int id, double skinWeight, bool isAddingToSalat, bool inContainVitaminA, bool isNormalizeMetabolism, double price, DateTime expirationDate, string foodName, double weight, string cucumberShape, string cucumberKind, bool isPlant)
    : base(id, skinWeight, isAddingToSalat, inContainVitaminA, isNormalizeMetabolism, price, expirationDate, foodName, weight, 16)
        {
            CucumberShape = cucumberShape;
            CucumberShape = cucumberShape;
            IsForPlanting = isPlant;
        }

        public string CucumberShape { get; }
        public string CucumberKind { get; }
        public bool IsForPlanting { get; }
    }
}
