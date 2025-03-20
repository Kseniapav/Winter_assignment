using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    internal class Order
    {
        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public decimal TotalPrice => Dishes.Sum(d => d.Price);

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }
    }
}
