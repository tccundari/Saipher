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
    public partial class UcLabelDateTimePicker : UserControl
    {
        public String Label { get { return label1.Text; } set { label1.Text = value; } }

        public DateTime DateTimePicker { get { return dateTimePicker1.Value; } set { dateTimePicker1.Value = value; } }

        public UcLabelDateTimePicker()
        {
            InitializeComponent();
        }

        private void UcLabelDateTimePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
