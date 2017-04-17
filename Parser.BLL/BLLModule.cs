using Ninject;
using Ninject.Modules;
using Parser.BLL.Contracts;
using Parser.BLL.Implementations;
using Parser.DAL;

namespace Parser.BLL
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
