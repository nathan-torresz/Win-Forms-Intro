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
    public partial class Form1 : Form
    {
        private FormInterface forminterface;
        private FormCadastro formcadastro;
        private FormGestor formgestor;

        public Form1()
        {
            InitializeComponent();
            forminterface = new FormInterface(this);
            formcadastro = new FormCadastro(this);
            formgestor = new FormGestor(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtpassword2.Text.Length >= Funcionario.TAM_MIN_SENHA)
            {
                Logar1();
                AtualizarNomeVendedor();
                AtualizarNomeEstabelecimento();
                forminterface.tbNumeroProduto.Focus();
            }
            else
            {
                MessageBox.Show("Insira o número correto de caracteres em: senha");
                txtpassword2.Clear();
                txtpassword2.Focus();
            }
        }
        private void AtualizarNomeEstabelecimento()
        {
            forminterface.lbEstabelecimento.Text = formcadastro.txtEstabelecimento.Text;
        }
        private void AtualizarNomeVendedor()
        {
            forminterface.lbNomeFuncionario.Text = txtUserName.Text;
            forminterface.lbCargo.Text = "Vendedor(a)";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtpassword2.Text.Length >= Funcionario.TAM_MIN_SENHA)
            {
                Logar2();
                AtualizarNomeGestor();
                AtualizarNomeEstabelecimentoGestor();
                forminterface.tbNumeroProduto.Focus();
            }
            else
            {
                MessageBox.Show("Insira o número correto de caracteres em: senha");
                txtpassword2.Clear();
                txtpassword2.Focus();
            }
        }
        private void AtualizarNomeGestor()
        {
            formgestor.lbNomeFuncionario.Text = txtUserName.Text;
            formgestor.lbCargo.Text = "Gestor(a)";
        }
        private void AtualizarNomeEstabelecimentoGestor()
        {
            formgestor.lbNomeEstabelecimento.Text = formcadastro.txtEstabelecimento.Text;
        }

        SqlConnection conexao1 = new SqlConnection(Properties.Settings.Default.conexao);
        string usuario;
        string senha;
        private void Logar1()
        {
            string login = $"SELECT Nome, Senha, Cargo FROM Usuario WHERE Nome= '{txtUserName.Text}' AND Senha= '{txtpassword2.Text}' AND Cargo= 'Vendedor(a)'";
            SqlCommand comando = new SqlCommand(login, conexao1);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                conexao1.Open();
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    usuario = reader[0].ToString();
                    senha = reader[1].ToString();
                    conexao1.Close();

                    if (usuario.Equals(txtUserName.Text) && senha.Equals(txtpassword2.Text))
                    {
                        TempoFormInterface();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login!" + ex);
                conexao1.Close();
            }
            finally
            {
                if (usuario != txtUserName.Text || senha != txtpassword2.Text)
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                    txtpassword2.Clear();
                    txtUserName.Clear();
                    txtUserName.Focus();
                    conexao1.Close();
                }
            }
        }
        private void Logar2()
        {
            string login = $"SELECT Nome, Senha, Cargo FROM Usuario WHERE Nome= '{txtUserName.Text}' AND Senha= '{txtpassword2.Text}' AND Cargo= 'Gestor(a)'";
            SqlCommand comando = new SqlCommand(login, conexao1);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader;
            try
            {
                conexao1.Open();
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    usuario = reader[0].ToString();
                    senha = reader[1].ToString();
                    conexao1.Close();

                    if (usuario.Equals(txtUserName.Text) && senha.Equals(txtpassword2.Text))
                    {
                        TempoFormGestor();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login!" + ex);
                conexao1.Close();
            }
            finally
            {
                if (usuario != txtUserName.Text || senha != txtpassword2.Text)
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                    txtpassword2.Clear();
                    txtUserName.Clear();
                    txtUserName.Focus();
                    conexao1.Close();
                }
            }
        }
        private void TempoFormInterface()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            forminterface.Show();
            this.Cursor = Cursors.Default;
            this.Hide();
        }

        private void TempoFormGestor()
        {
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(500);
            formgestor.Show();
            this.Cursor = Cursors.Default;
            forminterface.Hide();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword2.Clear();
            txtUserName.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Hide();
            txtpassword2.Hide();
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.Show();
            txtpassword2.Show();
            txtpassword2.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword.Text = txtpassword2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) label1.Visible = true;
            else
            {
                label1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            formcadastro.Show();
            this.Hide();
        }

        private void btSobreNos_Click(object sender, EventArgs e)
        {
            Form formBackGround = new Form();

            try
            {
                using (FormSobreNos uu = new FormSobreNos())
                {
                    formBackGround.StartPosition = FormStartPosition.CenterScreen;
                    formBackGround.FormBorderStyle = FormBorderStyle.None;
                    formBackGround.Opacity = .70d;
                    formBackGround.BackColor = Color.Black;
                    formBackGround.WindowState = FormWindowState.Maximized;
                    formBackGround.TopMost = true;
                    formBackGround.Location = this.Location;
                    formBackGround.ShowInTaskbar = false;
                    formBackGround.Show();

                    uu.Owner = formBackGround;
                    uu.ShowDialog();

                    formBackGround.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackGround.Dispose();
            }
        }

        
    }
}
