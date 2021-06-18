﻿using System;
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
    public partial class formVendas : Form
    {
        private FormInterface forminterface;
        public formVendas(FormInterface forminterface)
        {
            InitializeComponent();
            this.forminterface = forminterface;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            
        }
        private void TempoFormInterface()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            forminterface.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }
        public void AtualizarNomeEstabelecimento()
        {
            lbNomeEstabelecimento.Text = forminterface.lbEstabelecimento.Text;
        }
        private void btVoltar_Click_1(object sender, EventArgs e)
        {
            TempoFormInterface();
            forminterface.tbNumeroProduto.Focus();
        }
    }
}
