using Ninject;
using SCV.Business;
using SCV.Business.Modulos;
using System;
using System.Windows.Forms;
using System.Linq;
using SCV.Entity;

namespace SCV.Presentation.Controles
{
    public partial class frmSelecionarCentroOperacoes : Form
    {
        public TB_SCV_CENTRO_OPERACAO CentroOperacaoSelecionado;

        public frmSelecionarCentroOperacoes()
        {
            InitializeComponent();
        }
        private void frmSelecionarAeronaveFrota_Load(object sender, EventArgs e)
        {
            Ninject.IKernel _kernel = new StandardKernel(new ModuloFrota());
            BusinessCentroOperacao centroOperacoes = _kernel.Get<BusinessCentroOperacao>();

            dgvSelecaoCentroOperacao.DataSource = centroOperacoes.SelecionarTodos().ToList(); ;
        }

        private void dgvSelecaoFrota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                CentroOperacaoSelecionado = (TB_SCV_CENTRO_OPERACAO)senderGrid.Rows[e.RowIndex].DataBoundItem;
                this.Close();
            }
        }
    }
}
