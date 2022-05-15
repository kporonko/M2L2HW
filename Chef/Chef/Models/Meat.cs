using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;

namespace Chef.Models
{
    internal class Meat : IMeat
    {
        public Meat(double price, DateTime expirationDate, string foodName, double weight, string animalType, string meatPart, double fatContent, int id, double caloryContentFor100G)
        {
            Price = price;
            ExpirationDate = expirationDate;
            FoodName = foodName;
            Weight = weight;
            AnimalType = animalType;
            MeatPart = meatPart;
            FatContent = fatContent;
            Id = id;
            CaloryContentFor100G = caloryContentFor100G;
        }

        public double Price { get; }

        public DateTime ExpirationDate { get; }

        public string FoodName { get; }

        public double Weight { get; set; }

        public string AnimalType { get; }

        public string MeatPart { get; }

        public double FatContent { get; }

        public int Id { get; set; }

        public double CaloryContentFor100G { get; }

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
