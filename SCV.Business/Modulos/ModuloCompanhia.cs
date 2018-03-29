using Ninject.Modules;
using SCV.Domain.Interface;
using SCV.Entity;

namespace SCV.Business.Modulos
{
    public class ModuloCompanhia : NinjectModule
    {
        public override void Load()
        {
            Bind<ISelecao<TB_SCV_COMPANHIA>>().To<BusinessCompanhia>();
        }
    }
}
