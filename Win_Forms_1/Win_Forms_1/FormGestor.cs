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
    public partial class FormGestor : Form
    {
        private Form1 form1;
        public FormGestor(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void AtualizarProdutos()
        {
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectNumeroNomeProdutos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!");
            }
            finally
            {
                if(adapt != null)
                {
                    DataTable tabela = new DataTable();
                    adapt.Fill(tabela);
                    dgvListaProdutos.DataSource = tabela;
                    dgvListaProdutos.ClearSelection();
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            TempoForm1();
        }
        private void TempoForm1()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            form1.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void FormGestor_Load(object sender, EventArgs e)
        {
            AtualizarProdutos();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            string nome = tbNome.Text;
            string numero = tbNumero.Text;
            string descricao = tbDescricao.Text;
            string marca = tbMarca.Text;
            string preco = mbPreco.Text;

            try
            {
               i = BD.InserirProduto(new Produto(numero, nome, marca, descricao, preco));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto!" + ex);
            }
            finally
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                AtualizarProdutos();
                tbNome.Clear();
                tbNumero.Clear();
                tbDescricao.Clear();
                tbMarca.Clear();
                mbPreco.Clear();
            }
        }
    }
}
