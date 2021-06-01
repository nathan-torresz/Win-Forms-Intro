using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Win_Forms_1
{
    public partial class FormInterface : Form
    {
        private Form1 form1;
        private formEstoque formestoque;
        private formVendas formvendas;
        private formRendaDiaria formrenda;
        public FormInterface(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            formvendas = new formVendas(this);
            formrenda = new formRendaDiaria(this);
            formestoque = new formEstoque(this, form1);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TempoForm1();
        }
        private void TempoForm1()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(1000);
            form1.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
            Thread.Sleep(500);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
            Thread.Sleep(500);
        }

        private void btvendas_Click(object sender, EventArgs e)
        {
            TempoFormVendas();
        }
        private void TempoFormVendas()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            formvendas.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void btRendaDiaria_Click(object sender, EventArgs e)
        {
            TempoFormRenda();
        }
        private void TempoFormRenda()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            formrenda.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            TempoFormEstoque();
        }
        private void TempoFormEstoque()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            formestoque.Show();
            formestoque.AtualizarListaEstoque();
            this.Cursor = Cursors.Default;
            this.Hide();
        }
    }
}
