using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.DAL
{
    public interface IRepository
    {
        Liquid GetLiquidByGuid(Guid id);
        Liquid Save(Liquid liquid);
    }
}
