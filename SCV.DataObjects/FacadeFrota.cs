using SCV.Entity;
using SCV.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Facade
{
    public class FacadeFrota
    {
        public static IEnumerable<TB_SCV_FROTA> SelecionarFrotaPorIdCompanhia(int idCompanhia)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_FROTA.Where(x => x.BT_ATIVO && x.FK_SCV_COMPANHIA == idCompanhia).ToList();
            }
        }

        public static TB_SCV_FROTA SelecionarFrotaPorId(int idFrota)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_FROTA.FirstOrDefault(x => x.BT_ATIVO && x.ID_SCV_FROTA == idFrota);
            }
        }

        public static IEnumerable<VW_SCV_FROTA_AERONAVE> SelecionarFrotaAeronavePorIdCompanhia(int idCompanhia)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.VW_SCV_FROTA_AERONAVE.Where(x => x.FK_SCV_COMPANHIA == idCompanhia).ToList();
            }
        }

        public static VW_SCV_FROTA_AERONAVE SelecionarFrotaAeronavePorIdFrota(int idFrota)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.VW_SCV_FROTA_AERONAVE.FirstOrDefault(x => x.ID_SCV_FROTA == idFrota);
            }
        }
    }
}
