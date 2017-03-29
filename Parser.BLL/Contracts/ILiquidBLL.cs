using System;
using System.Collections.Generic;
using Parser.Domain;

namespace Parser.BLL.Contracts
{
    public interface ILiquidBLL
    {
        ICollection<Liquid> Parser();

        ICollection<Liquid> GetAll();

        Liquid GetById(Guid id);
    }
}
