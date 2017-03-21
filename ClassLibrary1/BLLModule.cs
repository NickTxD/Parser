using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Contracts;
using ClassLibrary1.Implementations;
using Ninject.Modules;

namespace BLLModule
{
    public class BLLModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILiquidBLL>().To<LiquidBLL>();
        }
    }
}
