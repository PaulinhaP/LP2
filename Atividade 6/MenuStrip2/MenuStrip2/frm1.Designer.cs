namespace MenuStrip2
{
    partial class frm1
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnPares.Location = new System.Drawing.Point(234, 188);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(91, 45);
            this.btnPares.TabIndex = 7;
            this.btnPares.Text = "Pares de Letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnLetraR.Location = new System.Drawing.Point(126, 187);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(91, 46);
            this.btnLetraR.TabIndex = 6;
            this.btnLetraR.Text = "Letra R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnBranco.Location = new System.Drawing.Point(22, 188);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(91, 45);
            this.btnBranco.TabIndex = 5;
            this.btnBranco.Text = "Espaços em Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // rchTexto
            // 
            this.rchTexto.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.rchTexto.Location = new System.Drawing.Point(12, 12);
            this.rchTexto.MaxLength = 100;
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(339, 123);
            this.rchTexto.TabIndex = 4;
            this.rchTexto.Text = "";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchTexto);
            this.Name = "frm1";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.RichTextBox rchTexto;
    }
}