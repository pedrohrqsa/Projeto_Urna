using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace Project_Urna
{
    public partial class FrmUrna : Form
    {
        public FrmUrna(){
            InitializeComponent();
        }
      
        private void btnVota_Click(object sender, EventArgs e)
        {
                if ((txtRM.Text == String.Empty) || (txtSenha.Text == String.Empty)){
                    MessageBox.Show("Campos vazios, preencha.");
                    txtRM.Clear();
                    txtSenha.Clear();
                    txtRM.Focus();
                }
                if (txtRM.Text != "")
                {
                    clnUrna ObjClnUrna = new clnUrna();
                    ObjClnUrna.Rm = (txtRM.Text.Trim());
                    ObjClnUrna.Senha = (txtSenha.Text.Trim());
                    OracleDataReader ObjDrDados;
                    ObjDrDados = ObjClnUrna.ValidarRM_e_Senha();
                    try{
                        if (ObjDrDados.Read()){
                            ObjClnUrna.Rm = txtRM.Text;
                            clnUrna.Temp = txtRM.Text;
                        }
                        else { 
                            MessageBox.Show("RM e SENHA incorretos.");
                            txtRM.Clear();
                            txtSenha.Clear();
                            txtRM.Focus();
                        }
                    }
                    catch (Exception error)
                    { MessageBox.Show("Erro:"+error); }
                }
            //   <--->
                try{
                    clnUrna ObjClnUrnaValidV = new clnUrna();
                    ObjClnUrnaValidV.Rm = (txtRM.Text.Trim());
                    ObjClnUrnaValidV.Senha = (txtSenha.Text.Trim());
                    OracleDataReader objValida;
                    objValida = ObjClnUrnaValidV.ValidarVotou();
                    if (objValida.Read()){
                        MessageBox.Show("O aluno JÁ VOTOU, portanto não poderá votar novamente.",
                         "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Clear();
                        txtRM.Clear();
                        txtRM.Focus();
                    }else{
                        clnUrna ObjClnUrnaValidNV = new clnUrna();
                        ObjClnUrnaValidNV.Rm = (txtRM.Text.Trim());
                        ObjClnUrnaValidNV.Senha = (txtSenha.Text.Trim());
                        OracleDataReader objValidaNV;
                        objValidaNV = ObjClnUrnaValidNV.ValidarNvotou();
                        if (objValidaNV.Read()){
                            MessageBox.Show("BEM-VINDO!!!");
                            Form FrmVota = new FrmVota();
                            FrmVota.ShowDialog();
                            txtSenha.Clear();
                            txtRM.Clear();
                            txtRM.Focus();
                        }
                    }
                }catch (Exception Error)
                { MessageBox.Show("Erro:"+Error); }
                    txtSenha.Clear();
                    txtRM.Clear();
                    txtRM.Focus();
            }
        // *LEMBRETE*   "/n" quebra linha
//-------------------------------------------------------------------------------
        private void txtRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }
//-------------------------------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            { Application.Restart(); }
        }
//-------------------------------------------------------------------------------
        //private void btnSair_Click(object sender, EventArgs e)
        //{
        //    if ((MessageBox.Show("Deseja realmente sair?", "Sair",
        //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        //    { Close(); }
        //}
    }
}