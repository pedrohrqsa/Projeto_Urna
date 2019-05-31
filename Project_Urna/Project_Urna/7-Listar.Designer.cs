namespace Project_Urna
{
    partial class FrmListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListar));
            this.btnListarMesarios = new System.Windows.Forms.Button();
            this.dgvMesarios = new System.Windows.Forms.DataGridView();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.dgvChapas = new System.Windows.Forms.DataGridView();
            this.lbllistademesarios = new System.Windows.Forms.Label();
            this.lbllistadealunos = new System.Windows.Forms.Label();
            this.lbllistadechapas = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirMesario = new System.Windows.Forms.Button();
            this.btnListarAlunos = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnListarChapas = new System.Windows.Forms.Button();
            this.btnExcluirChapa = new System.Windows.Forms.Button();
            this.btnLimparListas = new System.Windows.Forms.Button();
            this.btnEditarMesario = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnEditarChapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarMesarios
            // 
            this.btnListarMesarios.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnListarMesarios.Location = new System.Drawing.Point(1, 353);
            this.btnListarMesarios.Name = "btnListarMesarios";
            this.btnListarMesarios.Size = new System.Drawing.Size(92, 53);
            this.btnListarMesarios.TabIndex = 0;
            this.btnListarMesarios.Text = "Listar Mesários";
            this.btnListarMesarios.UseVisualStyleBackColor = true;
            this.btnListarMesarios.Click += new System.EventHandler(this.btnListarMesarios_Click);
            // 
            // dgvMesarios
            // 
            this.dgvMesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesarios.Location = new System.Drawing.Point(1, 47);
            this.dgvMesarios.Name = "dgvMesarios";
            this.dgvMesarios.Size = new System.Drawing.Size(304, 299);
            this.dgvMesarios.TabIndex = 4;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(328, 48);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(304, 299);
            this.dgvAlunos.TabIndex = 5;
            // 
            // dgvChapas
            // 
            this.dgvChapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChapas.Location = new System.Drawing.Point(653, 47);
            this.dgvChapas.Name = "dgvChapas";
            this.dgvChapas.Size = new System.Drawing.Size(370, 299);
            this.dgvChapas.TabIndex = 6;
            // 
            // lbllistademesarios
            // 
            this.lbllistademesarios.AutoSize = true;
            this.lbllistademesarios.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.lbllistademesarios.Location = new System.Drawing.Point(30, 16);
            this.lbllistademesarios.Name = "lbllistademesarios";
            this.lbllistademesarios.Size = new System.Drawing.Size(251, 26);
            this.lbllistademesarios.TabIndex = 7;
            this.lbllistademesarios.Text = "Lista de Mesários cadastrados:";
            // 
            // lbllistadealunos
            // 
            this.lbllistadealunos.AutoSize = true;
            this.lbllistadealunos.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.lbllistadealunos.Location = new System.Drawing.Point(391, 16);
            this.lbllistadealunos.Name = "lbllistadealunos";
            this.lbllistadealunos.Size = new System.Drawing.Size(241, 26);
            this.lbllistadealunos.TabIndex = 8;
            this.lbllistadealunos.Text = "Lista de Alunos Cadastrados:";
            // 
            // lbllistadechapas
            // 
            this.lbllistadechapas.AutoSize = true;
            this.lbllistadechapas.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.lbllistadechapas.Location = new System.Drawing.Point(732, 16);
            this.lbllistadechapas.Name = "lbllistadechapas";
            this.lbllistadechapas.Size = new System.Drawing.Size(242, 26);
            this.lbllistadechapas.TabIndex = 9;
            this.lbllistadechapas.Text = "Lista de Chapas Cadastradas:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 13F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(958, 483);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(65, 44);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = " Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluirMesario
            // 
            this.btnExcluirMesario.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnExcluirMesario.Location = new System.Drawing.Point(213, 353);
            this.btnExcluirMesario.Name = "btnExcluirMesario";
            this.btnExcluirMesario.Size = new System.Drawing.Size(92, 53);
            this.btnExcluirMesario.TabIndex = 11;
            this.btnExcluirMesario.Text = "Excluir Mesário";
            this.btnExcluirMesario.UseVisualStyleBackColor = true;
            this.btnExcluirMesario.Click += new System.EventHandler(this.btnExcluirMesario_Click);
            // 
            // btnListarAlunos
            // 
            this.btnListarAlunos.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnListarAlunos.Location = new System.Drawing.Point(328, 353);
            this.btnListarAlunos.Name = "btnListarAlunos";
            this.btnListarAlunos.Size = new System.Drawing.Size(100, 53);
            this.btnListarAlunos.TabIndex = 12;
            this.btnListarAlunos.Text = "Listar Alunos";
            this.btnListarAlunos.UseVisualStyleBackColor = true;
            this.btnListarAlunos.Click += new System.EventHandler(this.btnListarAlunos_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnExcluirAluno.Location = new System.Drawing.Point(540, 353);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(92, 53);
            this.btnExcluirAluno.TabIndex = 13;
            this.btnExcluirAluno.Text = "Excluir Aluno";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnListarChapas
            // 
            this.btnListarChapas.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnListarChapas.Location = new System.Drawing.Point(653, 353);
            this.btnListarChapas.Name = "btnListarChapas";
            this.btnListarChapas.Size = new System.Drawing.Size(100, 53);
            this.btnListarChapas.TabIndex = 14;
            this.btnListarChapas.Text = "Listar Chapas";
            this.btnListarChapas.UseVisualStyleBackColor = true;
            this.btnListarChapas.Click += new System.EventHandler(this.btnListarChapas_Click);
            // 
            // btnExcluirChapa
            // 
            this.btnExcluirChapa.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnExcluirChapa.Location = new System.Drawing.Point(883, 352);
            this.btnExcluirChapa.Name = "btnExcluirChapa";
            this.btnExcluirChapa.Size = new System.Drawing.Size(140, 53);
            this.btnExcluirChapa.TabIndex = 15;
            this.btnExcluirChapa.Text = "Desativar Chapas para Próxima Eleição";
            this.btnExcluirChapa.UseVisualStyleBackColor = true;
            this.btnExcluirChapa.Click += new System.EventHandler(this.btnExcluirChapa_Click);
            // 
            // btnLimparListas
            // 
            this.btnLimparListas.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparListas.Location = new System.Drawing.Point(12, 485);
            this.btnLimparListas.Name = "btnLimparListas";
            this.btnLimparListas.Size = new System.Drawing.Size(114, 42);
            this.btnLimparListas.TabIndex = 17;
            this.btnLimparListas.Text = "Limpar Listas";
            this.btnLimparListas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparListas.UseVisualStyleBackColor = true;
            this.btnLimparListas.Click += new System.EventHandler(this.btnLimparListas_Click);
            // 
            // btnEditarMesario
            // 
            this.btnEditarMesario.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnEditarMesario.Location = new System.Drawing.Point(107, 353);
            this.btnEditarMesario.Name = "btnEditarMesario";
            this.btnEditarMesario.Size = new System.Drawing.Size(92, 53);
            this.btnEditarMesario.TabIndex = 18;
            this.btnEditarMesario.Text = "Editar Mesário";
            this.btnEditarMesario.UseVisualStyleBackColor = true;
            this.btnEditarMesario.Click += new System.EventHandler(this.btnEditarMesario_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnEditarAluno.Location = new System.Drawing.Point(434, 353);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(100, 53);
            this.btnEditarAluno.TabIndex = 19;
            this.btnEditarAluno.Text = "Editar Aluno";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnEditarChapa
            // 
            this.btnEditarChapa.Font = new System.Drawing.Font("Adobe Caslon Pro", 9.749999F);
            this.btnEditarChapa.Location = new System.Drawing.Point(766, 353);
            this.btnEditarChapa.Name = "btnEditarChapa";
            this.btnEditarChapa.Size = new System.Drawing.Size(100, 53);
            this.btnEditarChapa.TabIndex = 20;
            this.btnEditarChapa.Text = "Editar Chapa";
            this.btnEditarChapa.UseVisualStyleBackColor = true;
            this.btnEditarChapa.Click += new System.EventHandler(this.btnEditarChapa_Click);
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1031, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditarChapa);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnEditarMesario);
            this.Controls.Add(this.btnLimparListas);
            this.Controls.Add(this.btnExcluirChapa);
            this.Controls.Add(this.btnListarChapas);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnListarAlunos);
            this.Controls.Add(this.btnExcluirMesario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbllistadechapas);
            this.Controls.Add(this.lbllistadealunos);
            this.Controls.Add(this.lbllistademesarios);
            this.Controls.Add(this.dgvChapas);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.dgvMesarios);
            this.Controls.Add(this.btnListarMesarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L I S T A G E M ";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarMesarios;
        private System.Windows.Forms.DataGridView dgvMesarios;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridView dgvChapas;
        private System.Windows.Forms.Label lbllistademesarios;
        private System.Windows.Forms.Label lbllistadealunos;
        private System.Windows.Forms.Label lbllistadechapas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirMesario;
        private System.Windows.Forms.Button btnListarAlunos;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnListarChapas;
        private System.Windows.Forms.Button btnExcluirChapa;
        private System.Windows.Forms.Button btnLimparListas;
        private System.Windows.Forms.Button btnEditarMesario;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnEditarChapa;
    }
}