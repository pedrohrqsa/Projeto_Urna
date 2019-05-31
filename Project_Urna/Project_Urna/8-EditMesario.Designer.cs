namespace Project_Urna
{
    partial class EditMesario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMesario));
            this.gbEditMesario = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodM = new System.Windows.Forms.TextBox();
            this.lbcodmesario = new System.Windows.Forms.Label();
            this.txtSenhaM = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtID_Mesario = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.lblID_MESARIO = new System.Windows.Forms.Label();
            this.lblNome_Mesario = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbEditMesario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditMesario
            // 
            this.gbEditMesario.Controls.Add(this.btnPesquisar);
            this.gbEditMesario.Controls.Add(this.txtCodM);
            this.gbEditMesario.Controls.Add(this.lbcodmesario);
            this.gbEditMesario.Controls.Add(this.txtSenhaM);
            this.gbEditMesario.Controls.Add(this.lblSenha);
            this.gbEditMesario.Controls.Add(this.txtID_Mesario);
            this.gbEditMesario.Controls.Add(this.txtNomeM);
            this.gbEditMesario.Controls.Add(this.lblID_MESARIO);
            this.gbEditMesario.Controls.Add(this.lblNome_Mesario);
            this.gbEditMesario.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.gbEditMesario.Location = new System.Drawing.Point(6, 12);
            this.gbEditMesario.Name = "gbEditMesario";
            this.gbEditMesario.Size = new System.Drawing.Size(480, 235);
            this.gbEditMesario.TabIndex = 0;
            this.gbEditMesario.TabStop = false;
            this.gbEditMesario.Text = "Editar Mesário:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(302, 51);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 26);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodM
            // 
            this.txtCodM.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCodM.Location = new System.Drawing.Point(233, 51);
            this.txtCodM.MaxLength = 5;
            this.txtCodM.Name = "txtCodM";
            this.txtCodM.Size = new System.Drawing.Size(63, 26);
            this.txtCodM.TabIndex = 1;
            this.txtCodM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodM_KeyPress);
            // 
            // lbcodmesario
            // 
            this.lbcodmesario.AutoSize = true;
            this.lbcodmesario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodmesario.Location = new System.Drawing.Point(143, 55);
            this.lbcodmesario.Name = "lbcodmesario";
            this.lbcodmesario.Size = new System.Drawing.Size(84, 22);
            this.lbcodmesario.TabIndex = 4;
            this.lbcodmesario.Text = "Código:";
            // 
            // txtSenhaM
            // 
            this.txtSenhaM.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenhaM.Location = new System.Drawing.Point(233, 192);
            this.txtSenhaM.MaxLength = 20;
            this.txtSenhaM.Name = "txtSenhaM";
            this.txtSenhaM.PasswordChar = '*';
            this.txtSenhaM.Size = new System.Drawing.Size(154, 26);
            this.txtSenhaM.TabIndex = 5;
            this.txtSenhaM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaM_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSenha.Location = new System.Drawing.Point(158, 192);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtID_Mesario
            // 
            this.txtID_Mesario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtID_Mesario.Location = new System.Drawing.Point(233, 145);
            this.txtID_Mesario.MaxLength = 10;
            this.txtID_Mesario.Name = "txtID_Mesario";
            this.txtID_Mesario.Size = new System.Drawing.Size(154, 26);
            this.txtID_Mesario.TabIndex = 4;
            // 
            // txtNomeM
            // 
            this.txtNomeM.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeM.Location = new System.Drawing.Point(233, 101);
            this.txtNomeM.MaxLength = 50;
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(240, 26);
            this.txtNomeM.TabIndex = 3;
            // 
            // lblID_MESARIO
            // 
            this.lblID_MESARIO.AutoSize = true;
            this.lblID_MESARIO.Font = new System.Drawing.Font("Arial", 14F);
            this.lblID_MESARIO.Location = new System.Drawing.Point(5, 145);
            this.lblID_MESARIO.Name = "lblID_MESARIO";
            this.lblID_MESARIO.Size = new System.Drawing.Size(222, 22);
            this.lblID_MESARIO.TabIndex = 1;
            this.lblID_MESARIO.Text = "Identificação do Mesário:";
            // 
            // lblNome_Mesario
            // 
            this.lblNome_Mesario.AutoSize = true;
            this.lblNome_Mesario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Mesario.Location = new System.Drawing.Point(62, 101);
            this.lblNome_Mesario.Name = "lblNome_Mesario";
            this.lblNome_Mesario.Size = new System.Drawing.Size(165, 22);
            this.lblNome_Mesario.TabIndex = 0;
            this.lblNome_Mesario.Text = "Nome do Mesário:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(122, 253);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(401, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(260, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 39);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // EditMesario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(490, 380);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbEditMesario);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditMesario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Mesário";
            this.Load += new System.EventHandler(this.EditMesario_Load);
            this.gbEditMesario.ResumeLayout(false);
            this.gbEditMesario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbEditMesario;
        public System.Windows.Forms.TextBox txtSenhaM;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtID_Mesario;
        public System.Windows.Forms.TextBox txtNomeM;
        public System.Windows.Forms.Label lblID_MESARIO;
        public System.Windows.Forms.Label lblNome_Mesario;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtCodM;
        public System.Windows.Forms.Label lbcodmesario;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnLimpar;
    }
}