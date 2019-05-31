namespace Project_Urna
{
    partial class FrmEditAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAluno));
            this.btnSair = new System.Windows.Forms.Button();
            this.gbCadastroAlunos = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaAluno = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblRM = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbCadastroAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(425, 355);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 36);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "&Cancelar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbCadastroAlunos
            // 
            this.gbCadastroAlunos.Controls.Add(this.btnPesquisar);
            this.gbCadastroAlunos.Controls.Add(this.txtCodA);
            this.gbCadastroAlunos.Controls.Add(this.label1);
            this.gbCadastroAlunos.Controls.Add(this.txtSenhaAluno);
            this.gbCadastroAlunos.Controls.Add(this.lblSenha);
            this.gbCadastroAlunos.Controls.Add(this.txtRM);
            this.gbCadastroAlunos.Controls.Add(this.txtNomeAluno);
            this.gbCadastroAlunos.Controls.Add(this.lblRM);
            this.gbCadastroAlunos.Controls.Add(this.lblNomeAluno);
            this.gbCadastroAlunos.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic);
            this.gbCadastroAlunos.Location = new System.Drawing.Point(11, 15);
            this.gbCadastroAlunos.Name = "gbCadastroAlunos";
            this.gbCadastroAlunos.Size = new System.Drawing.Size(492, 257);
            this.gbCadastroAlunos.TabIndex = 22;
            this.gbCadastroAlunos.TabStop = false;
            this.gbCadastroAlunos.Text = "Editar Aluno";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(266, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 26);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodA
            // 
            this.txtCodA.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCodA.Location = new System.Drawing.Point(188, 44);
            this.txtCodA.MaxLength = 50;
            this.txtCodA.Name = "txtCodA";
            this.txtCodA.Size = new System.Drawing.Size(72, 26);
            this.txtCodA.TabIndex = 5;
            this.txtCodA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // txtSenhaAluno
            // 
            this.txtSenhaAluno.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenhaAluno.Location = new System.Drawing.Point(188, 185);
            this.txtSenhaAluno.MaxLength = 15;
            this.txtSenhaAluno.Name = "txtSenhaAluno";
            this.txtSenhaAluno.PasswordChar = '*';
            this.txtSenhaAluno.Size = new System.Drawing.Size(249, 26);
            this.txtSenhaAluno.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSenha.Location = new System.Drawing.Point(93, 185);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtRM
            // 
            this.txtRM.Font = new System.Drawing.Font("Arial", 12F);
            this.txtRM.Location = new System.Drawing.Point(188, 138);
            this.txtRM.MaxLength = 5;
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(249, 26);
            this.txtRM.TabIndex = 2;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeAluno.Location = new System.Drawing.Point(188, 90);
            this.txtNomeAluno.MaxLength = 50;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(249, 26);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Font = new System.Drawing.Font("Arial", 14F);
            this.lblRM.Location = new System.Drawing.Point(118, 138);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(44, 22);
            this.lblRM.TabIndex = 1;
            this.lblRM.Text = "RM:";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(17, 94);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(145, 22);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome do Aluno:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(271, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 39);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(133, 278);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 39);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmEditAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 393);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbCadastroAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEditAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Aluno";
            this.Load += new System.EventHandler(this.EditAluno_Load);
            this.gbCadastroAlunos.ResumeLayout(false);
            this.gbCadastroAlunos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.GroupBox gbCadastroAlunos;
        public System.Windows.Forms.TextBox txtCodA;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSenhaAluno;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtRM;
        public System.Windows.Forms.TextBox txtNomeAluno;
        public System.Windows.Forms.Label lblRM;
        public System.Windows.Forms.Label lblNomeAluno;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnEditar;
    }
}