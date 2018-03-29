using Ninject;
using SCV.Business;
using SCV.Business.Modulos;
using System;
using System.Windows.Forms;
using System.Linq;
using SCV.Entity;

namespace SCV.Presentation.Controles
{
    public partial class frmSelecionarAeronaveFrota : Form
    {
        private Entity.TB_SCV_COMPANHIA _companhia;

        public VW_SCV_FROTA_AERONAVE FrotaSelecionada;

        public frmSelecionarAeronaveFrota(Entity.TB_SCV_COMPANHIA objCompanhia)
        {
            InitializeComponent();

            _companhia = objCompanhia;
            lblCompanhia.Text = "Frota de " + _companhia.NM_COMPANHIA;
        }

        private void frmSelecionarAeronaveFrota_Load(object sender, EventArgs e)
        {
            if (_companhia == null)
                return;

            Ninject.IKernel _kernel = new StandardKernel(new ModuloFrota());
            BusinessFrota frota = _kernel.Get<BusinessFrota>();

            dgvSelecaoFrota.DataSource = frota.SelecionarFrotaAeronavePorIDCompanhia(_companhia.ID_SCV_COMPANHIA).ToList(); ;
        }

        private void dgvSelecaoFrota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                FrotaSelecionada = (VW_SCV_FROTA_AERONAVE)senderGrid.Rows[e.RowIndex].DataBoundItem;
                this.Close();
            }
        }
    }
}
