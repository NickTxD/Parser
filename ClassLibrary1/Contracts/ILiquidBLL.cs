using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser;

namespace ClassLibrary1.Contracts
{
    public interface ILiquidBLL
    {
        ICollection<Liquid> Parser();
    }
}
