using SCV.Entity;
using SCV.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Facade
{
    public class FacadeComapnhia
    {
        public static IEnumerable<TB_SCV_COMPANHIA> SelecionarCompanhiasAtivas()
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_COMPANHIA.Where(x => x.BT_ATIVO).ToList();
            }
        }

        public static TB_SCV_COMPANHIA SelecionarCompanhiaPorID(int idCompanhia)
        {
            using (SCVControleVooDataContext db = new SCVControleVooDataContext())
            {
                return db.TB_SCV_COMPANHIA.FirstOrDefault(x => x.BT_ATIVO && x.ID_SCV_COMPANHIA == idCompanhia);
            }
        }
    }
}
