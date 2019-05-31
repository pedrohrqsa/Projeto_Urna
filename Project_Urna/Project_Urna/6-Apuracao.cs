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
    public partial class FrmApuracao : Form
    {
        public FrmApuracao()
        {
            InitializeComponent();
        }
        //================================================================================
        //APRESENTAÇÃO DE CONTAGENS DE VOTOS DO SISTEMA
        private void btnResultado_Click(object sender, EventArgs e)
        {   //Chapa1
            try
            {
                clnUrna objContaChapa1 = new clnUrna();
                OracleDataReader ObjContarChapa1;
                ObjContarChapa1 = objContaChapa1.ContaVotosChapa1();
                if (ObjContarChapa1.Read())
                { txtChapa1.Text = ObjContarChapa1["COUNT(CHAPA_VOTADA)"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }

                clnUrna ObjClnUrna = new clnUrna();
                OracleDataReader ObjDrDados1;
                ObjDrDados1 = ObjClnUrna.Chapa1();
                if (ObjDrDados1.Read())
                { txtNomeChapa1.Text = ObjDrDados1["NOME_CHAPA"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }
            }
            catch (Exception Error)
            { Error.ToString(); }


            //Chapa2
            try
            {
                clnUrna objContaChapa2 = new clnUrna();
                OracleDataReader ObjContarChapa2;
                ObjContarChapa2 = objContaChapa2.ContaVotosChapa2();
                if (ObjContarChapa2.Read())
                { txtChapa2.Text = ObjContarChapa2["COUNT(CHAPA_VOTADA)"].ToString(); }
                else { MessageBox.Show("Erro: interno"); }

                clnUrna ObjClnUrna2 = new clnUrna();
                OracleDataReader ObjDrDados2;
                ObjDrDados2 = ObjClnUrna2.Chapa2();
                if (ObjDrDados2.Read())
                { txtNomeChapa2.Text = ObjDrDados2["NOME_CHAPA"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }
            }
            catch (Exception Error)
            { Error.ToString(); }


            //Chapa 3
            try
            {
                clnUrna objContaChapa3 = new clnUrna();
                OracleDataReader ObjContarChapa3;
                ObjContarChapa3 = objContaChapa3.ContaVotosChapa3();
                if (ObjContarChapa3.Read())
                { txtChapa3.Text = ObjContarChapa3["COUNT(CHAPA_VOTADA)"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }

                clnUrna ObjClnUrna3 = new clnUrna();
                OracleDataReader ObjDrDados3;
                ObjDrDados3 = ObjClnUrna3.Chapa3();
                if (ObjDrDados3.Read())
                { txtNomeChapa3.Text = ObjDrDados3["NOME_CHAPA"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }
            }
            catch (Exception Error)
            { Error.ToString(); }

            //Chapa 4
            try
            {
                clnUrna objContaChapa4 = new clnUrna();
                OracleDataReader ObjContarChapa4;
                ObjContarChapa4 = objContaChapa4.ContaVotosChapa4();
                if (ObjContarChapa4.Read())
                { txtChapa4.Text = ObjContarChapa4["COUNT(CHAPA_VOTADA)"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }

                clnUrna ObjClnUrna4 = new clnUrna();
                OracleDataReader ObjDrDados4;
                ObjDrDados4 = ObjClnUrna4.Chapa4();
                if (ObjDrDados4.Read())
                { txtNomeChapa4.Text = ObjDrDados4["NOME_CHAPA"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }
            }
            catch (Exception Error)
            { Error.ToString(); }

            //Chapa 5
            try
            {
                clnUrna objContaChapa5 = new clnUrna();
                OracleDataReader ObjContarChapa5;
                ObjContarChapa5 = objContaChapa5.ContaVotosChapa5();
                if (ObjContarChapa5.Read())
                { txtChapa5.Text = ObjContarChapa5["COUNT(CHAPA_VOTADA)"].ToString(); }
                else { MessageBox.Show("Erro: Interno"); }

                clnUrna ObjClnUrna5 = new clnUrna();
                OracleDataReader ObjDrDados5;
                ObjDrDados5 = ObjClnUrna5.Chapa5();
                if (ObjDrDados5.Read())
                {
                    txtNomeChapa5.Text = ObjDrDados5["NOME_CHAPA"].ToString();
                }
                else { MessageBox.Show("Erro: Interno"); }
            }
            catch (Exception Error)
            { Error.ToString(); }

            // contagem de Votos Nulos
            try
            {
                clnUrna objclnContaNulo = new clnUrna();
                OracleDataReader ObjContaNulo;
                ObjContaNulo = objclnContaNulo.ContaVotosNulos();
                if (ObjContaNulo.Read())
                { txtVotosNulos.Text = ObjContaNulo["COUNT(NULO)"].ToString(); }
                else { MessageBox.Show("Erro Interno."); }
            }
            catch (Exception Error)
            { Error.ToString(); }

            //conta pessoas que não votaram.
            try
            {
                clnUrna objclnContaPQNV= new clnUrna();
                OracleDataReader ObjContaNulo;
                ObjContaNulo = objclnContaPQNV.ContaPQNV();
                if (ObjContaNulo.Read())
                { txtSvoto.Text = ObjContaNulo["COUNT(*)"].ToString(); }
                else { MessageBox.Show("Erro Interno."); }
            }
            catch (Exception Error)
            { Error.ToString(); }


            //MessageBox.Show("R E S U L T A D O   V I S U A L I Z A D O   C O M   S U C E S S O !");
        }
        private void btnSair_Click(object sender, EventArgs e)
        { Close(); }
    }
}
    

    

