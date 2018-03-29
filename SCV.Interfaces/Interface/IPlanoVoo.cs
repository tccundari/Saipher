using System;
using System.Collections.Generic;

namespace SCV.Domain.Interface
{
    /// <summary>
    /// Interface de extensão para o a entidade TB_SCV_PLANO_VOO
    /// </summary>
    /// <typeparam name="TB_SCV_PLANO_VOO">Entidade TB_SCV_PLANO_VOO</typeparam>
    public interface IPlanoVoo<TB_SCV_PLANO_VOO>
    {
        IEnumerable<TB_SCV_PLANO_VOO> SelecionarPorOrigemDestino(int idCentroOperacaoOrigem, int idCentroOperacaoDestino);
        IEnumerable<TB_SCV_PLANO_VOO> SelecionarPorData(DateTime dt);
    }
}
