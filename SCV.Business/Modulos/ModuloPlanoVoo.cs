using Ninject.Modules;
using SCV.Domain.Interface;
using SCV.Entity;

namespace SCV.Business.Modulos
{
    public class ModuloPlanoVoo : NinjectModule
    {
        public override void Load()
        {
            Bind<ICRUD<TB_SCV_PLANO_VOO>>().To<BusinessPlanoVoo>();
            Bind<IPlanoVoo<TB_SCV_PLANO_VOO>>().To<BusinessPlanoVoo>();
            Bind<ISelecao<VW_SCV_PLANO_VOO_INFORMACAO>>().To<BusinessPlanoVoo>();
        }
    }
}
