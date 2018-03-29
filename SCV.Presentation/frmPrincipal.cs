using SCV.Presentation.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCV.Presentation
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            UcHome ucHome = new UcHome();
            this.panel1.Controls.Add(ucHome);
        }

        private void planoDeVooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            UcModuloPlanoVoo ucPlanosVoo = new UcModuloPlanoVoo();
            this.panel1.Controls.Add(ucPlanosVoo);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            UcHome ucHome = new UcHome();
            this.panel1.Controls.Add(ucHome);
        }

        private void planoDeVooToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            UcModuloPlanoVoo ucPlanosVooCadastro = new UcModuloPlanoVoo();
            this.panel1.Controls.Add(ucPlanosVooCadastro);
        }
    }
}
