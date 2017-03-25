using System;
using System.Collections.Generic;

namespace Parser.Domain
{
    public class Liquid
    {
        public Guid Id { get; set; }

        public int Article { get; }
        public int Price { get; }
        public bool Availability { get; }
        public string Name { get; }
        public string Link { get; }
        public bool StrengthIndicated { get; }
        public List<double> Strength { get; }
        public bool AmountIndicated { get; }
        public List<int> Amount { get; }

        public Liquid(int article, bool amountIndicated, bool strengthIndicated, string link, string name, bool availability, int price, List<double> strength, List<int> amount)
        {
            Article = article;
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
