using System.Collections.Generic;
using System.ServiceModel;
using Parser.DTO;

namespace Parser.WCF.Interfaces
{
    [ServiceContract]
    public interface IParserService
    {

        [OperationContract]
        ICollection<LiquidDTO> GetLiquids();

    }
}
