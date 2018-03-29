using SCV.Entity;
using SCV.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Facade
{
    public class FacadeCentroOperacao
    {
        public static TB_SCV_CENTRO_OPERACAO SelecionarCentroOperacaoPorId(int idCentroOperacao)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_CENTRO_OPERACAO.FirstOrDefault(x => x.BT_ATIVO && x.ID_SCV_CENTRO_OPERACAO == idCentroOperacao);
            }
        }

        public static IEnumerable<TB_SCV_CENTRO_OPERACAO> SelecionarCentrosOperacaoAtivos()
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_CENTRO_OPERACAO.Where(x => x.BT_ATIVO).ToList();
            }
        }
    }
}
