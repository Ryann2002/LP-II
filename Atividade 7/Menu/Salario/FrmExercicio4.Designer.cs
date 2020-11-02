namespace Salario
{
    partial class FrmExercicio4
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
            this.rchTxt1 = new System.Windows.Forms.RichTextBox();
            this.Contador = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchTxt1
            // 
            this.rchTxt1.Location = new System.Drawing.Point(167, 69);
            this.rchTxt1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rchTxt1.Name = "rchTxt1";
            this.rchTxt1.Size = new System.Drawing.Size(584, 174);
            this.rchTxt1.TabIndex = 2;
            this.rchTxt1.Text = "";
            this.rchTxt1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Contador
            // 
            this.Contador.Location = new System.Drawing.Point(167, 273);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(191, 45);
            this.Contador.TabIndex = 3;
            this.Contador.Text = "Contar Numeros";
            this.Contador.UseVisualStyleBackColor = true;
            this.Contador.Click += new System.EventHandler(this.Contador_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Localizar espaço branco";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Caracteres";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite Seu texto aqui";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Contador);
            this.Controls.Add(this.rchTxt1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchTxt1;
        private System.Windows.Forms.Button Contador;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}