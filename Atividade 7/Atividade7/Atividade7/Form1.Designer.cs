
namespace Atividade7
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
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnLetra = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchText
            // 
            this.rchText.Location = new System.Drawing.Point(227, 56);
            this.rchText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rchText.MaxLength = 100;
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(736, 264);
            this.rchText.TabIndex = 0;
            this.rchText.Text = "";
            // 
            // btnEspaco
            // 
            this.btnEspaco.Location = new System.Drawing.Point(227, 332);
            this.btnEspaco.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(150, 44);
            this.btnEspaco.TabIndex = 1;
            this.btnEspaco.Text = "Espaços";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnLetra
            // 
            this.btnLetra.Location = new System.Drawing.Point(537, 332);
            this.btnLetra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(150, 44);
            this.btnLetra.TabIndex = 2;
            this.btnLetra.Text = "Letra R";
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(813, 332);
            this.btnPar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(150, 44);
            this.btnPar.TabIndex = 3;
            this.btnPar.Text = "Pares";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 487);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.btnEspaco);
            this.Controls.Add(this.rchText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchText;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnLetra;
        private System.Windows.Forms.Button btnPar;
    }
}

