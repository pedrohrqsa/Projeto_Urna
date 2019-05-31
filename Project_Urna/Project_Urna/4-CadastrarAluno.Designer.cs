namespace Project_Urna
{
    partial class FrmCadastrarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarAluno));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbCadastroAlunos = new System.Windows.Forms.GroupBox();
            this.txtSenhaDoAluno = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblRM = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.gbCadastroAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(171, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(157, 58);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(436, 232);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbCadastroAlunos
            // 
            this.gbCadastroAlunos.Controls.Add(this.txtSenhaDoAluno);
            this.gbCadastroAlunos.Controls.Add(this.lblSenha);
            this.gbCadastroAlunos.Controls.Add(this.txtRM);
            this.gbCadastroAlunos.Controls.Add(this.txtNomeAluno);
            this.gbCadastroAlunos.Controls.Add(this.lblRM);
            this.gbCadastroAlunos.Controls.Add(this.lblNomeAluno);
            this.gbCadastroAlunos.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic);
            this.gbCadastroAlunos.Location = new System.Drawing.Point(2, -1);
            this.gbCadastroAlunos.Name = "gbCadastroAlunos";
            this.gbCadastroAlunos.Size = new System.Drawing.Size(492, 185);
            this.gbCadastroAlunos.TabIndex = 19;
            this.gbCadastroAlunos.TabStop = false;
            this.gbCadastroAlunos.Text = "Cadastrar Aluno:";
            // 
            // txtSenhaDoAluno
            // 
            this.txtSenhaDoAluno.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenhaDoAluno.Location = new System.Drawing.Point(235, 149);
            this.txtSenhaDoAluno.MaxLength = 15;
            this.txtSenhaDoAluno.Name = "txtSenhaDoAluno";
            this.txtSenhaDoAluno.PasswordChar = '*';
            this.txtSenhaDoAluno.Size = new System.Drawing.Size(249, 26);
            this.txtSenhaDoAluno.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSenha.Location = new System.Drawing.Point(140, 149);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtRM
            // 
            this.txtRM.Font = new System.Drawing.Font("Arial", 12F);
            this.txtRM.Location = new System.Drawing.Point(235, 102);
            this.txtRM.MaxLength = 5;
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(249, 26);
            this.txtRM.TabIndex = 2;
            this.txtRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRM_KeyPress);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeAluno.Location = new System.Drawing.Point(235, 54);
            this.txtNomeAluno.MaxLength = 50;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(249, 26);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Font = new System.Drawing.Font("Arial", 14F);
            this.lblRM.Location = new System.Drawing.Point(165, 102);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(44, 22);
            this.lblRM.TabIndex = 1;
            this.lblRM.Text = "RM:";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(64, 58);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(145, 22);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome do Aluno:";
            // 
            // FrmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 270);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbCadastroAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.FrmCadastrarAluno_Load);
            this.gbCadastroAlunos.ResumeLayout(false);
            this.gbCadastroAlunos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.GroupBox gbCadastroAlunos;
        public System.Windows.Forms.TextBox txtSenhaDoAluno;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtRM;
        public System.Windows.Forms.TextBox txtNomeAluno;
        public System.Windows.Forms.Label lblRM;
        public System.Windows.Forms.Label lblNomeAluno;
    }
}