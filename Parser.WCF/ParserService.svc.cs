using System.Collections.Generic;
using System.Linq;
using Parser.BLL.Contracts;
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
            return this._liquidBLL.GetAll().Select(x => new LiquidDTO().MapFromModel(x)).ToArray();
        }
    }
}
