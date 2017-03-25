using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parser.DAL.Entities
{
    [Table("Liquids")]
    class LiquidEntity
    {
        [Key]
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

        public LiquidEntity MaptoEntity(Liquid liquid)
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

        public Liquid MapToModel()
        {
            var liquid = new Liquid(
                this.Article, this.AmountIndicated, 
                this.StrengthIndicated, this.Link, this.Name, 
                this.Availability, this.Price, this.Strength, this.Amount) {Id = this.Id};
            return liquid;
        }
    }
}
