using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services.Description;
using Parser.BLL.Contracts;
using Parser.Domain;
using Parser.DTO;
using Parser.WCF.Interfaces;

namespace Parser.WCF
{
    public class ParserService : IParserService
    {

        private readonly ILiquidBLL _liquidBLL;

        public ParserService(ILiquidBLL liquidBll)
        {
            this._liquidBLL = liquidBll;
        }
        public ICollection<LiquidDTO> GetLiquids()
        {
            /* ICollection<LiquidDTO> result = new List<LiquidDTO>();
             var temp = new LiquidDTO()
             {
                 Id = Guid.NewGuid(),
                 Name = "SHISHA",
                 Price = 590,
                 Article = 53431,
                 Link = "yandex.ru",
                 AmountIndicated = true,
                 Amount = new List<int>() {30, 60},
                 StrengthIndicated = true,
                 Strength = new List<double>() {1.5, 3, 6},
                 Availability = true
             };
             result.Add(temp);
             return result;*/
            var result = this._liquidBLL.GetAll().Select(x => new LiquidDTO().MapFromModel(x)).ToArray();
            return result;
        }
    }
}
