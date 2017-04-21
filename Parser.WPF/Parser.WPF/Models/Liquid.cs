using System;
using System.Collections.Generic;

namespace Parser.WPF.Models
{
    public class Liquid
    {
        public virtual Guid Id { get; set; }

        public virtual int Article { get; set; }
        public virtual int Price { get; set; }
        public virtual bool Availability { get; set; }
        public virtual string Name { get; set; }
        public virtual string Link { get; set; }
        public virtual bool StrengthIndicated { get; set; }
        public virtual List<double> Strength { get; set; }
        public virtual bool AmountIndicated { get; set; }
        public virtual List<int> Amount { get; set; }
    }
}