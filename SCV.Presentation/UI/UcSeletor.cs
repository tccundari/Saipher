using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCV.Domain.Interface;

namespace SCV.Presentation.UI
{
    public partial class UcSeletor : UserControl
    {
        public String Label { get { return label1.Text; } set { label1.Text = value; } }
        public Object SelectedItem { get { return comboBox1.SelectedItem; } }
        public event EventHandler SelectedIndexChanged;

        public UcSeletor()
        {
            InitializeComponent();
        }

        public void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(sender, e);
        }

        public void CarregarComboBox<T>(List<T> lstItens, string displayName)
        {
            comboBox1.DataSource = lstItens;
            comboBox1.DisplayMember = displayName;
        }

        private void UcSeletor_Load(object sender, EventArgs e)
        {
        }
    }
}
