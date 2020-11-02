namespace salario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnF = new System.Windows.Forms.RadioButton();
            this.rbnM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtCasado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.textSalLiquido = new System.Windows.Forms.TextBox();
            this.textSalFamilia = new System.Windows.Forms.TextBox();
            this.textIRPF = new System.Windows.Forms.TextBox();
            this.textINSS = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textFilhos = new System.Windows.Forms.TextBox();
            this.mskDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.textSalBruto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número de Filhos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salário bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome Funcionário";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnF);
            this.groupBox1.Controls.Add(this.rbnM);
            this.groupBox1.Location = new System.Drawing.Point(653, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbnF
            // 
            this.rbnF.AutoSize = true;
            this.rbnF.Location = new System.Drawing.Point(6, 75);
            this.rbnF.Name = "rbnF";
            this.rbnF.Size = new System.Drawing.Size(108, 28);
            this.rbnF.TabIndex = 1;
            this.rbnF.Text = "Feminino";
            this.rbnF.UseVisualStyleBackColor = true;
            // 
            // rbnM
            // 
            this.rbnM.AutoSize = true;
            this.rbnM.Checked = true;
            this.rbnM.Location = new System.Drawing.Point(6, 31);
            this.rbnM.Name = "rbnM";
            this.rbnM.Size = new System.Drawing.Size(114, 28);
            this.rbnM.TabIndex = 0;
            this.rbnM.TabStop = true;
            this.rbnM.Text = "Masculino";
            this.rbnM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtCasado);
            this.groupBox2.Location = new System.Drawing.Point(653, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 69);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // rbtCasado
            // 
            this.rbtCasado.AutoSize = true;
            this.rbtCasado.Location = new System.Drawing.Point(6, 28);
            this.rbtCasado.Name = "rbtCasado";
            this.rbtCasado.Size = new System.Drawing.Size(93, 28);
            this.rbtCasado.TabIndex = 0;
            this.rbtCasado.Text = "Casado";
            this.rbtCasado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(87, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Alíquota INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(90, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alíquota IRPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(87, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Salário Familia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(87, 540);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Salário Líquido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(569, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Desconto INSS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(569, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Desconto IRPF";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(62, 163);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(366, 49);
            this.btnVerify.TabIndex = 28;
            this.btnVerify.Text = "Verificar Desconto";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSalLiquido
            // 
            this.textSalLiquido.Enabled = false;
            this.textSalLiquido.Location = new System.Drawing.Point(245, 537);
            this.textSalLiquido.Margin = new System.Windows.Forms.Padding(6);
            this.textSalLiquido.Name = "textSalLiquido";
            this.textSalLiquido.Size = new System.Drawing.Size(180, 29);
            this.textSalLiquido.TabIndex = 24;
            // 
            // textSalFamilia
            // 
            this.textSalFamilia.Enabled = false;
            this.textSalFamilia.Location = new System.Drawing.Point(245, 468);
            this.textSalFamilia.Margin = new System.Windows.Forms.Padding(6);
            this.textSalFamilia.Name = "textSalFamilia";
            this.textSalFamilia.Size = new System.Drawing.Size(180, 29);
            this.textSalFamilia.TabIndex = 23;
            // 
            // textIRPF
            // 
            this.textIRPF.Enabled = false;
            this.textIRPF.Location = new System.Drawing.Point(248, 409);
            this.textIRPF.Margin = new System.Windows.Forms.Padding(6);
            this.textIRPF.Name = "textIRPF";
            this.textIRPF.Size = new System.Drawing.Size(180, 29);
            this.textIRPF.TabIndex = 22;
            // 
            // textINSS
            // 
            this.textINSS.Enabled = false;
            this.textINSS.Location = new System.Drawing.Point(248, 346);
            this.textINSS.Margin = new System.Windows.Forms.Padding(6);
            this.textINSS.Name = "textINSS";
            this.textINSS.Size = new System.Drawing.Size(180, 29);
            this.textINSS.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(245, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // textFilhos
            // 
            this.textFilhos.Location = new System.Drawing.Point(245, 108);
            this.textFilhos.Margin = new System.Windows.Forms.Padding(6);
            this.textFilhos.Name = "textFilhos";
            this.textFilhos.Size = new System.Drawing.Size(183, 29);
            this.textFilhos.TabIndex = 4;
            // 
            // mskDescINSS
            // 
            this.mskDescINSS.Enabled = false;
            this.mskDescINSS.Location = new System.Drawing.Point(715, 346);
            this.mskDescINSS.Name = "mskDescINSS";
            this.mskDescINSS.Size = new System.Drawing.Size(183, 29);
            this.mskDescINSS.TabIndex = 30;
            // 
            // mskDescIRPF
            // 
            this.mskDescIRPF.Enabled = false;
            this.mskDescIRPF.Location = new System.Drawing.Point(715, 404);
            this.mskDescIRPF.Name = "mskDescIRPF";
            this.mskDescIRPF.Size = new System.Drawing.Size(183, 29);
            this.mskDescIRPF.TabIndex = 31;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.Color.White;
            this.lblDados.Location = new System.Drawing.Point(87, 250);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(70, 24);
            this.lblDados.TabIndex = 32;
            this.lblDados.Text = "label10";
            this.lblDados.Visible = false;
            // 
            // textSalBruto
            // 
            this.textSalBruto.Location = new System.Drawing.Point(245, 61);
            this.textSalBruto.Margin = new System.Windows.Forms.Padding(6);
            this.textSalBruto.Name = "textSalBruto";
            this.textSalBruto.Size = new System.Drawing.Size(183, 29);
            this.textSalBruto.TabIndex = 33;
            this.textSalBruto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 822);
            this.Controls.Add(this.textSalBruto);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.mskDescIRPF);
            this.Controls.Add(this.mskDescINSS);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSalLiquido);
            this.Controls.Add(this.textSalFamilia);
            this.Controls.Add(this.textIRPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textINSS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFilhos);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnF;
        private System.Windows.Forms.RadioButton rbnM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rbtCasado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox textSalLiquido;
        private System.Windows.Forms.TextBox textSalFamilia;
        private System.Windows.Forms.TextBox textIRPF;
        private System.Windows.Forms.TextBox textINSS;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textFilhos;
        private System.Windows.Forms.MaskedTextBox mskDescINSS;
        private System.Windows.Forms.MaskedTextBox mskDescIRPF;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.TextBox textSalBruto;
    }
}

