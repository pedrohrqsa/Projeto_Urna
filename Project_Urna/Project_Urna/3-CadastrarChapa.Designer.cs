namespace Project_Urna
{
    partial class FrmCadastro_chapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro_chapa));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbCadastroChapa = new System.Windows.Forms.GroupBox();
            this.txtNumeroChapa = new System.Windows.Forms.TextBox();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.txtCaminhoFoto = new System.Windows.Forms.TextBox();
            this.lblCaminhoFoto = new System.Windows.Forms.Label();
            this.txtDescricaoChapa = new System.Windows.Forms.TextBox();
            this.lblDescricaoChapa = new System.Windows.Forms.Label();
            this.txtNomeVice = new System.Windows.Forms.TextBox();
            this.lblCodChapa = new System.Windows.Forms.Label();
            this.txtNomePresidente = new System.Windows.Forms.TextBox();
            this.txtNomeChapa = new System.Windows.Forms.TextBox();
            this.lblNome_Vice = new System.Windows.Forms.Label();
            this.lblNome_Presidente = new System.Windows.Forms.Label();
            this.lblNome_Chapa = new System.Windows.Forms.Label();
            this.gbCadastroChapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(630, 558);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 36);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(282, 536);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(157, 58);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbCadastroChapa
            // 
            this.gbCadastroChapa.Controls.Add(this.txtNumeroChapa);
            this.gbCadastroChapa.Controls.Add(this.lblExemplo);
            this.gbCadastroChapa.Controls.Add(this.txtCaminhoFoto);
            this.gbCadastroChapa.Controls.Add(this.lblCaminhoFoto);
            this.gbCadastroChapa.Controls.Add(this.txtDescricaoChapa);
            this.gbCadastroChapa.Controls.Add(this.lblDescricaoChapa);
            this.gbCadastroChapa.Controls.Add(this.txtNomeVice);
            this.gbCadastroChapa.Controls.Add(this.lblCodChapa);
            this.gbCadastroChapa.Controls.Add(this.txtNomePresidente);
            this.gbCadastroChapa.Controls.Add(this.txtNomeChapa);
            this.gbCadastroChapa.Controls.Add(this.lblNome_Vice);
            this.gbCadastroChapa.Controls.Add(this.lblNome_Presidente);
            this.gbCadastroChapa.Controls.Add(this.lblNome_Chapa);
            this.gbCadastroChapa.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroChapa.Location = new System.Drawing.Point(7, 3);
            this.gbCadastroChapa.Name = "gbCadastroChapa";
            this.gbCadastroChapa.Size = new System.Drawing.Size(681, 518);
            this.gbCadastroChapa.TabIndex = 13;
            this.gbCadastroChapa.TabStop = false;
            this.gbCadastroChapa.Text = "Cadastrar Chapa:";
            // 
            // txtNumeroChapa
            // 
            this.txtNumeroChapa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroChapa.Location = new System.Drawing.Point(207, 99);
            this.txtNumeroChapa.MaxLength = 5;
            this.txtNumeroChapa.Name = "txtNumeroChapa";
            this.txtNumeroChapa.Size = new System.Drawing.Size(86, 26);
            this.txtNumeroChapa.TabIndex = 2;
            this.txtNumeroChapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroChapa_KeyPress);
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemplo.ForeColor = System.Drawing.Color.Red;
            this.lblExemplo.Location = new System.Drawing.Point(261, 501);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(393, 14);
            this.lblExemplo.TabIndex = 17;
            this.lblExemplo.Text = "EXEMPLO: \"C:\\\\Users\\\\pedro_000\\\\Documents\\\\0000_Fotos_votação\\\\Foto1.png\"";
            // 
            // txtCaminhoFoto
            // 
            this.txtCaminhoFoto.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCaminhoFoto.Location = new System.Drawing.Point(207, 429);
            this.txtCaminhoFoto.MaxLength = 9999;
            this.txtCaminhoFoto.Multiline = true;
            this.txtCaminhoFoto.Name = "txtCaminhoFoto";
            this.txtCaminhoFoto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCaminhoFoto.Size = new System.Drawing.Size(447, 67);
            this.txtCaminhoFoto.TabIndex = 6;
            // 
            // lblCaminhoFoto
            // 
            this.lblCaminhoFoto.AutoSize = true;
            this.lblCaminhoFoto.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblCaminhoFoto.Location = new System.Drawing.Point(4, 429);
            this.lblCaminhoFoto.Name = "lblCaminhoFoto";
            this.lblCaminhoFoto.Size = new System.Drawing.Size(191, 17);
            this.lblCaminhoFoto.TabIndex = 16;
            this.lblCaminhoFoto.Text = "Caminho da Foto da Chapa:";
            // 
            // txtDescricaoChapa
            // 
            this.txtDescricaoChapa.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescricaoChapa.Location = new System.Drawing.Point(207, 260);
            this.txtDescricaoChapa.MaxLength = 4000;
            this.txtDescricaoChapa.Multiline = true;
            this.txtDescricaoChapa.Name = "txtDescricaoChapa";
            this.txtDescricaoChapa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricaoChapa.Size = new System.Drawing.Size(447, 118);
            this.txtDescricaoChapa.TabIndex = 5;
            // 
            // lblDescricaoChapa
            // 
            this.lblDescricaoChapa.AutoSize = true;
            this.lblDescricaoChapa.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblDescricaoChapa.Location = new System.Drawing.Point(49, 264);
            this.lblDescricaoChapa.Name = "lblDescricaoChapa";
            this.lblDescricaoChapa.Size = new System.Drawing.Size(146, 17);
            this.lblDescricaoChapa.TabIndex = 14;
            this.lblDescricaoChapa.Text = "Descrição da Chapa:";
            // 
            // txtNomeVice
            // 
            this.txtNomeVice.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeVice.Location = new System.Drawing.Point(207, 205);
            this.txtNomeVice.MaxLength = 50;
            this.txtNomeVice.Name = "txtNomeVice";
            this.txtNomeVice.Size = new System.Drawing.Size(447, 26);
            this.txtNomeVice.TabIndex = 4;
            // 
            // lblCodChapa
            // 
            this.lblCodChapa.AutoSize = true;
            this.lblCodChapa.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblCodChapa.Location = new System.Drawing.Point(64, 103);
            this.lblCodChapa.Name = "lblCodChapa";
            this.lblCodChapa.Size = new System.Drawing.Size(131, 17);
            this.lblCodChapa.TabIndex = 14;
            this.lblCodChapa.Text = "Número da Chapa:";
            // 
            // txtNomePresidente
            // 
            this.txtNomePresidente.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomePresidente.Location = new System.Drawing.Point(207, 154);
            this.txtNomePresidente.MaxLength = 50;
            this.txtNomePresidente.Name = "txtNomePresidente";
            this.txtNomePresidente.Size = new System.Drawing.Size(447, 26);
            this.txtNomePresidente.TabIndex = 3;
            // 
            // txtNomeChapa
            // 
            this.txtNomeChapa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeChapa.Location = new System.Drawing.Point(207, 45);
            this.txtNomeChapa.MaxLength = 50;
            this.txtNomeChapa.Name = "txtNomeChapa";
            this.txtNomeChapa.Size = new System.Drawing.Size(447, 26);
            this.txtNomeChapa.TabIndex = 1;
            // 
            // lblNome_Vice
            // 
            this.lblNome_Vice.AutoSize = true;
            this.lblNome_Vice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblNome_Vice.Location = new System.Drawing.Point(6, 209);
            this.lblNome_Vice.Name = "lblNome_Vice";
            this.lblNome_Vice.Size = new System.Drawing.Size(195, 17);
            this.lblNome_Vice.TabIndex = 2;
            this.lblNome_Vice.Text = "Nome do Vice Presidente(a):";
            // 
            // lblNome_Presidente
            // 
            this.lblNome_Presidente.AutoSize = true;
            this.lblNome_Presidente.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblNome_Presidente.Location = new System.Drawing.Point(38, 158);
            this.lblNome_Presidente.Name = "lblNome_Presidente";
            this.lblNome_Presidente.Size = new System.Drawing.Size(163, 17);
            this.lblNome_Presidente.TabIndex = 1;
            this.lblNome_Presidente.Text = "Nome do Presidente(a):";
            // 
            // lblNome_Chapa
            // 
            this.lblNome_Chapa.AutoSize = true;
            this.lblNome_Chapa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Chapa.Location = new System.Drawing.Point(77, 49);
            this.lblNome_Chapa.Name = "lblNome_Chapa";
            this.lblNome_Chapa.Size = new System.Drawing.Size(118, 17);
            this.lblNome_Chapa.TabIndex = 0;
            this.lblNome_Chapa.Text = "Nome da Chapa:";
            // 
            // FrmCadastro_chapa
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(691, 598);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbCadastroChapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastro_chapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Chapa";
            this.Load += new System.EventHandler(this.FrmCadastro_chapa_Load);
            this.gbCadastroChapa.ResumeLayout(false);
            this.gbCadastroChapa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.GroupBox gbCadastroChapa;
        public System.Windows.Forms.Label lblCodChapa;
        public System.Windows.Forms.TextBox txtNomeVice;
        public System.Windows.Forms.TextBox txtNomePresidente;
        public System.Windows.Forms.TextBox txtNomeChapa;
        public System.Windows.Forms.Label lblNome_Vice;
        public System.Windows.Forms.Label lblNome_Presidente;
        public System.Windows.Forms.Label lblNome_Chapa;
        private System.Windows.Forms.TextBox txtDescricaoChapa;
        private System.Windows.Forms.Label lblDescricaoChapa;
        private System.Windows.Forms.Label lblCaminhoFoto;
        private System.Windows.Forms.TextBox txtCaminhoFoto;
        private System.Windows.Forms.Label lblExemplo;
        public System.Windows.Forms.TextBox txtNumeroChapa;
    }
}