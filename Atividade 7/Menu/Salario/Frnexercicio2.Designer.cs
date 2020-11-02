namespace Salario
{
    partial class Frnexercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.test_equals = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.insertinthetwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra1.Location = new System.Drawing.Point(118, 72);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(280, 49);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra2.Location = new System.Drawing.Point(118, 188);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(280, 49);
            this.txtPalavra2.TabIndex = 3;
            this.txtPalavra2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // test_equals
            // 
            this.test_equals.Location = new System.Drawing.Point(516, 66);
            this.test_equals.Name = "test_equals";
            this.test_equals.Size = new System.Drawing.Size(192, 55);
            this.test_equals.TabIndex = 4;
            this.test_equals.Text = "Testar Iguais";
            this.test_equals.UseVisualStyleBackColor = true;
            this.test_equals.Click += new System.EventHandler(this.test_equals_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(516, 127);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(192, 55);
            this.insert.TabIndex = 5;
            this.insert.Text = "Inserir *";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertinthetwo
            // 
            this.insertinthetwo.Location = new System.Drawing.Point(516, 188);
            this.insertinthetwo.Name = "insertinthetwo";
            this.insertinthetwo.Size = new System.Drawing.Size(192, 89);
            this.insertinthetwo.TabIndex = 6;
            this.insertinthetwo.Text = "Inserir no primeiro no segundo";
            this.insertinthetwo.UseVisualStyleBackColor = true;
            this.insertinthetwo.Click += new System.EventHandler(this.insertinthetwo_Click);
            // 
            // Frnexercicio2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertinthetwo);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.test_equals);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frnexercicio2";
            this.Text = "Frnexercicio2";
            this.Load += new System.EventHandler(this.Frnexercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button test_equals;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button insertinthetwo;
    }
}