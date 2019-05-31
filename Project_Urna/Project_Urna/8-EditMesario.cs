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
    public partial class EditMesario : Form
    {
        public EditMesario()
        {
            InitializeComponent();
        }
        private void EditMesario_Load(object sender, EventArgs e)
        {
            txtID_Mesario.Enabled = false;
            txtNomeM.Enabled = false;
            txtSenhaM.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodM.Text == String.Empty)
            {
                MessageBox.Show("Campo do código vázio , preencha!");

                txtNomeM.Enabled = false;
                txtID_Mesario.Enabled = false;
                txtSenhaM.Enabled = false;

                txtCodM.Clear();
                txtCodM.Focus();
            }
            else
            {
                if (txtCodM.Text != "")
                {
                    clnAlterar EditM = new clnAlterar();
                    EditM.Cod = (txtCodM.Text.Trim());
                    OracleDataReader objDrDados;
                    objDrDados = EditM.SelectCodM();
                    if (objDrDados.Read())
                    {
                        //MessageBox.Show("Código existente!");
                        txtID_Mesario.Enabled = true;
                        txtNomeM.Enabled = true;
                        txtSenhaM.Enabled = true;
                        btnEditar.Enabled = true;
                        txtCodM.Enabled = false;
                        btnPesquisar.Enabled = false;
                        EditM.Cod = txtCodM.Text;
                    }
                    else
                    {
                        MessageBox.Show("Mesário inexistente.");
                        btnLimpar.Enabled = false;
                        txtCodM.Clear();
                        txtCodM.Focus();
                    }
                }
                else
                {
                    //MessageBox.Show("  ");
                }

                // <--->
                clnAlterar Edit = new clnAlterar();
                OracleDataReader objEdt;
                Edit.Cod = txtCodM.Text.Trim();
                objEdt = Edit.SelectM();
                if (objEdt.Read())
                {
                    txtCodM.Enabled = false;
                    txtCodM.Text = Edit.Cod;
                    txtNomeM.Text = objEdt["Nome"].ToString();
                    txtID_Mesario.Text = objEdt["Id_Mesario"].ToString();
                    txtSenhaM.Text = objEdt["Senha"].ToString();
                }
                else
                {
                    //MessageBox.Show("Erro ao trazer informações.");
                }
            }
            btnLimpar.Enabled = true;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtNomeM.Text == "") ||
                (txtSenhaM.Text == "") ||
                (txtCodM.Text == ""))
            {
                MessageBox.Show("Todos os campos são Obrigatórios", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeM.Focus();
            }
            else
            {
                clnAlterar edit = new clnAlterar();
                edit.NomeM = txtNomeM.Text;
                edit.idM = txtID_Mesario.Text;
                edit.SenhaM = txtSenhaM.Text;
                edit.Cod = txtCodM.Text;
                edit.EditaMesario();
                MessageBox.Show("Registro Gravado com Sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtCodM.Clear();
            txtID_Mesario.Clear();
            txtNomeM.Clear();
            txtSenhaM.Clear();

            txtCodM.Enabled = true;
            txtID_Mesario.Enabled = false;
            txtNomeM.Enabled = false;
            txtSenhaM.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = true;

            txtCodM.Focus();

            //Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodM.Clear();
            txtID_Mesario.Clear();
            txtNomeM.Clear();
            txtSenhaM.Clear();

            btnPesquisar.Enabled = true;
            txtCodM.Enabled = true;
            btnEditar.Enabled = false;

            txtNomeM.Enabled = false;
            txtID_Mesario.Enabled = false;
            txtSenhaM.Enabled = false;
            btnLimpar.Enabled = false;

            txtCodM.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void txtSenhaM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }
    }
}
