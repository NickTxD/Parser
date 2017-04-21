using System.Collections.Generic;
using System.Linq;
using Parser.WPF.DataAccess.Interfaces;
using Parser.WPF.Models;
using Parser.WPF.ParserService;

namespace Parser.WPF.DataAccess
{
    public class LiquidsDataAccess : IDataAccess<Liquid>
    {
        public ICollection<Liquid> Get()
        {
            using (var serviсe = new ParserServiceClient())
            {
                return serviсe.GetLiquids().Select(x => new Liquid()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Article = x.Article,
                    Link = x.Link,
                    Price = x.Price,
                    Availability = x.Availability,
                    StrengthIndicated = x.StrengthIndicated,
                    Strength = new List<double>(x.Strength),
                    AmountIndicated = x.AmountIndicated,
                    Amount = new List<int>(x.Amount)
                }).ToArray();
            }
        }
    }
}