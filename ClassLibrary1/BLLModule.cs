using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.Contracts;
using Parser.Implementations;
using Ninject.Modules;
using Parser.DAL;

namespace BLLModule
{
    public class BLLModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILiquidBLL>().To<LiquidBLL>();
            Bind<IRepository>().To<Repository>();
        }
    }
}
