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
    public partial class FrmAbrir_Eleicao : Form
    {
        public FrmAbrir_Eleicao()
        {
            InitializeComponent();
        }
        private void btnAbrir_Eleicao_Click(object sender, EventArgs e)
        {
            //Abre o formulário para entrar e fazer a votação.
            Form FrmUrna = new FrmUrna();
            FrmUrna.ShowDialog();
        }
        private void btnAbre_Apuracao_Click(object sender, EventArgs e)
        {
            //Abre o formulário de apuração.
            Form FrmApuracao = new FrmApuracao();
            FrmApuracao.ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            { Close(); }
        }
    }
}
