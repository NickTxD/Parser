using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Parser.DTO.DTO;

namespace Parser.WCF.Interfaces
{
    [ServiceContract]
    public interface IParserService
    {

        [OperationContract]
        ICollection<LiquidDTO> GetLiquids();

    }
}
