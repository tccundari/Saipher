using SCV.Entity;
using System;
using System.Collections.Generic;

namespace SCV.Domain.Interface
{
    public interface IFrota<TB_SCV_FROTA>
    {
        IEnumerable<TB_SCV_FROTA> SelecionarPorIDCompanhia(int idCompanhia);
        TB_SCV_FROTA SelecionarPorID(int idFrota);
        IEnumerable<VW_SCV_FROTA_AERONAVE> SelecionarFrotaAeronavePorIDCompanhia(int idCompanhia);
    }
}
