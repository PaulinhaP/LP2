﻿namespace MenuStrip
{
    partial class frmExercicio5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimeiro = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Número:";
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.Location = new System.Drawing.Point(147, 36);
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiro.TabIndex = 2;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(147, 70);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(100, 20);
            this.txtSegundo.TabIndex = 3;
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(88, 128);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(94, 23);
            this.btnSorteio.TabIndex = 4;
            this.btnSorteio.Text = "Realizar Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 216);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimeiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExercicio5";
            this.Text = "FormExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimeiro;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.Button btnSorteio;
    }
}