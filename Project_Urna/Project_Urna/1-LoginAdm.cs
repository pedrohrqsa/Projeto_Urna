using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Project_Urna
{
    public partial class frmAdm : Form
    {
        public frmAdm()
        { InitializeComponent(); }
        
        private void btnEntra_Click(object sender, EventArgs e)
        {
            if ((txtAdm.Text == String.Empty)){
                MessageBox.Show("Campo vazio, preencha.",
                    "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdm.Clear();
            }

            if (txtAdm.Text != ""){
                clnUrna ObjClnUrna = new clnUrna();
                ObjClnUrna.Adm = (txtAdm.Text.Trim());
                OracleDataReader ObjDrDados;
                ObjDrDados = ObjClnUrna.Valida_ADM();
                try{
                    if (ObjDrDados.Read())
                    {
                        //MessageBox.Show("Acesso Liberado.");
                        Form FrmGerencia = new FrmGerencia();
                        FrmGerencia.ShowDialog();
                        txtAdm.Clear();
                        txtMesario.Clear();
                        txtSenha.Clear();
                        txtAdm.Focus();
                    }
                    else
                    { MessageBox.Show("Identificação do Administrador incorreta.",
                     "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);}   
                }
                catch (Exception error)
                {error.ToString();}
                txtAdm.Clear();
                txtMesario.Clear();
                txtSenha.Clear();
                txtAdm.Focus();
            }
        }

        private void BtnEntraMesario_Click(object sender, EventArgs e)
        {
            if ((txtMesario.Text == String.Empty) && (txtSenha.Text == String.Empty))
            {
                MessageBox.Show("Campo vazio, preencha.",
                "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMesario.Clear();
                txtSenha.Clear();
                txtAdm.Clear();
            }

            if ((txtMesario.Text != "") && (txtSenha.Text != ""))
            {
                clnUrna ObjClnUrna = new clnUrna();
                ObjClnUrna.Mesario = (txtMesario.Text.Trim());
                ObjClnUrna.SenhaMesario = (txtSenha.Text.Trim());
                OracleDataReader ObjDrDados;
                ObjDrDados = ObjClnUrna.Valida_MESARIO();
                try
                {
                    if (ObjDrDados.Read()){
                        //MessageBox.Show("Acesso Permitido.");
                        ObjClnUrna.Mesario = txtMesario.Text;
                        clnUrna.Temp = txtMesario.Text;
                        Form FrmAbrir_Eleicao = new FrmAbrir_Eleicao();
                        FrmAbrir_Eleicao.ShowDialog();
                        txtMesario.Clear();
                        txtSenha.Clear();
                        txtAdm.Clear();
                    }
                    else
                    { MessageBox.Show("Identificações do Mesário incorretas.",
                        "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    txtSenha.Clear();
                    txtMesario.Clear();
                    txtAdm.Clear();
                    txtMesario.Focus();

                }catch (Exception error)
                {error.ToString();}
            }
        }

//-----------------------------------------------------------------------
        private void txtAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            Close();
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            txtAdm.Focus();
        }
    }
}