using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PAluno
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtId.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtNomeCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cmbEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripBtnNovoReg_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bnCidade.AddNew();
            txtNomeCidade.Enabled = true;
            cmbEstado.Enabled = true;
            cmbEstado.SelectedIndex = 0;
            txtNomeCidade.Focus();
            toolStripBtnSalvar.Enabled = true;
            toolStripBtnAlterar.Enabled = false;
            toolStripBtnNovoReg.Enabled = false;
            toolStripBtnExcluir.Enabled = false;
            toolStripBtnCancelar.Enabled = true;

            bInclusao = true; ;
        }

        private void toolStripBtnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeCidade.Text == "")
            {
                MessageBox.Show("Cidade inválida!");
            }
            else
            {
                Cidade RegCid = new Cidade();

                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cmbEstado.SelectedItem.ToString();

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso!");

                        toolStripBtnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cmbEstado.Enabled = false;
                        toolStripBtnSalvar.Enabled = false;
                        toolStripBtnAlterar.Enabled = true;
                        toolStripBtnNovoReg.Enabled = true;
                        toolStripBtnExcluir.Enabled = true;
                        toolStripBtnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        txtId.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cmbEstado.Enabled = false;
                        toolStripBtnSalvar.Enabled = false;
                        toolStripBtnAlterar.Enabled = true;
                        toolStripBtnNovoReg.Enabled = true;
                        toolStripBtnExcluir.Enabled = true;
                        toolStripBtnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }

                }
            }
        }

        private void toolStripBtnAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtNomeCidade.Enabled = true;
            cmbEstado.Enabled = true;
            txtNomeCidade.Focus();
            toolStripBtnSalvar.Enabled = true;
            toolStripBtnAlterar.Enabled = false;
            toolStripBtnNovoReg.Enabled = false;
            toolStripBtnExcluir.Enabled = false;
            toolStripBtnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void toolStripBtnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();

                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cmbEstado.SelectedItem.ToString();

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }

        private void toolStripBtnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();

            toolStripBtnSalvar.Enabled = false;
            txtNomeCidade.Enabled = false;
            cmbEstado.Enabled = false;
            toolStripBtnAlterar.Enabled = true;
            toolStripBtnNovoReg.Enabled = true;
            toolStripBtnExcluir.Enabled = true;
        }

        private void toolStripBtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
