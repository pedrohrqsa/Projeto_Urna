namespace Project_Urna
{
    partial class FrmCadastroMesario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMesario));
            this.gbCadastroMesario = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtID_Mesario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblID_MESARIO = new System.Windows.Forms.Label();
            this.lblNome_Mesario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbCadastroMesario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastroMesario
            // 
            this.gbCadastroMesario.Controls.Add(this.txtSenha);
            this.gbCadastroMesario.Controls.Add(this.lblSenha);
            this.gbCadastroMesario.Controls.Add(this.txtID_Mesario);
            this.gbCadastroMesario.Controls.Add(this.txtNome);
            this.gbCadastroMesario.Controls.Add(this.lblID_MESARIO);
            this.gbCadastroMesario.Controls.Add(this.lblNome_Mesario);
            this.gbCadastroMesario.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.gbCadastroMesario.Location = new System.Drawing.Point(2, 4);
            this.gbCadastroMesario.Name = "gbCadastroMesario";
            this.gbCadastroMesario.Size = new System.Drawing.Size(492, 185);
            this.gbCadastroMesario.TabIndex = 16;
            this.gbCadastroMesario.TabStop = false;
            this.gbCadastroMesario.Text = "Cadastrar Mesário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenha.Location = new System.Drawing.Point(235, 149);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(160, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSenha.Location = new System.Drawing.Point(160, 149);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtID_Mesario
            // 
            this.txtID_Mesario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtID_Mesario.Location = new System.Drawing.Point(235, 102);
            this.txtID_Mesario.MaxLength = 10;
            this.txtID_Mesario.Name = "txtID_Mesario";
            this.txtID_Mesario.Size = new System.Drawing.Size(160, 26);
            this.txtID_Mesario.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNome.Location = new System.Drawing.Point(235, 54);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblID_MESARIO
            // 
            this.lblID_MESARIO.AutoSize = true;
            this.lblID_MESARIO.Font = new System.Drawing.Font("Arial", 14F);
            this.lblID_MESARIO.Location = new System.Drawing.Point(7, 105);
            this.lblID_MESARIO.Name = "lblID_MESARIO";
            this.lblID_MESARIO.Size = new System.Drawing.Size(222, 22);
            this.lblID_MESARIO.TabIndex = 1;
            this.lblID_MESARIO.Text = "Identificação do Mesário:";
            // 
            // lblNome_Mesario
            // 
            this.lblNome_Mesario.AutoSize = true;
            this.lblNome_Mesario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Mesario.Location = new System.Drawing.Point(64, 58);
            this.lblNome_Mesario.Name = "lblNome_Mesario";
            this.lblNome_Mesario.Size = new System.Drawing.Size(165, 22);
            this.lblNome_Mesario.TabIndex = 0;
            this.lblNome_Mesario.Text = "Nome do Mesário:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(436, 251);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(166, 229);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(157, 58);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastroMesario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 292);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbCadastroMesario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroMesario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Mesario";
            this.Load += new System.EventHandler(this.FrmCadastroMesario_Load);
            this.gbCadastroMesario.ResumeLayout(false);
            this.gbCadastroMesario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbCadastroMesario;
        public System.Windows.Forms.TextBox txtID_Mesario;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label lblID_MESARIO;
        public System.Windows.Forms.Label lblNome_Mesario;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.Label lblSenha;
    }
}