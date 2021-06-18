namespace Win_Forms_1
{
    partial class formRendaDiaria
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRendaDiaria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbValorDiario = new System.Windows.Forms.Label();
            this.pbImagemUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendaDiaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRendaDiaria
            // 
            this.dgvRendaDiaria.AllowUserToAddRows = false;
            this.dgvRendaDiaria.AllowUserToDeleteRows = false;
            this.dgvRendaDiaria.AllowUserToResizeColumns = false;
            this.dgvRendaDiaria.AllowUserToResizeRows = false;
            this.dgvRendaDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvRendaDiaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRendaDiaria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRendaDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendaDiaria.Location = new System.Drawing.Point(12, 187);
            this.dgvRendaDiaria.MultiSelect = false;
            this.dgvRendaDiaria.Name = "dgvRendaDiaria";
            this.dgvRendaDiaria.RowHeadersWidth = 51;
            this.dgvRendaDiaria.RowTemplate.Height = 24;
            this.dgvRendaDiaria.Size = new System.Drawing.Size(785, 274);
            this.dgvRendaDiaria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(263, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renda Diária";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(300, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Estabelecimento";
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.ForeColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(86, 12);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(169, 24);
            this.lbNomeFuncionario.TabIndex = 5;
            this.lbNomeFuncionario.Text = "Nome funcionário";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.BackColor = System.Drawing.Color.Transparent;
            this.lbCargo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.Transparent;
            this.lbCargo.Location = new System.Drawing.Point(86, 42);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(64, 24);
            this.lbCargo.TabIndex = 6;
            this.lbCargo.Text = "Cargo";
            // 
            // lbValorDiario
            // 
            this.lbValorDiario.AutoSize = true;
            this.lbValorDiario.BackColor = System.Drawing.Color.Transparent;
            this.lbValorDiario.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorDiario.ForeColor = System.Drawing.Color.Transparent;
            this.lbValorDiario.Location = new System.Drawing.Point(358, 462);
            this.lbValorDiario.Name = "lbValorDiario";
            this.lbValorDiario.Size = new System.Drawing.Size(94, 40);
            this.lbValorDiario.TabIndex = 7;
            this.lbValorDiario.Text = "valor";
            this.lbValorDiario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbImagemUsuario
            // 
            this.pbImagemUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbImagemUsuario.Image = global::Win_Forms_1.Properties.Resources.laptop_user_1_1179329;
            this.pbImagemUsuario.Location = new System.Drawing.Point(12, 12);
            this.pbImagemUsuario.Name = "pbImagemUsuario";
            this.pbImagemUsuario.Size = new System.Drawing.Size(68, 73);
            this.pbImagemUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemUsuario.TabIndex = 11;
            this.pbImagemUsuario.TabStop = false;
            // 
            // formRendaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win_Forms_1.Properties.Resources.fundologin;
            this.ClientSize = new System.Drawing.Size(810, 515);
            this.Controls.Add(this.pbImagemUsuario);
            this.Controls.Add(this.lbValorDiario);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRendaDiaria);
            this.Controls.Add(this.button1);
            this.Name = "formRendaDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRendaDiaria";
            this.Load += new System.EventHandler(this.formRendaDiaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendaDiaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbNomeFuncionario;
        public System.Windows.Forms.Label lbCargo;
        public System.Windows.Forms.DataGridView dgvRendaDiaria;
        public System.Windows.Forms.Label lbValorDiario;
        private System.Windows.Forms.PictureBox pbImagemUsuario;
    }
}