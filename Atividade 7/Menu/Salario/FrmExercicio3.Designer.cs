namespace Salario
{
    partial class FrmExercicio3
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
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSubstituir = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(207, 81);
            this.txtTexto1.Margin = new System.Windows.Forms.Padding(6);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(180, 29);
            this.txtTexto1.TabIndex = 0;
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(509, 81);
            this.txtTexto2.Margin = new System.Windows.Forms.Padding(6);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(180, 29);
            this.txtTexto2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(599, 212);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(6);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(154, 42);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Ao contrário";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(346, 212);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(6);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(242, 42);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Substituir 1 no 2";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSubstituir
            // 
            this.btnSubstituir.Location = new System.Drawing.Point(161, 212);
            this.btnSubstituir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubstituir.Name = "btnSubstituir";
            this.btnSubstituir.Size = new System.Drawing.Size(174, 42);
            this.btnSubstituir.TabIndex = 6;
            this.btnSubstituir.Text = "Substituir 1 no 2";
            this.btnSubstituir.UseVisualStyleBackColor = true;
            this.btnSubstituir.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(357, 154);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(180, 29);
            this.txtResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSubstituir);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.txtTexto1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmExercicio3";
            this.Text = "FrmExercicio3";
            this.Load += new System.EventHandler(this.FrmExercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSubstituir;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}