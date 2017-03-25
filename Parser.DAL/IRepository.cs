using System;
using Parser.Domain;

namespace Parser.DAL
{
    public interface IRepository
    {
        Liquid GetLiquidByGuid(Guid id);
        Liquid Save(Liquid liquid);
    }
}
