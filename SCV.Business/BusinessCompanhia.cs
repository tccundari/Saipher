using SCV.Entity;
using SCV.Domain.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SCV.Business
{
    /// <summary>
    /// Classe de Negócio para Regras e Eventos de Companhias
    /// </summary>
    public class BusinessCompanhia : ISelecao<TB_SCV_COMPANHIA>
    {
        /// <summary>
        /// Selecionar uma Companhia pelo ID
        /// </summary>
        /// <param name="idCompanhia">ID da companhia</param>
        /// <returns>Objeto TB_SCV_COMPANHIA</returns>
        public TB_SCV_COMPANHIA SelecionarPorID(int idCompanhia) => SCV.Facade.FacadeComapnhia.SelecionarCompanhiaPorID(idCompanhia);

        /// <summary>
        /// Selecionar todas as Compnahias que estejam ativas
        /// </summary>
        /// <returns>Lista de Objetos TB_SCV_COMPANHIA</returns>
        public IEnumerable<TB_SCV_COMPANHIA> SelecionarTodos() => SCV.Facade.FacadeComapnhia.SelecionarCompanhiasAtivas().OrderBy(x => x.NM_COMPANHIA);
    }
}
