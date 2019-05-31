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
    public partial class FrmGerencia : Form
    {
        public FrmGerencia()
        {
            InitializeComponent();
        }

        private void btnCadastroMesario_Click(object sender, EventArgs e)
        {
            Form FrmCadastro_Mesario = new FrmCadastroMesario();
            FrmCadastro_Mesario.ShowDialog();
        }

        private void btnCadastroChapa_Click(object sender, EventArgs e)
        {
            Form FrmCadastro_chapa = new FrmCadastro_chapa();
            FrmCadastro_chapa.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Form FrmListar = new FrmListar();
            FrmListar.ShowDialog();
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            Form FrmListar = new FrmListar();
            FrmListar.ShowDialog();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
             Form FrmCadastrarAluno = new FrmCadastrarAluno();
             FrmCadastrarAluno.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FrmOpnioes = new FrmContatoOpinioes();
            FrmOpnioes.ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
