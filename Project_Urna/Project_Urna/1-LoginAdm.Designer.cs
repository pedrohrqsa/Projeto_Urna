namespace Project_Urna
{
    partial class frmAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdm));
            this.btnSair = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.BtnEntraMesario = new System.Windows.Forms.Button();
            this.btnEntraADM = new System.Windows.Forms.Button();
            this.txtMesario = new System.Windows.Forms.TextBox();
            this.lblIdAdm = new System.Windows.Forms.Label();
            this.lblMe = new System.Windows.Forms.Label();
            this.txtAdm = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(323, 190);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 32);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbLogin.BackColor = System.Drawing.Color.Lavender;
            this.gbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbLogin.Controls.Add(this.btnSair);
            this.gbLogin.Controls.Add(this.lblSenha);
            this.gbLogin.Controls.Add(this.txtSenha);
            this.gbLogin.Controls.Add(this.BtnEntraMesario);
            this.gbLogin.Controls.Add(this.btnEntraADM);
            this.gbLogin.Controls.Add(this.txtMesario);
            this.gbLogin.Controls.Add(this.lblIdAdm);
            this.gbLogin.Controls.Add(this.lblMe);
            this.gbLogin.Controls.Add(this.txtAdm);
            this.gbLogin.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.gbLogin.Location = new System.Drawing.Point(243, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(398, 222);
            this.gbLogin.TabIndex = 10;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Identificação:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(223, 71);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 35);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txtSenha.Location = new System.Drawing.Point(289, 78);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(103, 22);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdm_KeyPress);
            // 
            // BtnEntraMesario
            // 
            this.BtnEntraMesario.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEntraMesario.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEntraMesario.ForeColor = System.Drawing.Color.Red;
            this.BtnEntraMesario.Location = new System.Drawing.Point(289, 121);
            this.BtnEntraMesario.Name = "BtnEntraMesario";
            this.BtnEntraMesario.Size = new System.Drawing.Size(103, 43);
            this.BtnEntraMesario.TabIndex = 5;
            this.BtnEntraMesario.Text = "ENTRAR";
            this.BtnEntraMesario.UseVisualStyleBackColor = false;
            this.BtnEntraMesario.Click += new System.EventHandler(this.BtnEntraMesario_Click);
            // 
            // btnEntraADM
            // 
            this.btnEntraADM.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntraADM.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntraADM.ForeColor = System.Drawing.Color.Red;
            this.btnEntraADM.Location = new System.Drawing.Point(65, 121);
            this.btnEntraADM.Name = "btnEntraADM";
            this.btnEntraADM.Size = new System.Drawing.Size(103, 41);
            this.btnEntraADM.TabIndex = 2;
            this.btnEntraADM.Text = "ENTRAR";
            this.btnEntraADM.UseVisualStyleBackColor = false;
            this.btnEntraADM.Click += new System.EventHandler(this.btnEntra_Click);
            // 
            // txtMesario
            // 
            this.txtMesario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesario.Location = new System.Drawing.Point(289, 43);
            this.txtMesario.MaxLength = 7;
            this.txtMesario.Name = "txtMesario";
            this.txtMesario.Size = new System.Drawing.Size(103, 22);
            this.txtMesario.TabIndex = 3;
            // 
            // lblIdAdm
            // 
            this.lblIdAdm.AutoSize = true;
            this.lblIdAdm.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAdm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblIdAdm.Location = new System.Drawing.Point(0, 41);
            this.lblIdAdm.Name = "lblIdAdm";
            this.lblIdAdm.Size = new System.Drawing.Size(60, 28);
            this.lblIdAdm.TabIndex = 3;
            this.lblIdAdm.Text = "ID_ADM:";
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMe.Location = new System.Drawing.Point(214, 36);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(74, 35);
            this.lblMe.TabIndex = 4;
            this.lblMe.Text = "Mesário:";
            // 
            // txtAdm
            // 
            this.txtAdm.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txtAdm.Location = new System.Drawing.Point(65, 43);
            this.txtAdm.MaxLength = 7;
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.PasswordChar = '*';
            this.txtAdm.Size = new System.Drawing.Size(103, 22);
            this.txtAdm.TabIndex = 1;
            this.txtAdm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdm_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 238);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdm
            // 
            this.AcceptButton = this.btnEntraADM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(644, 238);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.frmAdm_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblIdAdm;
        private System.Windows.Forms.TextBox txtAdm;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.TextBox txtMesario;
        private System.Windows.Forms.Button btnEntraADM;
        private System.Windows.Forms.Button BtnEntraMesario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}