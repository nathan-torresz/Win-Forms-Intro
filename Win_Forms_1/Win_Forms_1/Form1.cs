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

namespace Win_Forms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logar();
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
            if(checkBox1.Checked) label1.Visible = true;
            else
            {
                label1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new FormCadastro().Show();
            this.Hide();
        }

        SqlConnection conexao1 = new SqlConnection(Properties.Settings.Default.conexao);
        string usuario;
        string senha;

        private void Logar()
        {
            string login = "SELECT Nome, Senha FROM Usuario WHERE Nome= '" + txtUserName.Text + "' AND Senha='" + txtpassword2.Text + "'";
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
                    if (usuario.Equals(txtUserName.Text)&& senha.Equals(txtpassword2.Text))
                    {
                        new FormInterface().Show();
                        this.Hide();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login!" + ex);
            }
        }   
    }
}
