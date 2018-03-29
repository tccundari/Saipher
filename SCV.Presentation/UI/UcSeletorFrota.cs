using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCV.Entity;
using SCV.Presentation.Controles;
using Ninject;
using SCV.Business.Modulos;
using SCV.Business;

namespace SCV.Presentation.UI
{
    public partial class UcSeletorFrota : UserControl
    {
        private VW_SCV_FROTA_AERONAVE _frota;
        private TB_SCV_COMPANHIA _companhia;

        public TB_SCV_COMPANHIA Companhia
        {
            get { return _companhia; }
            set
            {
                _companhia = value;
                FrotaSelecionada = null;
            }
        }

        public VW_SCV_FROTA_AERONAVE FrotaSelecionada {
            get { return _frota; }
            set
            {
                _frota = value;

                if (_frota == null)
                {
                    txtAeronave.Text = "Nenhuma Aeronave Selecionada.";
                }
                else
                {
                    txtAeronave.Text = string.Concat("Aeronave: ", _frota.NM_NOME_AERONAVE, " - ", _frota.NM_MATRICULA); 
                }
            }
        }

        public void SelecionarPorIDFrota(int idFrota)
        {
            Ninject.IKernel _kernel = new StandardKernel(new ModuloFrota());
            BusinessFrota bsFrota = _kernel.Get<BusinessFrota>();

            FrotaSelecionada = bsFrota.SelecionarFrotaAeronavePorID(idFrota);
        }

        public UcSeletorFrota()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(Companhia == null)
            {
                MessageBox.Show("Nenhuma Companhia foi selecionada");
                return;
            }

            frmSelecionarAeronaveFrota frmSelAeronave = new frmSelecionarAeronaveFrota(Companhia);
            frmSelAeronave.ShowDialog();

            FrotaSelecionada = frmSelAeronave.FrotaSelecionada;
        }
    }
}
