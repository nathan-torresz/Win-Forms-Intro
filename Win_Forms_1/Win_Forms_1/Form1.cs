using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(txtUserName.Text == "Nathan" && txtpassword2.Text == "nhtatd")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (txtUserName.Text == "Antenor" && txtpassword2.Text == "nht2402")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente!");
                txtUserName.Clear();
                txtpassword2.Clear();
                txtUserName.Focus();
            }
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
    }
}
