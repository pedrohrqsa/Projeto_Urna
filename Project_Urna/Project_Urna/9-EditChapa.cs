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
    public partial class FrmEditChapa : Form
    {
        public FrmEditChapa()
        {
            InitializeComponent();
        }
        private void FrmEditChapa_Load(object sender, EventArgs e)
        {
            txtNomeChapa.Enabled = false;
            txtNumeroChapa.Enabled = false;
            txtNomePresidente.Enabled = false;
            txtNomeVice.Enabled = false;
            txtDescricao.Enabled = false;
            txtCaminhoFoto.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;
            txtCodC.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodC.Text == String.Empty)
            {
                MessageBox.Show("Campo do código vázio , preencha!");
                txtNomeChapa.Enabled = false;
                txtNumeroChapa.Enabled = false;
                txtNomePresidente.Enabled = false;
                txtNomeVice.Enabled = false;
                txtDescricao.Enabled = false;
                txtCaminhoFoto.Enabled = false;
                txtCodC.Clear();
                txtCodC.Focus();
            }
            else
            {
                if (txtCodC.Text != "")
                {
                    clnAlterar EditC = new clnAlterar();
                    EditC.CodChapa = txtCodC.Text.Trim();
                    OracleDataReader objDrDados;
                    objDrDados = EditC.SelectCodC();
                    if (objDrDados.Read())
                    {
                        //MessageBox.Show("Código existente!");
                        txtNomeChapa.Enabled = true;
                        txtNumeroChapa.Enabled = false;
                        txtNomePresidente.Enabled = true;
                        txtNomeVice.Enabled = true;
                        txtDescricao.Enabled = true;
                        txtCaminhoFoto.Enabled = true;
                        btnEditar.Enabled = true;
                        txtCodC.Enabled = false;
                        btnPesquisar.Enabled = false;
                        btnLimpar.Enabled = true;
                        txtCodC.Text = EditC.CodChapa;
                    }
                    else
                    {
                        MessageBox.Show("Chapa inexistente.");
                        txtCodC.Clear();
                        txtNomeChapa.Clear();
                        txtNumeroChapa.Clear();
                        txtNomePresidente.Clear();
                        txtNomeVice.Clear();
                        txtDescricao.Clear();
                        txtCaminhoFoto.Clear();
                        txtCodC.Focus();
                    }
                }
                // <---->
                if (txtCodC.Text != "")
                {
                    clnAlterar EditaC = new clnAlterar();
                    OracleDataReader objEdt;
                    EditaC.CodChapa = txtCodC.Text.Trim();
                    objEdt = EditaC.SelectC();
                    if (objEdt.Read())
                    {
                        EditaC.CodChapa = txtCodC.Text;
                        txtCodC.Enabled = false;
                        txtNomeChapa.Text = objEdt["Nome_chapa"].ToString();
                        txtNumeroChapa.Text = objEdt["Numero"].ToString();
                        txtNomePresidente.Text = objEdt["Presidente"].ToString();
                        txtNomeVice.Text = objEdt["vice_presidente"].ToString();
                        txtDescricao.Text = objEdt["Descricao"].ToString();
                        txtCaminhoFoto.Text = objEdt["Caminho_foto"].ToString();
                    }
                    else
                    { /* MessageBox.Show("Erro ao trazer informações."); */ }
                    txtNomeChapa.Focus();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((txtNomeChapa.Text == "") ||
               //(txtNumeroChapa.Text == "") ||
               (txtNomePresidente.Text == "") ||
               (txtNomeVice.Text == "") ||
                (txtDescricao.Text =="")||
                (txtCaminhoFoto.Text =="")){
                MessageBox.Show("Todos os campos são Obrigatórios", "AVISO!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeChapa.Focus();
            }else{
                clnAlterar edit = new clnAlterar();
                edit.CodChapa = txtCodC.Text;
                edit.EditNomeChapa = txtNomeChapa.Text;
                edit.EditNmrChapa = txtNumeroChapa.Text;
                edit.EditPresidente = txtNomePresidente.Text;
                edit.Editvicepresidente = txtNomeVice.Text;
                edit.EditDescricao = txtDescricao.Text;
                edit.EditCaminhoDaFoto = txtCaminhoFoto.Text;
                edit.EditC();
                MessageBox.Show("Registro Gravado com Sucesso", 
                    "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            txtCodC.Clear();
            txtNomeChapa.Clear();
            txtNumeroChapa.Clear();
            txtNomePresidente.Clear();
            txtNomeVice.Clear();
            txtDescricao.Clear();
            txtCaminhoFoto.Clear();
            txtNomeChapa.Enabled = false;
            txtNumeroChapa.Enabled = false;
            txtNomePresidente.Enabled = false;
            txtNomeVice.Enabled = false;
            txtDescricao.Enabled = false;
            txtCaminhoFoto.Enabled = false;
            btnLimpar.Enabled = false;
            txtCodC.Enabled = true;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = true;
            txtCodC.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodC.Enabled = true;
            txtNomeChapa.Enabled = false;
            txtNumeroChapa.Enabled = false;
            txtNomePresidente.Enabled = false;
            txtNomeVice.Enabled = false;
            txtDescricao.Enabled = false;
            txtCaminhoFoto.Enabled = false;
            btnEditar.Enabled = false;
            btnLimpar.Enabled = false;
            txtCodC.Clear();
            txtNomeChapa.Clear();
            txtNumeroChapa.Clear();
            txtNomePresidente.Clear();
            txtNomeVice.Clear();
            txtDescricao.Clear();
            txtCaminhoFoto.Clear();
            btnPesquisar.Enabled = true;
            txtCodC.Focus();
        }
    }
}
