using SCV.DataObjects;
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
    /// Classe de Negócio para Regras e Eventos de Planos de Voo
    /// </summary>
    public class BusinessPlanoVoo : ICRUD<TB_SCV_PLANO_VOO>, IPlanoVoo<TB_SCV_PLANO_VOO>, ISelecao<VW_SCV_PLANO_VOO_INFORMACAO>
    {
        /// <summary>
        /// Atualizar as informações de um Plano de Voo
        /// </summary>
        /// <param name="objPlanoVoo">Objeto TB_SCV_PLANO_VOO contendo as novas informações do Plano de Voo</param>
        public void Atualizar(TB_SCV_PLANO_VOO objPlanoVoo)
        {
            ValidarPlanoVoo(objPlanoVoo);

            objPlanoVoo.DT_ATUALIZACAO = DateTime.Now;
            SCV.Facade.FacadePlanoVoo.AtualizarPlanoVoo(objPlanoVoo);
        }
        
        /// <summary>
        /// Criar um novo Plano de Voo
        /// </summary>
        /// <param name="objPlanoVoo">Objeto TB_SCV_PLANO_VOO com as informações do Plano de Voo</param>
        /// <returns>Plano de Voo criado</returns>
        public TB_SCV_PLANO_VOO Criar(TB_SCV_PLANO_VOO objPlanoVoo)
        {
            ValidarPlanoVoo(objPlanoVoo, true);

            objPlanoVoo.DT_CADASTRO = DateTime.Now;
            objPlanoVoo.DT_ATUALIZACAO = DateTime.Now;
            return SCV.Facade.FacadePlanoVoo.CriarPlanoVoo(objPlanoVoo);
        }

        /// <summary>
        /// Excluir Plano de Voo
        /// </summary>
        /// <param name="objPlanoVoo">Objeto TB_SCV_PLANO_VOO contendo as novas informações do Plano de Voo</param>
        public void Excluir(TB_SCV_PLANO_VOO objPlanoVoo) => SCV.Facade.FacadePlanoVoo.ExcluirPlanoVoo(objPlanoVoo);

        /// <summary>
        /// Excluir um Plano de Voo através do objeto VW_SCV_PLANO_VOO_INFORMACAO
        /// </summary>
        /// <param name="objInfoPlanoVoo">Objeto VW_SCV_PLANO_VOO_INFORMACAO</param>
        public void Excluir(VW_SCV_PLANO_VOO_INFORMACAO objInfoPlanoVoo) => SCV.Facade.FacadePlanoVoo.ExcluirPlanoVoo(objInfoPlanoVoo);

        /// <summary>
        /// Selecionar Planos de Voos por Data do Voo
        /// </summary>
        /// <param name="dtVoo"></param>
        /// <returns>Lista de objetos TB_SCV_PLANO_VOO contendo as informações dos Planos de Voo</returns>
        public IEnumerable<TB_SCV_PLANO_VOO> SelecionarPorData(DateTime dtVoo) => SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooPorData(dtVoo);

        /// <summary>
        /// Selecionar Plano de Voo por ID
        /// </summary>
        /// <param name="idPlano">ID do Plano de Voo</param>
        /// <returns>Objeto TB_SCV_PLANO_VOO contendo as informações do Plano de Voo</returns>
        public TB_SCV_PLANO_VOO SelecionarPlanoVooPorID(int idPlanoVoo) => SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooPorID(idPlanoVoo);

        /// <summary>
        /// Selecionar Planos de Voos por Centro de Operação Origem/Destino
        /// </summary>
        /// <param name="idCentroOperacoesOrigem">ID do Centro de Operação de Origem</param>
        /// <param name="idCentroOperacoesDestino">ID do Centro de Operação de Destino</param>
        /// <returns>Lista de objetos TB_SCV_PLANO_VOO contendo as informações dos Planos de Voo</returns>
        /// <remarks>Para desconsiderar Origem ou Destino enviar ID = 0</remarks>
        public IEnumerable<TB_SCV_PLANO_VOO> SelecionarPorOrigemDestino(int idCentroOperacaoOrigem, int idCentroOperacaoDestino) => SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooPorOrigemDestino(idCentroOperacaoOrigem, idCentroOperacaoDestino);

        /// <summary>
        /// Verificar se uma Aeronave está disponível em uma determinada data
        /// </summary>
        /// <param name="idFrota">ID da aeronave da frota</param>
        /// <param name="dtVoo">Data do Voo</param>
        /// <returns>True para Disponível</returns>
        public bool ChecarDisponibilidadeAeronave(int idFrota, DateTime dtVoo)
        {
            return !SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooPorData(dtVoo).Any(x => x.FK_SCV_FROTA == idFrota);
        }

        /// <summary>
        /// Selecionar as informações dos planos de voo
        /// </summary>
        /// <returns>Lista de Objetos VW_SCV_PLANO_VOO_INFORMACAO</returns>
        public IEnumerable<VW_SCV_PLANO_VOO_INFORMACAO> SelecionarTodos()
        {
            return SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooInformacao().OrderBy(x => x.DT_ATUALIZACAO).ToList();
        }

        /// <summary>
        /// Selecionar as informações de um Plano de Voo por ID
        /// </summary>
        /// <param name="idPlanoVoo">ID do plano de Voo</param>
        /// <returns>Objeto VW_SCV_PLANO_VOO_INFORMACAO</returns>
        public VW_SCV_PLANO_VOO_INFORMACAO SelecionarPorID(int idPlanoVoo)
        {
            return SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooInformacaoPorID(idPlanoVoo);
        }

        /// <summary>
        /// Filtrar Informações de Planos de Voo
        /// </summary>
        /// <param name="numeroVoo">Número do plano de voo</param>
        /// <param name="idCentroOperacaoOri">Centro de Operações Origem</param>
        /// <param name="idCentroOperacaoDes">Centro de Operações Destino</param>
        /// <returns>Lista de Objetos VW_SCV_PLANO_VOO_INFORMACAO</returns>
        public IEnumerable<VW_SCV_PLANO_VOO_INFORMACAO> SelecionarPorNumeroVooOrigemDestino(string numeroVoo, int idCentroOperacaoOri, int idCentroOperacaoDes)
        {
            return SCV.Facade.FacadePlanoVoo.SelecionarPlanoVooInformacao(numeroVoo, idCentroOperacaoOri, idCentroOperacaoDes).ToList();
        }

        /// <summary>
        /// Validar as propriedades de um plano de Voo
        /// </summary>
        /// <param name="objPlanoVoo">Objeto TB_SCV_PLANO_VOO contendo as informações de um Plano de Voo para validar</param>
        private void ValidarPlanoVoo(TB_SCV_PLANO_VOO objPlanoVoo, bool novo = false)
        {
            if(objPlanoVoo == null)
                throw new ApplicationException("Plano de Voo não é válido");
            if (!novo && objPlanoVoo.ID_SCV_PLANO_VOO < 1)
                throw new ApplicationException("Plano de Voo inválido: ID");
            if (objPlanoVoo.FK_SCV_CENTRO_OPERACAO_DESTINO < 1 || objPlanoVoo.FK_SCV_CENTRO_OPERACAO_ORIGEM < 1)
                throw new ApplicationException("Plano de Voo inválido: ORIGEM/DESTINO");
            if (objPlanoVoo.FK_SCV_CENTRO_OPERACAO_DESTINO == objPlanoVoo.FK_SCV_CENTRO_OPERACAO_ORIGEM)
                throw new ApplicationException("Plano de Voo inválido: ORIGEM e DESTINO não podem ser iguais");
            if (objPlanoVoo.FK_SCV_COMPANHIA < 1)
                throw new ApplicationException("Plano de Voo inválido: COMPANHIA");
            if (objPlanoVoo.FK_SCV_FROTA < 1)
                throw new ApplicationException("Plano de Voo inválido: FROTA");
            if(objPlanoVoo.DT_VOO < DateTime.Today)
                throw new ApplicationException("Plano de voo não pode ser agendado para uma data passada");
            if(novo && !ChecarDisponibilidadeAeronave(objPlanoVoo.FK_SCV_FROTA, objPlanoVoo.DT_VOO))
                throw new ApplicationException("Esta Aeronave já está agendada para um voo no dia: " + objPlanoVoo.DT_VOO.ToString("dd/MM/yyyy"));

        }
    }
}
