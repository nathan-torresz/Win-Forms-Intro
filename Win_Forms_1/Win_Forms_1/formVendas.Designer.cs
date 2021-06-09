namespace Win_Forms_1
{
    partial class formVendas
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
            this.lbNomeEstabelecimento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVendidos = new System.Windows.Forms.DataGridView();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Win_Forms_1.Properties.Resources.laptop_user_1_1179329;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbNomeEstabelecimento
            // 
            this.lbNomeEstabelecimento.AutoSize = true;
            this.lbNomeEstabelecimento.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeEstabelecimento.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeEstabelecimento.ForeColor = System.Drawing.Color.Transparent;
            this.lbNomeEstabelecimento.Location = new System.Drawing.Point(322, 35);
            this.lbNomeEstabelecimento.Name = "lbNomeEstabelecimento";
            this.lbNomeEstabelecimento.Size = new System.Drawing.Size(478, 45);
            this.lbNomeEstabelecimento.TabIndex = 11;
            this.lbNomeEstabelecimento.Text = "Nome do Estabelecimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(385, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vendidos";
            // 
            // dgvVendidos
            // 
            this.dgvVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendidos.Location = new System.Drawing.Point(12, 235);
            this.dgvVendidos.Name = "dgvVendidos";
            this.dgvVendidos.RowHeadersWidth = 51;
            this.dgvVendidos.RowTemplate.Height = 24;
            this.dgvVendidos.Size = new System.Drawing.Size(938, 324);
            this.dgvVendidos.TabIndex = 9;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Indigo;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.btVoltar.Location = new System.Drawing.Point(12, 565);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(74, 36);
            this.btVoltar.TabIndex = 8;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click_1);
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.BackColor = System.Drawing.Color.Transparent;
            this.lbCargo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.Transparent;
            this.lbCargo.Location = new System.Drawing.Point(105, 52);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(64, 24);
            this.lbCargo.TabIndex = 16;
            this.lbCargo.Text = "Cargo";
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.ForeColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(105, 22);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(169, 24);
            this.lbNomeFuncionario.TabIndex = 15;
            this.lbNomeFuncionario.Text = "Nome funcionário";
            // 
            // formVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win_Forms_1.Properties.Resources.fundologin;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNomeEstabelecimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVendidos);
            this.Controls.Add(this.btVoltar);
            this.Name = "formVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formVendas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvVendidos;
        private System.Windows.Forms.Button btVoltar;
        public System.Windows.Forms.Label lbCargo;
        public System.Windows.Forms.Label lbNomeFuncionario;
        public System.Windows.Forms.Label lbNomeEstabelecimento;
    }
}