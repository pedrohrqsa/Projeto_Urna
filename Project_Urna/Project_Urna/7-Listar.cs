using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Project_Urna
{
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }
        public void DataGridMesario()
        {
            ClnListar ObjListarM = new ClnListar();
            dgvMesarios.DataSource = ObjListarM.ListarMesarios().Tables[0];
            dgvMesarios.Columns[0].HeaderText = ("Código");
            dgvMesarios.Columns[1].HeaderText = ("Nome");
            dgvMesarios.Columns[2].HeaderText = ("Identificação");
            //dgvMesarios.Columns[3].HeaderText = ("Senha");
            dgvMesarios.AutoResizeColumns();
            if (dgvMesarios.RowCount == 0)
            { MessageBox.Show("Erro: Não foram encontrados dados.",
                "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMesarios.DataSource = null;
            }
            else
            {
                btnListarAlunos.Enabled = true;
                btnExcluirAluno.Enabled = true;
                btnListarChapas.Enabled = true;
                btnExcluirChapa.Enabled = true;
            }
        }

        public void DataGridAluno()
        {
            ClnListar ObjListarA = new ClnListar();
            dgvAlunos.DataSource = ObjListarA.ListarAlunos().Tables[0];
            dgvAlunos.Columns[0].HeaderText = ("Código");
            dgvAlunos.Columns[1].HeaderText = ("Nome");
            dgvAlunos.Columns[2].HeaderText = ("RM");
            //dgvAlunos.Columns[3].HeaderText = ("Senha");
            dgvAlunos.AutoResizeColumns();

            if (dgvAlunos.RowCount == 1)
            {
                MessageBox.Show("Erro: Não foram encontrados dados.",
                  "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAlunos.DataSource = null;
            }
            else
            {
                btnListarMesarios.Enabled = true;
                btnExcluirMesario.Enabled = true;
                btnListarChapas.Enabled = true;
                btnExcluirChapa.Enabled = true;
            }
        }

        public void DataGridChapa()
        {
            ClnListar ObjListarC = new ClnListar();
            dgvChapas.DataSource = ObjListarC.ListarChapas().Tables[0];
            //dgvChapas.Columns[0].HeaderText = ("COD_CHAPA");
            dgvChapas.Columns[0].HeaderText = ("Nome da Chapa");
            dgvChapas.Columns[1].HeaderText = ("Número");
            dgvChapas.Columns[2].HeaderText = ("Presidente");
            dgvChapas.Columns[3].HeaderText = ("Vice Presidente");
            dgvChapas.Columns[4].HeaderText = ("Descrição");
            dgvChapas.Columns[5].HeaderText = ("Caminho da foto");
            dgvChapas.AutoResizeColumns();
            if (dgvChapas.RowCount == 0)
            {
                MessageBox.Show("Erro: Não foram encontrados dados.",
               "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChapas.DataSource = null;
            }
            else
            {
                btnListarMesarios.Enabled = true;
                btnExcluirMesario.Enabled = true;
                btnListarChapas.Enabled = true;
                btnExcluirChapa.Enabled = true;
            }
        }
        //==========================================================================================================
        //Sistema de listagens
        private void btnListarMesarios_Click(object sender, EventArgs e)
        {
            DataGridMesario();
            btnEditarMesario.Enabled = true;
        }

        private void btnListarAlunos_Click(object sender, EventArgs e)
        {
            DataGridAluno();
            btnEditarAluno.Enabled = true;
        }

        private void btnListarChapas_Click(object sender, EventArgs e)
        {
            DataGridChapa();
            btnEditarChapa.Enabled = true;
        }

        private void btnEditarMesario_Click(object sender, EventArgs e)
        {
            EditMesario form = new EditMesario();
            form.ShowDialog();
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            FrmEditAluno form = new FrmEditAluno();
            form.ShowDialog();
        }

        private void btnEditarChapa_Click(object sender, EventArgs e)
        {
            FrmEditChapa form = new FrmEditChapa();
            form.ShowDialog();
        }

        //==========================================================================
        //Sistema de exclusão e desativação de chapa
        private void btnExcluirMesario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir o Mesário selecionado? " 
                    + Convert.ToString(dgvMesarios.CurrentRow.Cells[0].Value),
                "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == resultado)
                {
                    clnUrna objEx = new clnUrna();
                    objEx.Mesarios = Convert.ToString(dgvMesarios.CurrentRow.Cells[0].Value);
                    objEx.ExcluirMesarioLogicamente();
                    MessageBox.Show("Mesário excluído com sucesso.", "E X C L U S Ã O",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    /*MessageBox.Show("Operação Cancelada.", " CANCELAMENTO DE E X C L U S Ã O", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information); */
                }
                DataGridMesario();
            }
            catch (Exception Error)
            { Error.ToString(); }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir o Mesário selecionado? "
                    + Convert.ToString(dgvAlunos.CurrentRow.Cells[0].Value),
                "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == resultado)
                {
                    clnUrna objEx = new clnUrna();
                    objEx.Alunos = Convert.ToString(dgvAlunos.CurrentRow.Cells[0].Value);
                    objEx.ExcluirAlunoLogicamente();
                    MessageBox.Show("Aluno excluído com sucesso.", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    /*MessageBox.Show("Operação Cancelada.", " CANCELAMENTO DE E X C L U S Ã O",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }
                DataGridAluno();
            }
            catch (Exception Error)
            { Error.ToString(); }
        }

        private void btnExcluirChapa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja mesmo desativar as chapas? ", 
                    "Desligamento de chapas no Sistema.", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == resultado)
                {
                    clnUrna objLimpaApuracao = new clnUrna();
                    objLimpaApuracao.LimpaApuracao();
                    clnUrna objdesativaChapa = new clnUrna();
                    objdesativaChapa.DesativarChapas();
                    clnUrna objDropSq = new clnUrna();
                    objDropSq.DropSq();
                    clnUrna objCreateSq = new clnUrna();
                    objCreateSq.CreateSq();
                    MessageBox.Show("Chapas desativadas com Sucesso!", 
                        "D E S A T I V A Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação Cancelada.", " CANCELAMENTO DE DESATIVAÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Error)
            { MessageBox.Show(Error.ToString()); }
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            btnEditarAluno.Enabled = false;
            btnEditarMesario.Enabled = false;
            btnEditarChapa.Enabled = false;
        }
        private void btnLimparListas_Click(object sender, EventArgs e)
        {
            dgvMesarios.Columns.Clear();
            dgvAlunos.Columns.Clear();
            dgvChapas.Columns.Clear();
            btnEditarAluno.Enabled = false;
            btnEditarMesario.Enabled = false;
            btnEditarChapa.Enabled = false;
        }
        private void btnSair_Click(object sender, EventArgs e)
        { Close(); }
    }
}