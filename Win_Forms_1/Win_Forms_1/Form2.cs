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
            form1.txtUserName.Text = "";
            form1.txtUserName.Focus();
            form1.txtpassword2.Text = "";
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
            AtualizarNomeVendedor();
            
        }
        private void AtualizarNomeVendedor()
        {
            formrenda.lbNomeFuncionario.Text = form1.txtUserName.Text;
            formrenda.lbCargo.Text = "Vendedor(a)";
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
            AtualizarNomeVendedorTelaEstoque();
        }
        private void AtualizarNomeVendedorTelaEstoque()
        {
            formestoque.lbNomeFuncionario.Text = form1.txtUserName.Text;
            formestoque.lbCargo.Text = "Vendedor(a)";
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapt = null;
            if (tbNumeroProduto.Text != "")
            {
                try
                {
                    adapt = BD.BuscarNumeroProduto(tbNumeroProduto.Text);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro!" + ex);
                }
                finally
                {
                    if (adapt != null)
                    {
                        DataTable tb = new DataTable();
                        adapt.Fill(tb);
                        dgvProdutos.DataSource = tb;
                        dgvProdutos.ClearSelection();
                        tbNumeroProduto.Clear();
                        tbNumeroProduto.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o número do produto!");
                tbNumeroProduto.Clear();
                tbNumeroProduto.Focus();
            }
        }
        public static double Total = 0;
        private void btEfetuarVenda_Click(object sender, EventArgs e)
        {
            if (dgvCarrinho.Rows.Count > 0)
            {
                int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
                int idProduto = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;
                string numeroProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[1].Value;
                string nomeProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
                string marcaProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[3].Value;
                string descricaoProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[4].Value;
                string precoProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[5].Value;

                try
                {
                    DialogResult msg = MessageBox.Show("O pagamento foi realizado corretamente?",
                        "Confirmação", MessageBoxButtons.YesNo);
                    if (msg == DialogResult.Yes)
                    {
                        MessageBox.Show("Compra finalizada com sucesso!");
                        BD.RegistrarVenda(new Vendas(idProduto,numeroProduto,nomeProduto,marcaProduto,descricaoProduto,
                            precoProduto));
                        ListarVendas();
                    }
                    else
                    {
                        MessageBox.Show("Efetue o pagamento!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao finalizar compra!");
                }
                finally
                {
                    double num = 0;
                    lbTotalAPagar.Text = num.ToString();
                    BD.ExcluirCarrinho();
                    ListaCarrinho();
                }
            }
            else
            {
                MessageBox.Show("Nao há itens no seu carrinho!");
            }
        }
        public void ListarVendas()
        {
            //AtualizarFormRenda
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectVendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não há vendas registradas");
            }
            finally
            {
                if (adapt != null)
                {
                    DataTable tab = new DataTable();
                    adapt.Fill(tab);
                    formrenda.dgvRendaDiaria.DataSource = tab;
                    AtualizarRenda();
                    formrenda.dgvRendaDiaria.ClearSelection();
                }
            }
        }
        public void AtualizarRenda()
        {
            Total = 0;
            foreach (DataGridViewRow linha in formrenda.dgvRendaDiaria.Rows)
            {
                Total += Convert.ToDouble(linha.Cells[6].Value);
            }
            formrenda.lbValorDiario.Text = "R$ " + Total.ToString();
        }
        private void btAddCarrinho_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
                int idProduto = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;

                string numeroProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[1].Value;
                string nomeProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
                string marcaProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[3].Value;
                string descricaoProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[4].Value;
                string precoProduto = (string)dgvProdutos.Rows[linhaSelecionada].Cells[5].Value;

                BD.InserirNoCarrinho(new CarrinhoCompras(idProduto, numeroProduto, nomeProduto, marcaProduto, descricaoProduto,
                    precoProduto));
                ListaCarrinho();
                
            }
            else
            {
                MessageBox.Show("Selecione o produto a ser adicionado!");
            }
        }
        public void ListaCarrinho()
        {
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectItensCarrinho();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não há itens no seu carrinho!" + ex);
            }
            finally
            {
                if (adapt != null)
                {
                    DataTable tab = new DataTable();
                    adapt.Fill(tab);
                    dgvCarrinho.DataSource = tab;
                    AtualizarPrecoCarrinho();
                    dgvCarrinho.ClearSelection();
                }
            }
        }
        public void AtualizarPrecoCarrinho()
        {
            Total = 0;
            foreach (DataGridViewRow linha in dgvCarrinho.Rows)
            {
                Total += Convert.ToDouble(linha.Cells[6].Value);
            }
            lbTotalAPagar.Text = "R$ " + Total.ToString();
        }

        private void btRemoverDoCarrinho_Click(object sender, EventArgs e)
        {
            if(dgvCarrinho.SelectedRows.Count > 0)
            {
                int linhaSelecionada = dgvCarrinho.SelectedCells[0].RowIndex;
                int idProduto = (int)dgvCarrinho.Rows[linhaSelecionada].Cells[0].Value;

                Total = Total - Convert.ToDouble(dgvCarrinho.Rows[dgvCarrinho.CurrentRow.Index].Cells[6].Value);
                lbTotalAPagar.Text = Total.ToString();

                dgvCarrinho.Rows.RemoveAt(dgvCarrinho.CurrentRow.Index);
                BD.DeletarDoCarrinho(idProduto);
                
            }
            else
            {
                MessageBox.Show("Selecione um item a ser removido!");
            }
        }
    }
}
