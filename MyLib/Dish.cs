using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Dish
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public Dictionary<string, double> Ingredients { get; set; } // Ингредиенты и их количество
        public double Calories { get; set; } // Калорийность
    }
}

