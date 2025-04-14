using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulinaryDictionary
{
    internal class Category
    {
        public string Name { get; set; }
        public List<infoDish> Dishes { get; set; }

        public Category()
        {
            Dishes = new List<infoDish>();
        }
    }
}
