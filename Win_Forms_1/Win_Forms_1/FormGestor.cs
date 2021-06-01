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
    public partial class FormGestor : Form
    {
        private Form1 form1;
        public FormGestor(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            form1.Show();
            this.Hide();
        }

        private void FormGestor_Load(object sender, EventArgs e)
        {
            AtualizarProdutos();
        }
    }
}
