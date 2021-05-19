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
    public partial class FormInterface : Form
    {
        public FormInterface()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            new formVendas().Show();
            this.Hide();
        }

        private void btRendaDiaria_Click(object sender, EventArgs e)
        {
            new formRendaDiaria().Show();
            this.Hide();
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            new formEstoque().Show();
            this.Hide();
        }
    }
}
