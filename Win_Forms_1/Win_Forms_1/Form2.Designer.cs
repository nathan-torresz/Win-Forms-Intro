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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Win_Forms_1.Properties.Resources.open_512;
            this.pictureBox1.Location = new System.Drawing.Point(89, 69);
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
            this.label2.Location = new System.Drawing.Point(109, 69);
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
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.ForeColor = System.Drawing.Color.Transparent;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(89, 20);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(164, 16);
            this.lbNomeFuncionario.TabIndex = 3;
            this.lbNomeFuncionario.Text = "NOME DO FUNCIONÁRIO";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.BackColor = System.Drawing.Color.Transparent;
            this.lbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCargo.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.Transparent;
            this.lbCargo.Location = new System.Drawing.Point(89, 43);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(55, 16);
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
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btRendaDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btvendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(357, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do estabelecimento";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 8;
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
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Win_Forms_1.Properties.Resources.fundologin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNomeFuncionario;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btRendaDiaria;
        private System.Windows.Forms.Button btvendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}