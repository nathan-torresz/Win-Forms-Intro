﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Win_Forms_1
{
    public partial class formEstoque : Form
    {
        private FormInterface forminterface;
        private Form1 form1;
        public formEstoque(FormInterface forminterface, Form1 form1)
        {
            InitializeComponent();
            this.forminterface = forminterface;
            this.form1 = form1;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            forminterface.Show();
            this.Hide();
        }

        public void AtualizarListaEstoque()
        {

            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectProdutosExceptID();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!");
            }
            finally
            {
                if (adapt != null)
                {
                    DataTable tabela = new DataTable();
                    adapt.Fill(tabela);
                    dgvListaProdutos.DataSource = tabela;
                    dgvListaProdutos.ClearSelection();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
