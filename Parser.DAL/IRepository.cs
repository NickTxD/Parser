using System;
using System.Collections.Generic;
using Parser.Domain;

namespace Parser.DAL
{
    public interface IRepository
    {
        Liquid GetLiquidByGuid(Guid id);
        Liquid Save(Liquid liquid);
        ICollection<Liquid> GetAllLiquids();
    }
}
