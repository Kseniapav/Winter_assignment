using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace classDish
{
    public class CartItem
    {
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public BadImageFormatException ImageDish { get; set; }

        public decimal Total => Price * Quantity;
    }
}
