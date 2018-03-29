using Ninject.Modules;
using SCV.Domain.Interface;
using SCV.Entity;

namespace SCV.Business.Modulos
{
    public class ModuloCentroOperacao : NinjectModule
    {
        public override void Load()
        {
            Bind<ISelecao<TB_SCV_CENTRO_OPERACAO>>().To<BusinessCentroOperacao>();
        }
    }
}
