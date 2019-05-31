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
    public partial class FrmCadastro_chapa : Form
    {
        public FrmCadastro_chapa(){
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNomeChapa.Text == "") ||
                    (txtNumeroChapa.Text == "") ||
                    (txtNomePresidente.Text == "") ||
                    (txtNomeVice.Text == "") ||
                    (txtDescricaoChapa.Text == "") || 
                    (txtCaminhoFoto.Text == "")){
                    MessageBox.Show("Todos os campos são obrigatórios", "AVISO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeChapa.Focus();
                }else{
                    Cln_inserir Inserir = new Cln_inserir();
                    Inserir.Nome_Chapa = txtNomeChapa.Text;
                    Inserir.Numero_Chapa = txtNumeroChapa.Text;
                    Inserir.Presidente_Chapa = txtNomePresidente.Text;
                    Inserir.VicePresidenteChapa = txtNomeVice.Text;
                    Inserir.DescricaoChapa = txtDescricaoChapa.Text;
                    Inserir.Caminho_Foto = txtCaminhoFoto.Text;
                    Inserir.SalvarChapa();
                    //{ MessageBox.Show("A Chapa "+ txtNomeChapa.Text +" foi gravada."); }
                    MessageBox.Show("A Chapa " + txtNomeChapa.Text + " foi gravada.", " Item Salvo ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //{ MessageBox.Show("A chapa foi salva."); }


                    //insere data e hora de inserção da chapa
                    try
                    {
                        Cln_inserir i = new Cln_inserir();
                        i.Nome_Chapa = txtNomeChapa.Text;
                        i.SalvarComData();
                        { MessageBox.Show("Data e hora inseridos!!"); }
                    }
                    catch(Exception error){
                        MessageBox.Show("Erro:" + error);
                    }
                    txtNomeChapa.Clear();
                    txtNumeroChapa.Clear();
                    txtNomePresidente.Clear();
                    txtNomeVice.Clear();
                    txtDescricaoChapa.Clear();
                    txtCaminhoFoto.Clear();
                    //Close();
                }
            }catch (Exception Error)
            { Error.ToString(); }
        }

        private void txtNumeroChapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {  Close(); }
        private void FrmCadastro_chapa_Load(object sender, EventArgs e)
        {
            txtNomeChapa.Focus();
        }
    }
}
        