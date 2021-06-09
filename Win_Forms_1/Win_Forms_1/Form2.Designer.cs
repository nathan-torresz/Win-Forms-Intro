namespace Win_Forms_1
{
    partial class FormInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btRendaDiaria = new System.Windows.Forms.Button();
            this.btvendas = new System.Windows.Forms.Button();
            this.lbEstabelecimento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeroProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btEfetuarVenda = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbTotalAPagar = new System.Windows.Forms.Label();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.btAddCarrinho = new System.Windows.Forms.Button();
            this.btRemoverDoCarrinho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Win_Forms_1.Properties.Resources.open_512;
            this.pictureBox1.Location = new System.Drawing.Point(15, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Press to Log Out";
            this.label2.Visible = false;
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.ForeColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(89, 20);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(229, 24);
            this.lbNomeFuncionario.TabIndex = 3;
            this.lbNomeFuncionario.Text = "NOME DO FUNCIONÁRIO";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.BackColor = System.Drawing.Color.Transparent;
            this.lbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCargo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.Transparent;
            this.lbCargo.Location = new System.Drawing.Point(90, 48);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(73, 24);
            this.lbCargo.TabIndex = 4;
            this.lbCargo.Text = "CARGO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btEstoque);
            this.groupBox1.Controls.Add(this.btRendaDiaria);
            this.groupBox1.Controls.Add(this.btvendas);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acessar";
            // 
            // btEstoque
            // 
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstoque.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstoque.ForeColor = System.Drawing.Color.White;
            this.btEstoque.Location = new System.Drawing.Point(6, 105);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(226, 31);
            this.btEstoque.TabIndex = 2;
            this.btEstoque.Text = "Estoque";
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btEstoque_Click);
            // 
            // btRendaDiaria
            // 
            this.btRendaDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRendaDiaria.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRendaDiaria.ForeColor = System.Drawing.Color.White;
            this.btRendaDiaria.Location = new System.Drawing.Point(6, 68);
            this.btRendaDiaria.Name = "btRendaDiaria";
            this.btRendaDiaria.Size = new System.Drawing.Size(226, 31);
            this.btRendaDiaria.TabIndex = 1;
            this.btRendaDiaria.Text = "Renda Diária";
            this.btRendaDiaria.UseVisualStyleBackColor = true;
            this.btRendaDiaria.Click += new System.EventHandler(this.btRendaDiaria_Click);
            // 
            // btvendas
            // 
            this.btvendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvendas.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvendas.ForeColor = System.Drawing.Color.White;
            this.btvendas.Location = new System.Drawing.Point(6, 31);
            this.btvendas.Name = "btvendas";
            this.btvendas.Size = new System.Drawing.Size(226, 31);
            this.btvendas.TabIndex = 0;
            this.btvendas.Text = "Vendas";
            this.btvendas.UseVisualStyleBackColor = true;
            this.btvendas.Click += new System.EventHandler(this.btvendas_Click);
            // 
            // lbEstabelecimento
            // 
            this.lbEstabelecimento.AutoSize = true;
            this.lbEstabelecimento.BackColor = System.Drawing.Color.Transparent;
            this.lbEstabelecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEstabelecimento.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstabelecimento.ForeColor = System.Drawing.Color.Transparent;
            this.lbEstabelecimento.Location = new System.Drawing.Point(360, 63);
            this.lbEstabelecimento.Name = "lbEstabelecimento";
            this.lbEstabelecimento.Size = new System.Drawing.Size(473, 68);
            this.lbEstabelecimento.TabIndex = 6;
            this.lbEstabelecimento.Text = "estabelecimento";
            this.lbEstabelecimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(475, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nova Venda";
            // 
            // tbNumeroProduto
            // 
            this.tbNumeroProduto.Location = new System.Drawing.Point(505, 270);
            this.tbNumeroProduto.Name = "tbNumeroProduto";
            this.tbNumeroProduto.Size = new System.Drawing.Size(180, 22);
            this.tbNumeroProduto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(368, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº do Produto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Win_Forms_1.Properties.Resources.laptop_user_1_1179329;
            this.pictureBox2.Location = new System.Drawing.Point(15, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 331);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.Size = new System.Drawing.Size(963, 125);
            this.dgvProdutos.TabIndex = 11;
            // 
            // btEfetuarVenda
            // 
            this.btEfetuarVenda.BackColor = System.Drawing.Color.Indigo;
            this.btEfetuarVenda.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEfetuarVenda.ForeColor = System.Drawing.Color.Transparent;
            this.btEfetuarVenda.Location = new System.Drawing.Point(325, 644);
            this.btEfetuarVenda.Name = "btEfetuarVenda";
            this.btEfetuarVenda.Size = new System.Drawing.Size(360, 40);
            this.btEfetuarVenda.TabIndex = 12;
            this.btEfetuarVenda.Text = "Efetuar Venda";
            this.btEfetuarVenda.UseVisualStyleBackColor = false;
            this.btEfetuarVenda.Click += new System.EventHandler(this.btEfetuarVenda_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Indigo;
            this.btBuscar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btBuscar.Location = new System.Drawing.Point(546, 296);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(93, 29);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbTotalAPagar
            // 
            this.lbTotalAPagar.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalAPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalAPagar.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAPagar.ForeColor = System.Drawing.Color.Transparent;
            this.lbTotalAPagar.Location = new System.Drawing.Point(731, 600);
            this.lbTotalAPagar.Name = "lbTotalAPagar";
            this.lbTotalAPagar.Size = new System.Drawing.Size(244, 52);
            this.lbTotalAPagar.TabIndex = 14;
            this.lbTotalAPagar.Text = "Valor";
            this.lbTotalAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.AllowUserToResizeColumns = false;
            this.dgvCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(12, 462);
            this.dgvCarrinho.MultiSelect = false;
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.RowHeadersWidth = 51;
            this.dgvCarrinho.RowTemplate.Height = 24;
            this.dgvCarrinho.Size = new System.Drawing.Size(963, 125);
            this.dgvCarrinho.TabIndex = 15;
            // 
            // btAddCarrinho
            // 
            this.btAddCarrinho.BackColor = System.Drawing.Color.Indigo;
            this.btAddCarrinho.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCarrinho.ForeColor = System.Drawing.Color.Transparent;
            this.btAddCarrinho.Location = new System.Drawing.Point(39, 593);
            this.btAddCarrinho.Name = "btAddCarrinho";
            this.btAddCarrinho.Size = new System.Drawing.Size(224, 41);
            this.btAddCarrinho.TabIndex = 16;
            this.btAddCarrinho.Text = "Add ao carrinho";
            this.btAddCarrinho.UseVisualStyleBackColor = false;
            this.btAddCarrinho.Click += new System.EventHandler(this.btAddCarrinho_Click);
            // 
            // btRemoverDoCarrinho
            // 
            this.btRemoverDoCarrinho.BackColor = System.Drawing.Color.Indigo;
            this.btRemoverDoCarrinho.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverDoCarrinho.ForeColor = System.Drawing.Color.Transparent;
            this.btRemoverDoCarrinho.Location = new System.Drawing.Point(269, 593);
            this.btRemoverDoCarrinho.Name = "btRemoverDoCarrinho";
            this.btRemoverDoCarrinho.Size = new System.Drawing.Size(224, 41);
            this.btRemoverDoCarrinho.TabIndex = 17;
            this.btRemoverDoCarrinho.Text = "Remover do carrinho";
            this.btRemoverDoCarrinho.UseVisualStyleBackColor = false;
            this.btRemoverDoCarrinho.Click += new System.EventHandler(this.btRemoverDoCarrinho_Click);
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win_Forms_1.Properties.Resources.fundologin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 696);
            this.Controls.Add(this.btRemoverDoCarrinho);
            this.Controls.Add(this.btAddCarrinho);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.lbTotalAPagar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btEfetuarVenda);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumeroProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEstabelecimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btRendaDiaria;
        private System.Windows.Forms.Button btvendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeroProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lbNomeFuncionario;
        public System.Windows.Forms.Label lbCargo;
        public System.Windows.Forms.Label lbEstabelecimento;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btEfetuarVenda;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAddCarrinho;
        private System.Windows.Forms.Button btRemoverDoCarrinho;
        public System.Windows.Forms.DataGridView dgvCarrinho;
        public System.Windows.Forms.Label lbTotalAPagar;
    }
}