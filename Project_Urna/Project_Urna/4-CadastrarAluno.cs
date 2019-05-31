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
    public partial class FrmCadastrarAluno : Form
    {
        public FrmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if ((txtNomeAluno.Text == "") ||
               (txtRM.Text == "") ||
               (txtSenhaDoAluno.Text == ""))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", " A V I S O ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeAluno.Focus();
            }
            else{
                Cln_inserir Inserir = new Cln_inserir();
                Inserir.Nome_Aluno = txtNomeAluno.Text;
                Inserir.RM = txtRM.Text;
                Inserir.Senha_Aluno = txtSenhaDoAluno.Text;
                Inserir.SalvarAluno();
                { MessageBox.Show("O aluno foi salvo!",
                    "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                txtNomeAluno.Clear();
                txtRM.Clear();
                txtSenhaDoAluno.Clear();
                //Close();
            }
        }
        private void txtRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void btnSair_Click(object sender, EventArgs e)
        { Close(); }

        private void FrmCadastrarAluno_Load(object sender, EventArgs e)
        {
            txtNomeAluno.Focus();
        }
    }
}
