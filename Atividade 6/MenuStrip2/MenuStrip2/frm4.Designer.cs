namespace MenuStrip2
{
    partial class frm4
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.mskSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskGratificacao = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mskInscricao = new System.Windows.Forms.MaskedTextBox();
            this.mskProducao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gratificação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário Bruto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produção:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número de Inscrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(161, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 25);
            this.txtNome.TabIndex = 12;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Analista de Sistemas",
            "Desenvolvedor",
            "Gerente",
            "Inspetor de Qualidade",
            "Mecânico",
            "Metrologista",
            "Pintor",
            "Programador",
            "Tutor"});
            this.cmbCargo.Location = new System.Drawing.Point(161, 60);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(194, 26);
            this.cmbCargo.TabIndex = 13;
            // 
            // mskSalario
            // 
            this.mskSalario.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.mskSalario.Location = new System.Drawing.Point(161, 150);
            this.mskSalario.Mask = "9,999.99";
            this.mskSalario.Name = "mskSalario";
            this.mskSalario.Size = new System.Drawing.Size(100, 25);
            this.mskSalario.TabIndex = 16;
            // 
            // mskGratificacao
            // 
            this.mskGratificacao.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.mskGratificacao.Location = new System.Drawing.Point(161, 180);
            this.mskGratificacao.Mask = "999.99";
            this.mskGratificacao.Name = "mskGratificacao";
            this.mskGratificacao.Size = new System.Drawing.Size(100, 25);
            this.mskGratificacao.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.btnCalcular.Location = new System.Drawing.Point(188, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 28);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular Salário Bruto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mskInscricao
            // 
            this.mskInscricao.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.mskInscricao.Location = new System.Drawing.Point(161, 90);
            this.mskInscricao.Mask = "00000";
            this.mskInscricao.Name = "mskInscricao";
            this.mskInscricao.Size = new System.Drawing.Size(100, 25);
            this.mskInscricao.TabIndex = 19;
            this.mskInscricao.ValidatingType = typeof(int);
            // 
            // mskProducao
            // 
            this.mskProducao.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.mskProducao.Location = new System.Drawing.Point(161, 120);
            this.mskProducao.Mask = "00000";
            this.mskProducao.Name = "mskProducao";
            this.mskProducao.Size = new System.Drawing.Size(100, 25);
            this.mskProducao.TabIndex = 20;
            this.mskProducao.ValidatingType = typeof(int);
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 281);
            this.Controls.Add(this.mskProducao);
            this.Controls.Add(this.mskInscricao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mskGratificacao);
            this.Controls.Add(this.mskSalario);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskSalario;
        private System.Windows.Forms.MaskedTextBox mskGratificacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mskInscricao;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.MaskedTextBox mskProducao;
    }
}