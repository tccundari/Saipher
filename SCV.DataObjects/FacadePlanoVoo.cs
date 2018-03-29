using SCV.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Facade
{
    public class FacadePlanoVoo 
    {
        public static TB_SCV_PLANO_VOO CriarPlanoVoo(TB_SCV_PLANO_VOO objPlanoVoo)
        {
            using(SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                db.TB_SCV_PLANO_VOO.InsertOnSubmit(objPlanoVoo);
                db.SubmitChanges();
            }

            return objPlanoVoo;
        }

        public static void AtualizarPlanoVoo(TB_SCV_PLANO_VOO objPlanoVoo)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                var planoVoo = db.TB_SCV_PLANO_VOO.FirstOrDefault(x => x.ID_SCV_PLANO_VOO == objPlanoVoo.ID_SCV_PLANO_VOO);
                planoVoo.BT_ATIVO = objPlanoVoo.BT_ATIVO;
                planoVoo.DT_VOO = objPlanoVoo.DT_VOO;
                planoVoo.FK_SCV_CENTRO_OPERACAO_DESTINO = objPlanoVoo.FK_SCV_CENTRO_OPERACAO_DESTINO;
                planoVoo.FK_SCV_CENTRO_OPERACAO_ORIGEM = objPlanoVoo.FK_SCV_CENTRO_OPERACAO_ORIGEM;
                planoVoo.FK_SCV_COMPANHIA = objPlanoVoo.FK_SCV_COMPANHIA;
                planoVoo.FK_SCV_FROTA = objPlanoVoo.FK_SCV_FROTA;

                db.SubmitChanges();
            }
        }

        public static void ExcluirPlanoVoo(TB_SCV_PLANO_VOO objPlanoVoo)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                var planoVoo = db.TB_SCV_PLANO_VOO.FirstOrDefault(x => x.ID_SCV_PLANO_VOO == objPlanoVoo.ID_SCV_PLANO_VOO);                
                db.TB_SCV_PLANO_VOO.DeleteOnSubmit(planoVoo);
                db.SubmitChanges();
            }
        }

        public static void ExcluirPlanoVoo(VW_SCV_PLANO_VOO_INFORMACAO objPlanoVoo)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                var planoVoo = db.TB_SCV_PLANO_VOO.FirstOrDefault(x => x.ID_SCV_PLANO_VOO == objPlanoVoo.ID_SCV_PLANO_VOO);
                db.TB_SCV_PLANO_VOO.DeleteOnSubmit(planoVoo);
                db.SubmitChanges();
            }
        }

        public static TB_SCV_PLANO_VOO SelecionarPlanoVooPorID(int idPlano)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_PLANO_VOO.FirstOrDefault(x => x.ID_SCV_PLANO_VOO == idPlano);
            }
        }

        public static IEnumerable<TB_SCV_PLANO_VOO> SelecionarPlanoVooPorOrigemDestino(int idCentroOperacoesOrigem, int idCentroOperacoesDestino)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_PLANO_VOO.Where(x => (x.FK_SCV_CENTRO_OPERACAO_DESTINO == idCentroOperacoesDestino || idCentroOperacoesDestino == 0) 
                    && (x.FK_SCV_CENTRO_OPERACAO_ORIGEM == idCentroOperacoesOrigem || idCentroOperacoesOrigem == 0) &&
                    x.BT_ATIVO).ToList();
            }
        }

        public static IEnumerable<TB_SCV_PLANO_VOO> SelecionarPlanoVooPorData(DateTime dtVoo)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_PLANO_VOO.Where(x => x.DT_VOO.Date == dtVoo.Date && x.BT_ATIVO).ToList();
            }
        }
        
        public static IEnumerable<VW_SCV_PLANO_VOO_INFORMACAO> SelecionarPlanoVooInformacao()
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.VW_SCV_PLANO_VOO_INFORMACAO.ToList();
            }
        }

        public static VW_SCV_PLANO_VOO_INFORMACAO SelecionarPlanoVooInformacaoPorID(int idPlanoVoo)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.VW_SCV_PLANO_VOO_INFORMACAO.FirstOrDefault(x => x.ID_SCV_PLANO_VOO == idPlanoVoo);
            }
        }

        public static IEnumerable<VW_SCV_PLANO_VOO_INFORMACAO> SelecionarPlanoVooInformacao(string numeroVoo, int centroOperacaoOri, int centroOperacaoDes)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.VW_SCV_PLANO_VOO_INFORMACAO.Where(x => 
                    (x.NUMERO_VOO == numeroVoo || numeroVoo == string.Empty) &&
                    (x.ID_SCV_CENTRO_OPERACAO_ORIGEM == centroOperacaoOri || centroOperacaoOri == 0) &&
                    (x.ID_SCV_CENTRO_OPERACAO_DESTINO == centroOperacaoDes || centroOperacaoDes == 0)).ToList();
            }
        }

    }
}
