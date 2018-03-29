using Ninject.Modules;
using SCV.Domain.Interface;
using SCV.Entity;

namespace SCV.Business.Modulos
{
    public class ModuloFrota : NinjectModule
    {
        public override void Load()
        {
            Bind<IFrota<TB_SCV_FROTA>>().To<BusinessFrota>();
        }
    }
}
