namespace Win_Forms_1
{
    partial class formEstoque
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Indigo;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.btVoltar.Location = new System.Drawing.Point(12, 500);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(69, 30);
            this.btVoltar.TabIndex = 0;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.AllowUserToResizeColumns = false;
            this.dgvListaProdutos.AllowUserToResizeRows = false;
            this.dgvListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.Location = new System.Drawing.Point(13, 175);
            this.dgvListaProdutos.MultiSelect = false;
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.RowHeadersWidth = 51;
            this.dgvListaProdutos.RowTemplate.Height = 24;
            this.dgvListaProdutos.Size = new System.Drawing.Size(720, 310);
            this.dgvListaProdutos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(265, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESTOQUE";
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.ForeColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(80, 18);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(169, 24);
            this.lbNomeFuncionario.TabIndex = 3;
            this.lbNomeFuncionario.Text = "Nome funcionario";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.BackColor = System.Drawing.Color.Transparent;
            this.lbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCargo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.Transparent;
            this.lbCargo.Location = new System.Drawing.Point(80, 41);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(64, 24);
            this.lbCargo.TabIndex = 4;
            this.lbCargo.Text = "Cargo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Win_Forms_1.Properties.Resources.laptop_user_1_1179329;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(223, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(528, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOME DO ESTABELECIMENTO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(13, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "Entrar como Gestor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Win_Forms_1.Properties.Resources.fundologin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaProdutos);
            this.Controls.Add(this.btVoltar);
            this.Name = "formEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbNomeFuncionario;
        public System.Windows.Forms.Label lbCargo;
        public System.Windows.Forms.DataGridView dgvListaProdutos;
    }
}