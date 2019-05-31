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
    public partial class FrmContatoOpinioes : Form
    {
        public FrmContatoOpinioes()
        {
            InitializeComponent();
        }

        public void DataGridOpn(){
            clnProjWeb objListarOP = new clnProjWeb();
            dgvOP.DataSource = objListarOP.ListarOp().Tables[0];
            dgvOP.Columns[0].HeaderText = ("Código");
            dgvOP.Columns[1].HeaderText = ("Nome");
            dgvOP.Columns[2].HeaderText = ("Telefone");
            dgvOP.Columns[3].HeaderText = ("E-Mail");
            dgvOP.Columns[4].HeaderText = ("Assunto");
            dgvOP.Columns[5].HeaderText = ("Data que foi enviada.");
            dgvOP.AutoResizeColumns();
            if (dgvOP.RowCount == 0)
            {
                MessageBox.Show("Erro: Não foram encontrados dados.");
                dgvOP.DataSource = null;
            }else{
            }
        }

        private void btnVisuOp_Click(object sender, EventArgs e)
        {
            DataGridOpn();
        }

        private void btnLimpaLista_Click(object sender, EventArgs e)
        {
            dgvOP.Columns.Clear();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}