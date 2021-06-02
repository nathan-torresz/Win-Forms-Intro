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
    public partial class FormCadastro : Form
    {
        private Form1 form1;
        public FormCadastro(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string nome = tbNomeCadastro.Text;
            string cpf = tbCPFCadastro.Text;
            string telefone = tbTelefone.Text;
            string email = tbEmailCadastro.Text;
            string senha = tbSenhaCadastro.Text;
            string cargo = cbCargo.Text;

            TempoFormCadastro();

            try
            {
                i = BD.InserirFuncionario(new Funcionario(nome,cpf,telefone,email,senha,cargo));
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Erro ao cadastrar!");
            }
            finally
            {
                MessageBox.Show($"Cadastro de {tbNomeCadastro.Text} efetuado com sucesso!");
                tbNomeCadastro.Clear();
                tbCPFCadastro.Clear();
                tbTelefone.Clear();
                tbEmailCadastro.Clear();
                tbSenhaCadastro.Clear();
                tbNomeCadastro.Focus();
            }
        }
        private void TempoFormCadastro()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            form1.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            tbNomeCadastro.Clear();
            tbCPFCadastro.Clear();
            tbTelefone.Clear();
            tbEmailCadastro.Clear();
            tbSenhaCadastro.Clear();    
            tbNomeCadastro.Focus();
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
    }
}
