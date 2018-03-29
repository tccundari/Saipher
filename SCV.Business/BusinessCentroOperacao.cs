using SCV.Domain.Interface;
using SCV.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Business
{
    /// <summary>
    /// Classe de Negócio para Regras e Eventos de Centros de Operações
    /// </summary>
    public class BusinessCentroOperacao : ISelecao<TB_SCV_CENTRO_OPERACAO>
    {
        /// <summary>
        /// Selecionar um Centro de Operações pelo ID
        /// </summary>
        /// <param name="idCentroOperacao">ID do Centro de Operação</param>
        /// <returns>Objeto TB_SCV_CENTRO_OPERACAO</returns>
        public TB_SCV_CENTRO_OPERACAO SelecionarPorID(int idCentroOperacao) => SCV.Facade.FacadeCentroOperacao.SelecionarCentroOperacaoPorId(idCentroOperacao);

        /// <summary>
        /// Selecionar todos Centro de Operações que estejam ativos
        /// </summary>
        /// <returns>Lista de Objetos TB_SCV_CENTRO_OPERACAO</returns>
        public IEnumerable<TB_SCV_CENTRO_OPERACAO> SelecionarTodos() => SCV.Facade.FacadeCentroOperacao.SelecionarCentrosOperacaoAtivos().OrderBy(x => x.NM_CENTRO_OPERACAO);
    }
}
