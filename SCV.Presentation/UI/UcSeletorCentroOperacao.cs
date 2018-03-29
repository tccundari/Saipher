using System;
using System.Windows.Forms;
using Ninject;
using SCV.Business;
using SCV.Business.Modulos;
using SCV.Entity;
using SCV.Presentation.Controles;

namespace SCV.Presentation.UI
{
    public partial class UcSeletorCentroOperacao : UserControl
    {
        private TB_SCV_CENTRO_OPERACAO _centroOperacao;
        public String Titulo { get { return lblTitulo.Text; } set { lblTitulo.Text = value; } }

        public TB_SCV_CENTRO_OPERACAO CentroOperacaoSelecionado
        {
            get { return _centroOperacao; }
            set
            {
                _centroOperacao = value;

                if (_centroOperacao == null)
                {
                    txtCentroOperacao.Text = "Nenhum Centro de Operação Selecionado";
                }
                else
                {
                    txtCentroOperacao.Text = string.Concat(_centroOperacao.NM_ICAO, " - ", _centroOperacao.NM_LOCALIZACAO);
                }
            }
        }

        public void SelecionarPorIDCentroOperacao(int idCentroOperacao)
        {
            Ninject.IKernel _kernel = new StandardKernel(new ModuloCentroOperacao());
            BusinessCentroOperacao bscentroOperacao = _kernel.Get<BusinessCentroOperacao>();

            CentroOperacaoSelecionado = bscentroOperacao.SelecionarPorID(idCentroOperacao);
        }

        public UcSeletorCentroOperacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSelecionarCentroOperacoes frmSelCentroOperacao = new frmSelecionarCentroOperacoes();
            frmSelCentroOperacao.ShowDialog();

            CentroOperacaoSelecionado = frmSelCentroOperacao.CentroOperacaoSelecionado;
        }
    }
}
