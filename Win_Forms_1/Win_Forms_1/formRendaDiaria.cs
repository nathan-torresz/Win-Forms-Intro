using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Win_Forms_1
{
    public partial class formRendaDiaria : Form
    {
        private FormInterface forminterface;
        public formRendaDiaria(FormInterface forminterface)
        {
            InitializeComponent();
            this.forminterface = forminterface;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempoFormInterface();
            forminterface.dgvCarrinho.ClearSelection();
        }
        private void TempoFormInterface()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            forminterface.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void formRendaDiaria_Load(object sender, EventArgs e)
        {
            
        }
    }
}
