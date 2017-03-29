using System.Collections.Generic;
using System.Linq;
using Parser.BLL.Contracts;
using Parser.DTO.DTO;
using Parser.WCF.Interfaces;

namespace Parser.WCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
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
