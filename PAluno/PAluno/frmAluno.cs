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
    public partial class frmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();

        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            try
            {

                Aluno Aln = new Aluno();
                dsAluno.Tables.Add(Aln.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRa.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNome.DataBindings.Add("TEXT", bnAluno, "nome_aluno");
                
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cmbCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO
                cmbCidade.DisplayMember = "nome_cidade";
                //CAMPO QUE É A CHAVE DA TABELA CIDADE E QUE LIGA COM A TABELA DE ALUNO
                cmbCidade.ValueMember = "id_cidade";
                //No momento de linkar os componentes com o Binding Source linkar também o combox da cidade
                cmbCidade.DataBindings.Add("SelectedValue", bnAluno, "cidade_id_cidade"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
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

            bnAluno.AddNew();
            txtRa.Enabled = true;
            txtNome.Enabled = true;
            cmbCidade.Enabled = true;
            cmbCidade.SelectedIndex = 0;
            txtRa.Focus();
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
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome inválido!");
            }
            else if (txtRa.Text == "")
            {
                MessageBox.Show("RA inválido!");
            }
            else
            {
                Aluno RegAln = new Aluno();

                RegAln.Raaluno = Convert.ToInt32(txtRa.Text);
                RegAln.Nomealuno = txtNome.Text;
                RegAln.Cidadeidcidade = Convert.ToInt32(cmbCidade.SelectedValue);

                if (bInclusao)
                {
                    if (RegAln.Salvar() > 0)
                    {
                        MessageBox.Show("Aluno adicionado com sucesso!");

                        toolStripBtnSalvar.Enabled = false;
                        txtRa.Enabled = false;
                        txtNome.Enabled = false;
                        cmbCidade.Enabled = false;
                        toolStripBtnSalvar.Enabled = false;
                        toolStripBtnAlterar.Enabled = true;
                        toolStripBtnNovoReg.Enabled = true;
                        toolStripBtnExcluir.Enabled = true;
                        toolStripBtnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAln.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }
                }
                else
                {
                    if (RegAln.Alterar() > 0)
                    {
                        MessageBox.Show("Aluno alterado com sucesso!");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAln.Listar());
                        txtRa.Enabled = false;
                        txtNome.Enabled = false;
                        cmbCidade.Enabled = false;
                        toolStripBtnSalvar.Enabled = false;
                        toolStripBtnAlterar.Enabled = true;
                        toolStripBtnNovoReg.Enabled = true;
                        toolStripBtnExcluir.Enabled = true;
                        toolStripBtnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
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

            txtRa.Enabled = false;
            txtNome.Enabled = true;
            cmbCidade.Enabled = true;
            txtRa.Focus();
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
                Aluno RegAln = new Aluno();

                RegAln.Raaluno = Convert.ToInt16(txtRa.Text);
                RegAln.Nomealuno = txtNome.Text;
                RegAln.Cidadeidcidade = Convert.ToInt32(cmbCidade.SelectedValue);

                if (RegAln.Excluir() > 0)
                {
                    MessageBox.Show("Aluno excluído com sucesso!");
                    Aluno R = new Aluno();
                    dsAluno.Tables.Clear();
                    dsAluno.Tables.Add(R.Listar());
                    bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
            }
        }

        private void toolStripBtnCancelar_Click(object sender, EventArgs e)
        {
            bnAluno.CancelEdit();

            toolStripBtnSalvar.Enabled = false;
            txtRa.Enabled = false;
            txtNome.Enabled = false;
            cmbCidade.Enabled = false;
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