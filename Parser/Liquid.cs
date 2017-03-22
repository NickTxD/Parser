using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Liquid
    {
        public int Price { get; }
        public bool Availability { get; }
        public string Name { get; }
        public string Link { get; }
        public bool StrengthIndicated { get; }
        public List<double> Strength { get; }
        public bool AmountIndicated { get; }
        public List<int> Amount { get; }

        public Liquid(bool amountIndicated, bool strengthIndicated, string link, string name, bool availability, int price, List<double> strength, List<int> amount)
        {
            AmountIndicated = amountIndicated;
            StrengthIndicated = strengthIndicated;
            Link = link;
            Name = name;
            Availability = availability;
            Price = price;
            Strength = strength;
            Amount = amount;
        }
    }

}
