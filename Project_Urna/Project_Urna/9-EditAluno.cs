using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Project_Urna
{
    public partial class FrmEditAluno : Form
    {
        public FrmEditAluno(){
            InitializeComponent();
        }

        private void EditAluno_Load(object sender, EventArgs e)
        {
            txtRM.Enabled = false;
            txtNomeAluno.Enabled = false;
            txtSenhaAluno.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodA.Text == String.Empty)
            {
                MessageBox.Show("Campo do código vázio , preencha!");
                txtNomeAluno.Enabled = false;
                txtRM.Enabled = false;
                txtSenhaAluno.Enabled = false;
                txtCodA.Clear();
                txtCodA.Focus();
            }
            else
            {
                if (txtCodA.Text != "")
                {
                    clnAlterar EditA = new clnAlterar();
                    EditA.CodA = txtCodA.Text.Trim();
                    OracleDataReader objDrDados;
                    objDrDados = EditA.SelectCodA();
                    if (objDrDados.Read())
                    {
                        //MessageBox.Show("Código existente!");
                        txtRM.Enabled = true;
                        txtNomeAluno.Enabled = true;
                        txtSenhaAluno.Enabled = true;
                        btnEditar.Enabled = true;
                        txtCodA.Enabled = false;
                        btnPesquisar.Enabled = false;
                        txtCodA.Text = EditA.CodA;
                    }
                    else
                    {
                        MessageBox.Show("Aluno inexistente.");
                        txtCodA.Clear();
                        txtCodA.Focus();
                    }
                }
                else
                { /*MessageBox.Show("  ");*/ }

                // <--->
                if (txtCodA.Text != "")
                {
                    clnAlterar EditaA = new clnAlterar();
                    OracleDataReader objEdt;
                    EditaA.CodA = txtCodA.Text.Trim();
                    objEdt = EditaA.SelectA();
                    if (objEdt.Read())
                    {
                        EditaA.CodA = txtCodA.Text;
                        txtCodA.Enabled = false;
                        txtNomeAluno.Text = objEdt["Nome"].ToString();
                        txtRM.Text = objEdt["RM"].ToString();
                        txtSenhaAluno.Text = objEdt["Senha"].ToString();
                    }
                    else
                    { /*MessageBox.Show("Erro ao trazer informações."); */ }
                }
                //txtCodA.Clear();
                txtCodA.Focus();
            }
            btnLimpar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtNomeAluno.Text == "") ||
                (txtSenhaAluno.Text == "") ||
                (txtRM.Text == "") ||
                (txtCodA.Text == ""))
            { MessageBox.Show("Todos os campos são Obrigatórios",
                "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeAluno.Focus();
            }
            else
            {
                clnAlterar edit = new clnAlterar();
                edit.NomedoAluno = txtNomeAluno.Text;
                edit.editRM = txtRM.Text;
                edit.SenhaA = txtSenhaAluno.Text;
                edit.CodA = txtCodA.Text;
                edit.EditaAluno();
                MessageBox.Show("Registro Gravado com Sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCodA.Clear();
            txtNomeAluno.Clear();
            txtRM.Clear();
            txtSenhaAluno.Clear();
            txtNomeAluno.Enabled = false;
            txtRM.Enabled = false;
            txtSenhaAluno.Enabled = false;
            txtCodA.Enabled = true;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = true;
            txtCodA.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodA.Enabled = true;
            txtNomeAluno.Enabled = false;
            txtRM.Enabled = false;
            txtSenhaAluno.Enabled = false;
            btnPesquisar.Enabled = true;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = true;
            txtNomeAluno.Clear();
            txtRM.Clear();
            txtSenhaAluno.Clear();
            txtCodA.Clear();
            txtCodA.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtCodA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }
    }
}


