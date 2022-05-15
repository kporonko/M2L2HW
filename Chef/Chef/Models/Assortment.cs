using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Interfaces;
using Chef.Models;
using Chef.Models.Vegetables;

namespace Chef
{
    internal class Assortment
    {
        public static IEatable[] AssortmentObject { get; set; } = new IEatable[]
        {
            new Tomato(1, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Tomato(2, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", true),
            new Tomato(3, 10, true, false, true, 11, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Tomato(4, 10, true, false, true, 11, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", true),
            new Tomato(5, 10, true, false, true, 11, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Tomato(6, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", true),
            new Tomato(7, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Tomato(8, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Tomato(9, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Tomato(10, 10, true, false, true, 10, DateTime.Now.AddDays(60), "Tomato", 250, "elongated", "Pink", "Pink Tomato", false),
            new Cucumber(11, 20, true, false, true, 7, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", false),
            new Cucumber(12, 20, true, false, true, 7, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", false),
            new Cucumber(13, 20, true, false, true, 7, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", true),
            new Cucumber(14, 20, true, false, true, 7, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", false),
            new Cucumber(15, 20, true, false, true, 7, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", true),
            new Cucumber(16, 20, true, false, true, 8, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", false),
            new Cucumber(17, 20, true, false, true, 7, DateTime.Now.AddDays(60), "Cucumber", 150, "elongated", "Base", false),
            new Pumpkin(18, 30, false, false, true, 8, DateTime.Now.AddDays(60), "Pumpkin", 2250, "elongated", "Base", false),
            new Pumpkin(19, 30, false, false, true, 7, DateTime.Now.AddDays(60), "Pumpkin", 2250, "elongated", "Base", false),
            new Pumpkin(20, 30, false, false, true, 9, DateTime.Now.AddDays(60), "Pumpkin", 2250, "elongated", "Base", false),
            new Meat(500, DateTime.Now.AddDays(20), "Meat", 200, "Chicken", "Fillet", 4, 21, 45)
        };
    }
}
