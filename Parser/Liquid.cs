using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Liquid
    {
        public Liquid(int price, string name, string link, string description)
        {
            Price = price;
            Name = name;
            Link = link;
            Description = description;
        }

        public string Name { get; }
        public int Price { get; }
        public string Link { get; }
        public string Description { get; }
        public ICollection<int> Amount { get; } = new List<int>();
        public ICollection<int> Strength { get; } = new List<int>();
    }

}
