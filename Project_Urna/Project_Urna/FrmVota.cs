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
using Oracle.DataAccess.Types;

namespace Project_Urna
{
    public partial class FrmVota : Form
    {
        public FrmVota()
        {
            InitializeComponent();
        }
        private void FrmVota_Load(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
            btnCorrigir.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja confirmar voto?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes))
            {
                clnUrna ObjClnUrna = new clnUrna();
                try
                {
                    ObjClnUrna.Rm = clnUrna.Temp;
                    ObjClnUrna.ConfirmaVoto();
                    { MessageBox.Show("Voto Concluído com Sucesso!!!"); }
                }
                catch (Exception error)
                { error.ToString(); }
                { Close(); }
            }
            else {
                //MessageBox.Show("Operação cancelada.");
            }
        }
//------------------------------------------------------------------
        private void btnNulo_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja confirmar voto?", "Confirmação", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes))
            {
                clnUrna ObjClnUrna = new clnUrna();
                try
                {
                    ObjClnUrna.Rm = clnUrna.Temp;
                    ObjClnUrna.ConfirmaVotoNulo();
                    { MessageBox.Show("Voto Concluído com Sucesso!"); }
                }
                catch (Exception error)
                { error.ToString(); }
                { Close(); }
            }
            else
            {
                //MessageBox.Show("Operação Cancelada."); 
            }
        }
//------------------------------------------------------------------
        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            try
            {
                clnUrna ObjUrnaNull = new clnUrna();
                ObjUrnaNull.Rm = clnUrna.Temp;
                ObjUrnaNull.FuncãoTemporariaCorrigir();
            }
            catch (Exception error)
            { error.ToString(); }

            try
            {
                clnUrna objUrna = new clnUrna();
                objUrna.Rm = clnUrna.Temp;
                objUrna.Corrigir();

                txtNumero.Clear();
                txtChapa.Clear();
                txtViceP.Clear();
                txtPresidente.Clear();
                txtDescricao.Clear();
                btnConfirmar.Enabled = false;
                btnNulo.Enabled = true;
                btnC1.Enabled = true;
                btnC2.Enabled = true;
                btnC3.Enabled = true;
                btnC4.Enabled = true;
                btnC5.Enabled = true;
                pb1.Image = null;
                btnCorrigir.Enabled = false;
            }
            catch (Exception error)
            { error.ToString(); }
        }
//------------------------------------------------------------------
        private void btnC1_Click(object sender, EventArgs e)
        {
            clnUrna ObjSelecionaUrna = new clnUrna();
            OracleDataReader ObjSelect;
            ObjSelecionaUrna.Rm = clnUrna.Temp;
            ObjSelect = ObjSelecionaUrna.SelecionaChapa1();
            //{ MessageBox.Show("Alterado"); }

            clnUrna ObjClnUrna = new clnUrna();
            OracleDataReader ObjDrDados;
            ObjDrDados = ObjClnUrna.Chapa1();
            try
            {
                if (ObjDrDados.Read())
                {
                    txtChapa.Text = ObjDrDados["NOME_CHAPA"].ToString();
                    txtNumero.Text = ObjDrDados["NUMERO"].ToString();
                    txtPresidente.Text = ObjDrDados["PRESIDENTE"].ToString();
                    txtViceP.Text = ObjDrDados["VICE_PRESIDENTE"].ToString();
                    txtDescricao.Text = ObjDrDados["DESCRICAO"].ToString();
                    string imagens = ObjDrDados["CAMINHO_FOTO"].ToString();
                    pb1.Image = Image.FromFile(imagens);
                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = true;
                    btnCorrigir.Enabled = true;
                    MessageBox.Show("Candidato escolhido com sucesso. Confirme seu Voto!!!");
                }
                else
                { 
                    MessageBox.Show("Chapa não cadastrada. \n \n Contate o Administrador do sistema.");
                    try
                    {
                        clnUrna ObjUrnaNull = new clnUrna();
                        ObjUrnaNull.Rm = clnUrna.Temp;
                        ObjUrnaNull.FuncãoTemporariaCorrigir();
                    }
                    catch (Exception error)
                    { error.ToString(); }

                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = false;
                    btnCorrigir.Enabled = false;
                }
            }
            catch (Exception error)
            { error.ToString(); }
        }
//-----------------------------------------------------------------------------------------------------
        private void btnC2_Click(object sender, EventArgs e)
        {
            clnUrna ObjSelecionaUrna = new clnUrna();
            OracleDataReader ObjSelect;
            ObjSelecionaUrna.Rm = clnUrna.Temp;
            ObjSelect = ObjSelecionaUrna.SelecionaChapa2();
            //{ MessageBox.Show("Alterado"); }

            clnUrna ObjClnUrna = new clnUrna();
            OracleDataReader ObjDrDados;
            ObjDrDados = ObjClnUrna.Chapa2();
            try
            {
                if (ObjDrDados.Read())
                {
                    txtChapa.Text = ObjDrDados["NOME_CHAPA"].ToString();
                    txtNumero.Text = ObjDrDados["NUMERO"].ToString();
                    txtPresidente.Text = ObjDrDados["PRESIDENTE"].ToString();
                    txtViceP.Text = ObjDrDados["VICE_PRESIDENTE"].ToString();
                    txtDescricao.Text = ObjDrDados["DESCRICAO"].ToString();
                    string imagens = ObjDrDados["CAMINHO_FOTO"].ToString();
                    pb1.Image = Image.FromFile(imagens);
                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = true;
                    btnCorrigir.Enabled = true;
                    MessageBox.Show("Candidato escolhido com sucesso. Confirme seu Voto!!!");
                }
                else
                {
                    MessageBox.Show("Chapa não cadastrada. \n \n Contate o Administrador do sistema.");
                    try
                    {
                        clnUrna ObjUrnaNull = new clnUrna();
                        ObjUrnaNull.Rm = clnUrna.Temp;
                        ObjUrnaNull.FuncãoTemporariaCorrigir();
                    }
                    catch (Exception error)
                    { error.ToString(); }

                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = false;
                    btnCorrigir.Enabled = false;
                }
            }
            catch (Exception error)
            { error.ToString(); }
        }
//---------------------------------------------------------------------------------
        private void btnC3_Click(object sender, EventArgs e)
        {
            clnUrna ObjSelecionaUrna = new clnUrna();
            OracleDataReader ObjSelect;
            ObjSelecionaUrna.Rm = clnUrna.Temp;
            ObjSelect = ObjSelecionaUrna.SelecionaChapa3();
            //{ MessageBox.Show("Alterado"); }

            clnUrna ObjClnUrna = new clnUrna();
            OracleDataReader ObjDrDados;
            ObjDrDados = ObjClnUrna.Chapa3();
            try
            {
                if (ObjDrDados.Read())
                {
                    txtChapa.Text = ObjDrDados["NOME_CHAPA"].ToString();
                    txtNumero.Text = ObjDrDados["NUMERO"].ToString();
                    txtPresidente.Text = ObjDrDados["PRESIDENTE"].ToString();
                    txtViceP.Text = ObjDrDados["VICE_PRESIDENTE"].ToString();
                    txtDescricao.Text = ObjDrDados["DESCRICAO"].ToString();
                    string imagens = ObjDrDados["CAMINHO_FOTO"].ToString();
                    pb1.Image = Image.FromFile(imagens);
                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = true;
                    btnCorrigir.Enabled = true;
                    MessageBox.Show("Candidato escolhido com sucesso. Confirme seu Voto!!!");
                }
                else
                {
                    MessageBox.Show("Chapa não cadastrada. \n \n Contate o Administrador do sistema.");
                    try
                    {
                        clnUrna ObjUrnaNull = new clnUrna();
                        ObjUrnaNull.Rm = clnUrna.Temp;
                        ObjUrnaNull.FuncãoTemporariaCorrigir();
                    }
                    catch (Exception error)
                    { error.ToString(); }

                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = false;
                    btnCorrigir.Enabled = false;
                }
            }
            catch (Exception error)
            { error.ToString(); }
        }
//-----------------------------------------------------------------------------------------------------
        private void btnC4_Click(object sender, EventArgs e)
        {
            clnUrna ObjSelecionaUrna = new clnUrna();
            OracleDataReader ObjSelect;
            ObjSelecionaUrna.Rm = clnUrna.Temp;
            ObjSelect = ObjSelecionaUrna.SelecionaChapa4();
            //{ MessageBox.Show("Alterado"); }

            clnUrna ObjClnUrna = new clnUrna();
            OracleDataReader ObjDrDados;
            ObjDrDados = ObjClnUrna.Chapa4();
            try
            {
                if (ObjDrDados.Read())
                {
                    txtChapa.Text = ObjDrDados["NOME_CHAPA"].ToString();
                    txtNumero.Text = ObjDrDados["NUMERO"].ToString();
                    txtPresidente.Text = ObjDrDados["PRESIDENTE"].ToString();
                    txtViceP.Text = ObjDrDados["VICE_PRESIDENTE"].ToString();
                    txtDescricao.Text = ObjDrDados["DESCRICAO"].ToString();
                    string imagens = ObjDrDados["CAMINHO_FOTO"].ToString();
                    pb1.Image = Image.FromFile(imagens);
                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = true;
                    btnCorrigir.Enabled = true;
                    MessageBox.Show("Candidato escolhido com sucesso. Confirme seu Voto!!!"); 
                }
                else
                {
                    MessageBox.Show("Chapa não cadastrada. \n \n Contate o Administrador do sistema.");
                    try
                    {
                        clnUrna ObjUrnaNull = new clnUrna();
                        ObjUrnaNull.Rm = clnUrna.Temp;
                        ObjUrnaNull.FuncãoTemporariaCorrigir();
                    }
                    catch (Exception error)
                    { error.ToString(); }

                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = false;
                    btnCorrigir.Enabled = false;
                }
            }
            catch (Exception error)
            { error.ToString(); }
        }
//-----------------------------------------------------------------------------------------------------
        private void btnC5_Click(object sender, EventArgs e)
        {
            clnUrna ObjSelecionaUrna = new clnUrna();
            OracleDataReader ObjSelect;
            ObjSelecionaUrna.Rm = clnUrna.Temp;
            ObjSelect = ObjSelecionaUrna.SelecionaChapa5();
            //{ MessageBox.Show("Alterado"); }

            clnUrna ObjClnUrna = new clnUrna();
            OracleDataReader ObjDrDados;
            ObjDrDados = ObjClnUrna.Chapa5();
            try
            {
                if (ObjDrDados.Read())
                {
                    txtChapa.Text = ObjDrDados["NOME_CHAPA"].ToString();
                    txtNumero.Text = ObjDrDados["NUMERO"].ToString();
                    txtPresidente.Text = ObjDrDados["PRESIDENTE"].ToString();
                    txtViceP.Text = ObjDrDados["VICE_PRESIDENTE"].ToString();
                    txtDescricao.Text = ObjDrDados["DESCRICAO"].ToString();
                    string imagens = ObjDrDados["CAMINHO_FOTO"].ToString();
                    pb1.Image = Image.FromFile(imagens);
                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = true;
                    btnCorrigir.Enabled = true;
                    MessageBox.Show("Candidato escolhido com sucesso. Confirme seu Voto!!!");
                }
                else
                {
                    MessageBox.Show("Chapa não cadastrada. \n \n Contate o Administrador do sistema.");
                    try
                    {
                        clnUrna ObjUrnaNull = new clnUrna();
                        ObjUrnaNull.Rm = clnUrna.Temp;
                        ObjUrnaNull.FuncãoTemporariaCorrigir();
                    }
                    catch (Exception error)
                    { error.ToString(); }

                    btnC1.Enabled = false;
                    btnC2.Enabled = false;
                    btnC3.Enabled = false;
                    btnC4.Enabled = false;
                    btnC5.Enabled = false;
                    btnNulo.Enabled = false;
                    btnConfirmar.Enabled = false;
                    btnCorrigir.Enabled = false;
                } 
            }
            catch (Exception error)
            { error.ToString(); }
        }
    }
}
             //else
            //{
           //MessageBox.Show("Ocorreu um erro, solicite o administrador do sistema.");
          //}
         //{
        //if ((MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       // == DialogResult.Yes))
      //((MessageBox.Show("Ocorreu um erro, solicite o administrador do sistema.","Erro Interno", 
     //MessageBoxButtons.OK, MessageBoxIcon.Warning))