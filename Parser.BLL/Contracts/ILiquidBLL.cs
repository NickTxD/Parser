using System;
using System.Collections.Generic;
using Parser.Domain;

namespace Parser.BLL.Contracts
{
    public interface ILiquidBLL
    {
        ICollection<Liquid> SaveAll();

        Liquid CreateNew(int article, bool amountIndicated, bool strengthIndicated, string link, string name, bool availability, int price, List<double> strength, List<int> amount);
        ICollection<Liquid> GetAll();

        Liquid GetById(Guid id);
    }
}
