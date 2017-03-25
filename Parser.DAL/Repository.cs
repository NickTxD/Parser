using System;
using System.Linq;
using Parser.DAL.Entities;
using Parser.Domain;

namespace Parser.DAL
{
    public class Repository : IRepository
    {
        public Liquid GetLiquidByGuid(Guid id)
        {
            using (var context = new ParserContext())
            {
                return this.GetLiquidByGuid(id, context);
            }
        }

        public Liquid Save(Liquid liquid)
        {
            using (var context = new ParserContext())
            {
                var result = this.SaveLiquid(liquid, context);

                context.SaveChanges();

                return result;
            }
        }

        private Liquid GetLiquidByGuid(Guid id, ParserContext context)
        {
            var result = context.Liquids.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                throw  new ArgumentOutOfRangeException(nameof(id));
            }
            return result.MapToModel();
        }

        private Liquid SaveLiquid(Liquid liquid, ParserContext context)
        {
            LiquidEntity result;
            if (liquid.Id != Guid.Empty)
            {
                result = context.Liquids.First(x => x.Id == liquid.Id).MaptoEntity(liquid);
            }
            else
            {
                result = new LiquidEntity().MaptoEntity(liquid);
                result.Id = Guid.NewGuid();
                context.Liquids.Add(result);
            }
           return result.MapToModel();
        }
    }
}
