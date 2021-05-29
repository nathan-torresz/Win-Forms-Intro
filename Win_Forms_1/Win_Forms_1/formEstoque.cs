using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Forms_1
{
    public partial class formEstoque : Form
    {
        private FormInterface forminterface;
        public formEstoque(FormInterface forminterface)
        {
            InitializeComponent();
            this.forminterface = forminterface;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            forminterface.Show();
            this.Hide();
        }
    }
}
