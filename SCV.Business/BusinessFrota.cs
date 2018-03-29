using SCV.Entity;
using SCV.Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SCV.Business
{
    /// <summary>
    /// Classe de Negócio para Regras e Eventos de Frotas
    /// </summary>
    public class BusinessFrota : IFrota<TB_SCV_FROTA>
    {
        /// <summary>
        /// Selecionar uma Frota pelo ID
        /// </summary>
        /// <param name="idFrota">ID da frota</param>
        /// <returns>Objeto TB_SCV_FROTA</returns>
        public TB_SCV_FROTA SelecionarPorID(int idFrota) => SCV.Facade.FacadeFrota.SelecionarFrotaPorId(idFrota);

        /// <summary>
        /// Selecionar todas as Frotas de uma companhia
        /// </summary>
        /// <returns>Lista de Objetos TB_SCV_FROTA</returns>
        public IEnumerable<TB_SCV_FROTA> SelecionarPorIDCompanhia(int idCompanhia) => SCV.Facade.FacadeFrota.SelecionarFrotaPorIdCompanhia(idCompanhia).OrderBy(x => x.NM_MATRICULA);

        public TB_SCV_FROTA SelecionarPorFrotaAeronava(VW_SCV_FROTA_AERONAVE objFrotaAeronave)
        {
            if (objFrotaAeronave == null || objFrotaAeronave.ID_SCV_FROTA < 1)
                throw new ApplicationException("Não é possível selecionar uma Aeronave da frota.");

            return SCV.Facade.FacadeFrota.SelecionarFrotaPorId(objFrotaAeronave.ID_SCV_FROTA);
        }

        /// <summary>
        /// Selecionar todas as informações de Frotas e suas Aeronaves de uma companhia
        /// </summary>
        /// <returns>Lista de Objetos VW_SCV_FROTA_AERONAVE</returns>
        public IEnumerable<VW_SCV_FROTA_AERONAVE> SelecionarFrotaAeronavePorIDCompanhia(int idCompanhia) => SCV.Facade.FacadeFrota.SelecionarFrotaAeronavePorIdCompanhia(idCompanhia).OrderBy(x => x.NM_MATRICULA);

        /// <summary>
        /// Selecionar todas as informações de Frota e sua Aeronave pela ID da Frota
        /// </summary>
        /// <param name="idFrota">ID da Frota</param>
        /// <returns>Objeto VW_SCV_FROTA_AERONAVE</returns>
        public VW_SCV_FROTA_AERONAVE SelecionarFrotaAeronavePorID(int idFrota) => SCV.Facade.FacadeFrota.SelecionarFrotaAeronavePorIdFrota(idFrota);
    }
}
