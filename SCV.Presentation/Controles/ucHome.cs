using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCV.Presentation.Controles
{
    public partial class UcHome : UserControl
    {
        public UcHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            lblInformacoes.Text = "Candidato: Tiago Casagrande Cundari" + 
                Environment.NewLine + "Projeto: CRUD Planos de Voo em WindowsForms" +
                Environment.NewLine + "Framework: .Net Framework 4.6" +
                Environment.NewLine + "Ioc Container: Ninject" +
                Environment.NewLine + "ORM: LinqToSQL" +
                Environment.NewLine + "Bando de Dados: SQL Server 2017 Express";
        }
    }
}
