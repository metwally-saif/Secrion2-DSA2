using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secrion2_DSA2_Saif.Classes
{
    internal class City
    {
        public string Name { get; set; }
        public float Expenses { get; set; }
        public bool Visited { get; set; }
        public City Previous { get; set; }

        public City(string name)
        {
            Name = name;
            Expenses = float.MaxValue;
            Visited = false;
            Previous = null;
        }
    }
}
