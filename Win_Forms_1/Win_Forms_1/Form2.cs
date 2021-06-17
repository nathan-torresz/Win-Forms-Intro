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
            AtualizarNomeVendedorvendas();
        }
        private void AtualizarNomeVendedorvendas()
        {
            formvendas.lbNomeFuncionario.Text = form1.txtUserName.Text;
            formvendas.lbCargo.Text = "Vendedor(a)";
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
            formvendas.AtualizarNomeEstabelecimento();

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
            if(dgvCarrinho.Rows.Count > 0)
            {
                try
                {
                    DialogResult msg = MessageBox.Show("O pagamento foi realizado corretamente?",
                        "Confirmação", MessageBoxButtons.YesNo);
                    if (msg == DialogResult.Yes)
                    {
                        //Acrescenta todos os itens do carrinho em vendas.
                        for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                        {
                            int linhaSelecionada = i;
                            int idProduto = (int)dgvCarrinho.Rows[linhaSelecionada].Cells[1].Value;
                            string numeroProduto = (string)dgvCarrinho.Rows[linhaSelecionada].Cells[2].Value;
                            string nomeProduto = (string)dgvCarrinho.Rows[linhaSelecionada].Cells[3].Value;
                            string marcaProduto = (string)dgvCarrinho.Rows[linhaSelecionada].Cells[4].Value;
                            string descricaoProduto = (string)dgvCarrinho.Rows[linhaSelecionada].Cells[5].Value;
                            string precoProduto = (string)dgvCarrinho.Rows[linhaSelecionada].Cells[6].Value;

                            BD.RegistrarVenda(idProduto, new Produto(numeroProduto, nomeProduto, marcaProduto, descricaoProduto,
                                precoProduto));
                        }
                        MessageBox.Show("Compra finalizada com sucesso!");
                        try
                        {
                            BD.ExcluirCarrinho();
                            double num = 0;
                            lbTotalAPagar.Text = num.ToString();
                            ListarPrecoVendas();
                            ListarVendas();
                            ListaCarrinho();
                            tbNumeroProduto.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível limpar o carrinho!" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Efetue o pagamento!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao finalizar compra!" + ex);
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
                    formvendas.dgvVendidos.DataSource = tab;
                    formvendas.dgvVendidos.ClearSelection();
                }
            }
        }
        public void ListarPrecoVendas()
        {
            //AtualizarFormRenda
            SqlDataAdapter adapt = null;
            try
            {
                adapt = BD.SelectPrecoVendas();
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
                    formrenda.AtualizarRenda();
                    formrenda.dgvRendaDiaria.ClearSelection();
                }
            }
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

                BD.InserirNoCarrinho(idProduto, new Produto(numeroProduto, nomeProduto, marcaProduto, descricaoProduto,
                    precoProduto));
                ListaCarrinho();

            }
            else
            {
                MessageBox.Show("Selecione o produto a ser adicionado!");
            }
            tbNumeroProduto.Focus();
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
            if (dgvCarrinho.SelectedRows.Count > 0)
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

        private void tbNumeroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btBuscar_Click(this, new EventArgs());
            }
        }
        private void FormInterface_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                int largura = Convert.ToInt32(this.Size.Width * 0.98f);
                int altura = Convert.ToInt32(this.Size.Height * 0.21f);
                dgvProdutos.Size = new Size(largura, altura);
                dgvCarrinho.Size = new Size(largura, altura);
                int dgvX = Convert.ToInt32(this.Location.X * (-1));
                int dgvY = Convert.ToInt32(this.Location.Y * (-65));
                dgvCarrinho.Location = new Point(dgvX,dgvY);
                int dgvProdX = Convert.ToInt32(this.Location.X * (-1));
                int dgvProdY = Convert.ToInt32(this.Location.Y * (-40));
                dgvProdutos.Location = new Point(dgvProdX, dgvProdY);

                int locateX = Convert.ToInt32(this.Location.X * (-150f));
                int locateY = Convert.ToInt32(this.Location.Y * (-95));
                lbTotalAPagar.Location = new Point(locateX, locateY);
                int larguraLbTotalPagar = Convert.ToInt32(this.Size.Width * 0.2f);
                int alturaLbTotalPagar = Convert.ToInt32(this.Size.Height * 0.06);
                lbTotalAPagar.Size = new Size(larguraLbTotalPagar, alturaLbTotalPagar);

                int locateNovaVenda = Convert.ToInt32(this.Location.X * (-80));
                lbNovaVenda.Location = new Point(locateNovaVenda);
                int locateTbTotalPagar = Convert.ToInt32(this.Location.X * (-82));
                int locateTbTotalPagarY = Convert.ToInt32(this.Location.Y * (-30));
                tbNumeroProduto.Location = new Point(locateTbTotalPagar,locateTbTotalPagarY);
                int locateLbNumProduto = Convert.ToInt32(this.Location.X * (-68));
                int locateLbNumProdutoY = Convert.ToInt32(this.Location.Y * (-30));
                lbNumProduto.Location = new Point(locateLbNumProduto,locateLbNumProdutoY);

                int locateEfetuarVenda = Convert.ToInt32(this.Location.X * (-75));
                int locateEfetuarVendaY = Convert.ToInt32(this.Location.Y * (-98));
                btEfetuarVenda.Location = new Point(locateEfetuarVenda,locateEfetuarVendaY);
                int larguraBtVender = Convert.ToInt32(this.Size.Width * 0.3f);
                int alturaBtVender = Convert.ToInt32(this.Size.Height * 0.05f);
                btEfetuarVenda.Size = new Size(larguraBtVender, alturaBtVender);

                int locateAddCart = Convert.ToInt32(this.Location.X * (-3));
                int locateAddCartY = Convert.ToInt32(this.Location.Y * (-90));
                btAddCarrinho.Location = new Point(locateAddCart, locateAddCartY);
                int larguraAddCart = Convert.ToInt32(this.Size.Width * 0.15f);
                int alturaAddCart = Convert.ToInt32(this.Size.Height * 0.055f);
                btAddCarrinho.Size = new Size(larguraAddCart, alturaAddCart);

                int locateRemoveCart = Convert.ToInt32(this.Location.X * (-35));
                int locateRemoveCartY = Convert.ToInt32(this.Location.Y * (-90));
                btRemoverDoCarrinho.Location = new Point(locateRemoveCart, locateRemoveCartY);
                int larguraRemoveCart = Convert.ToInt32(this.Size.Width * 0.15f);
                int alturaRemoveCart = Convert.ToInt32(this.Size.Height * 0.055f);
                btRemoverDoCarrinho.Size = new Size(larguraRemoveCart, alturaRemoveCart);

                int locateBtBusca = Convert.ToInt32(this.Location.X * (-84));
                int locateBtBuscaY = Convert.ToInt32(this.Location.Y * (-35));
                btBuscar.Location = new Point(locateBtBusca,locateBtBuscaY);
            }
        }
    }
}