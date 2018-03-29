using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCV.Presentation.UI
{
    public partial class UcLabelTextBox : UserControl
    {
        public String Label { get { return ltLabel.Text; } set { ltLabel.Text = value; } }
        public bool EnableTextBox { get { return ltTextBox.Enabled; } set { ltTextBox.Enabled = value; } }
        public String TextBox { get { return ltTextBox.Text; } set { ltTextBox.Text = value; } }

        public UcLabelTextBox()
        {
            InitializeComponent();
        }

        private void ltLabel_Click(object sender, EventArgs e)
        {

        }

        private void ltTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ltLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void ltTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
