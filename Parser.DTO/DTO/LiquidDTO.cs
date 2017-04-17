using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Parser.Domain;

namespace Parser.DTO
{
    [DataContract]
    public class LiquidDTO
    {
        [DataMember]
        public Guid Id { get; set; } = Guid.Empty;

        [DataMember]
        public int Article { get; set; }

        [DataMember]
        public int Price { get; set; }

        [DataMember]
        public bool Availability { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Link { get; set; }

        [DataMember]
        public bool StrengthIndicated { get; set; }

        [DataMember]
        public List<double> Strength { get; set; }

        [DataMember]
        public bool AmountIndicated { get; set; }

        [DataMember]
        public List<int> Amount { get; set; }

        public LiquidDTO MapFromModel(Liquid liquid)
        {
            this.Id = liquid.Id;
            this.Article = liquid.Article;
            this.Price = liquid.Price;
            this.Availability = liquid.Availability;
            this.Name = liquid.Name;
            this.Link = liquid.Link;
            this.StrengthIndicated = liquid.StrengthIndicated;
            this.Strength = liquid.Strength;
            this.AmountIndicated = liquid.AmountIndicated;
            this.Amount = liquid.Amount;

            return this;
        }

        public Liquid MaptoModel()
        {
            var liquid = new Liquid(this.Article, this.AmountIndicated, this.StrengthIndicated, this.Link, this.Name,
                    this.Availability, this.Price, this.Strength, this.Amount)
                {Id = this.Id};
            return liquid;
        }

    }
}
