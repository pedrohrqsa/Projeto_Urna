using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Urna
{
    public partial class FrmCadastroMesario : Form
    {
        public FrmCadastroMesario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == "") ||
               (txtID_Mesario.Text == "") ||
               (txtSenha.Text == ""))
            { 
                MessageBox.Show("Todos os campos são obrigatórios", " AVISO! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }else{
                Cln_inserir Inserir = new Cln_inserir();
                Inserir.NomeMesario = txtNome.Text;
                Inserir.Id_Mesario = txtID_Mesario.Text;
                Inserir.Senha_Mesario = txtSenha.Text;
                Inserir.SalvarMesario();
                txtNome.Clear();
                txtID_Mesario.Clear();
                txtSenha.Clear();

                {  MessageBox.Show("O Mesário foi salvo!",
                     "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }
        private void btnSair_Click(object sender, EventArgs e)
        { { Close(); } }

        private void FrmCadastroMesario_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }
    }
}
