using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;

namespace Chef.Models.Vegetables
{
    public class Vegetable : IVegetable
    {
        public Vegetable(int id, double skinWeight, bool isAddingToSalat, bool inContainVitaminA, bool isNormalizeMetabolism, double price, DateTime expirationDate, string foodName, double weight, double calories)
        {
            Id = id;
            SkinWeight = skinWeight;
            IsAddingToSalat = isAddingToSalat;
            InContainVitaminA = inContainVitaminA;
            IsNormalizeMetabolism = isNormalizeMetabolism;
            Price = price;
            ExpirationDate = expirationDate;
            FoodName = foodName;
            Weight = weight;
            CaloryContentFor100G = calories;
        }

        public double CaloryContentFor100G { get; set; }

        public double SkinWeight { get; }

        public bool IsAddingToSalat { get; }

        public bool InContainVitaminA { get; }

        public bool IsNormalizeMetabolism { get; }

        public double Price { get; }

        public DateTime ExpirationDate { get; }

        public string FoodName { get; }

        public double Weight { get; set; }

        public int Id { get; set; }

        public bool IsGoneOff()
        {
            if (ExpirationDate < DateTime.Now)
            {
                return true;
            }

            return false;
        }
    }
}
