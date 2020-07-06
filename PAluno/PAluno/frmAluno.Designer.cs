namespace PAluno
{
    partial class frmAluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dados = new System.Windows.Forms.TabPage();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnvAluno = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorBtnContagem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorBtnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBtnAnterior = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorBtnPosicao = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorBtnProximo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBtnUltimo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnNovoReg = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.Detalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAluno)).BeginInit();
            this.bnvAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Dados);
            this.tabControl1.Controls.Add(this.Detalhes);
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 270);
            this.tabControl1.TabIndex = 3;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dgvAluno);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(442, 244);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // dgvAluno
            // 
            this.dgvAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(8, 6);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(428, 232);
            this.dgvAluno.TabIndex = 0;
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.cmbCidade);
            this.Detalhes.Controls.Add(this.txtNome);
            this.Detalhes.Controls.Add(this.txtRa);
            this.Detalhes.Controls.Add(this.label3);
            this.Detalhes.Controls.Add(this.label2);
            this.Detalhes.Controls.Add(this.label1);
            this.Detalhes.Location = new System.Drawing.Point(4, 22);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(442, 244);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(90, 111);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(130, 21);
            this.cmbCidade.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(90, 31);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(130, 20);
            this.txtRa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RA:";
            // 
            // bnvAluno
            // 
            this.bnvAluno.AddNewItem = null;
            this.bnvAluno.CountItem = this.bindingNavigatorBtnContagem;
            this.bnvAluno.DeleteItem = null;
            this.bnvAluno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorBtnPrimeiro,
            this.bindingNavigatorBtnAnterior,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorBtnPosicao,
            this.bindingNavigatorBtnContagem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorBtnProximo,
            this.bindingNavigatorBtnUltimo,
            this.bindingNavigatorSeparator2,
            this.toolStripBtnNovoReg,
            this.toolStripBtnSalvar,
            this.toolStripBtnAlterar,
            this.toolStripBtnExcluir,
            this.toolStripBtnCancelar,
            this.toolStripBtnSair});
            this.bnvAluno.Location = new System.Drawing.Point(0, 0);
            this.bnvAluno.MoveFirstItem = this.bindingNavigatorBtnPrimeiro;
            this.bnvAluno.MoveLastItem = this.bindingNavigatorBtnUltimo;
            this.bnvAluno.MoveNextItem = this.bindingNavigatorBtnProximo;
            this.bnvAluno.MovePreviousItem = this.bindingNavigatorBtnAnterior;
            this.bnvAluno.Name = "bnvAluno";
            this.bnvAluno.PositionItem = this.bindingNavigatorBtnPosicao;
            this.bnvAluno.Size = new System.Drawing.Size(462, 25);
            this.bnvAluno.TabIndex = 2;
            this.bnvAluno.Text = "bindingNavigator1";
            // 
            // bindingNavigatorBtnContagem
            // 
            this.bindingNavigatorBtnContagem.Name = "bindingNavigatorBtnContagem";
            this.bindingNavigatorBtnContagem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorBtnContagem.Text = "of {0}";
            this.bindingNavigatorBtnContagem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorBtnPrimeiro
            // 
            this.bindingNavigatorBtnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBtnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBtnPrimeiro.Image")));
            this.bindingNavigatorBtnPrimeiro.Name = "bindingNavigatorBtnPrimeiro";
            this.bindingNavigatorBtnPrimeiro.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBtnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBtnPrimeiro.Text = "Move first";
            this.bindingNavigatorBtnPrimeiro.ToolTipText = "Primeiro";
            // 
            // bindingNavigatorBtnAnterior
            // 
            this.bindingNavigatorBtnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBtnAnterior.Image")));
            this.bindingNavigatorBtnAnterior.Name = "bindingNavigatorBtnAnterior";
            this.bindingNavigatorBtnAnterior.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBtnAnterior.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBtnAnterior.Text = "Move previous";
            this.bindingNavigatorBtnAnterior.ToolTipText = "Anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorBtnPosicao
            // 
            this.bindingNavigatorBtnPosicao.AccessibleName = "Position";
            this.bindingNavigatorBtnPosicao.AutoSize = false;
            this.bindingNavigatorBtnPosicao.Name = "bindingNavigatorBtnPosicao";
            this.bindingNavigatorBtnPosicao.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorBtnPosicao.Text = "0";
            this.bindingNavigatorBtnPosicao.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorBtnProximo
            // 
            this.bindingNavigatorBtnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBtnProximo.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBtnProximo.Image")));
            this.bindingNavigatorBtnProximo.Name = "bindingNavigatorBtnProximo";
            this.bindingNavigatorBtnProximo.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBtnProximo.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBtnProximo.Text = "Move next";
            this.bindingNavigatorBtnProximo.ToolTipText = "Próximo";
            // 
            // bindingNavigatorBtnUltimo
            // 
            this.bindingNavigatorBtnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBtnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBtnUltimo.Image")));
            this.bindingNavigatorBtnUltimo.Name = "bindingNavigatorBtnUltimo";
            this.bindingNavigatorBtnUltimo.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBtnUltimo.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBtnUltimo.Text = "Move last";
            this.bindingNavigatorBtnUltimo.ToolTipText = "Último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnNovoReg
            // 
            this.toolStripBtnNovoReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNovoReg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNovoReg.Image")));
            this.toolStripBtnNovoReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNovoReg.Name = "toolStripBtnNovoReg";
            this.toolStripBtnNovoReg.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnNovoReg.Text = "toolStripButton1";
            this.toolStripBtnNovoReg.ToolTipText = "Novo Registro";
            this.toolStripBtnNovoReg.Click += new System.EventHandler(this.toolStripBtnNovoReg_Click);
            // 
            // toolStripBtnSalvar
            // 
            this.toolStripBtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSalvar.Image")));
            this.toolStripBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalvar.Name = "toolStripBtnSalvar";
            this.toolStripBtnSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnSalvar.Text = "toolStripButton1";
            this.toolStripBtnSalvar.ToolTipText = "Salvar";
            this.toolStripBtnSalvar.Click += new System.EventHandler(this.toolStripBtnSalvar_Click);
            // 
            // toolStripBtnAlterar
            // 
            this.toolStripBtnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAlterar.Image")));
            this.toolStripBtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAlterar.Name = "toolStripBtnAlterar";
            this.toolStripBtnAlterar.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnAlterar.Text = "toolStripButton1";
            this.toolStripBtnAlterar.ToolTipText = "Alterar";
            this.toolStripBtnAlterar.Click += new System.EventHandler(this.toolStripBtnAlterar_Click);
            // 
            // toolStripBtnExcluir
            // 
            this.toolStripBtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExcluir.Image")));
            this.toolStripBtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExcluir.Name = "toolStripBtnExcluir";
            this.toolStripBtnExcluir.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnExcluir.Text = "toolStripButton1";
            this.toolStripBtnExcluir.ToolTipText = "Excluir";
            this.toolStripBtnExcluir.Click += new System.EventHandler(this.toolStripBtnExcluir_Click);
            // 
            // toolStripBtnCancelar
            // 
            this.toolStripBtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCancelar.Image")));
            this.toolStripBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCancelar.Name = "toolStripBtnCancelar";
            this.toolStripBtnCancelar.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCancelar.Text = "toolStripButton1";
            this.toolStripBtnCancelar.ToolTipText = "Cancelar";
            this.toolStripBtnCancelar.Click += new System.EventHandler(this.toolStripBtnCancelar_Click);
            // 
            // toolStripBtnSair
            // 
            this.toolStripBtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSair.Image")));
            this.toolStripBtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSair.Name = "toolStripBtnSair";
            this.toolStripBtnSair.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnSair.Text = "toolStripButton1";
            this.toolStripBtnSair.ToolTipText = "Sair";
            this.toolStripBtnSair.Click += new System.EventHandler(this.toolStripBtnSair_Click);
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 322);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnvAluno);
            this.Name = "frmAluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.tabControl1.ResumeLayout(false);
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAluno)).EndInit();
            this.bnvAluno.ResumeLayout(false);
            this.bnvAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dados;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TabPage Detalhes;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bnvAluno;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorBtnContagem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBtnPrimeiro;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBtnAnterior;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorBtnPosicao;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBtnProximo;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBtnUltimo;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnNovoReg;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalvar;
        private System.Windows.Forms.ToolStripButton toolStripBtnAlterar;
        private System.Windows.Forms.ToolStripButton toolStripBtnExcluir;
        private System.Windows.Forms.ToolStripButton toolStripBtnCancelar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSair;
    }
}