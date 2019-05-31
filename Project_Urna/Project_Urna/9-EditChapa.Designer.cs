namespace Project_Urna
{
    partial class FrmEditChapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditChapa));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbCadastroChapa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroChapa = new System.Windows.Forms.TextBox();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.txtCaminhoFoto = new System.Windows.Forms.TextBox();
            this.lblCaminhoFoto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricaoChapa = new System.Windows.Forms.Label();
            this.txtNomeVice = new System.Windows.Forms.TextBox();
            this.lblCodChapa = new System.Windows.Forms.Label();
            this.txtNomePresidente = new System.Windows.Forms.TextBox();
            this.txtNomeChapa = new System.Windows.Forms.TextBox();
            this.lblNome_Vice = new System.Windows.Forms.Label();
            this.lblNome_Presidente = new System.Windows.Forms.Label();
            this.lblNome_Chapa = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbCadastroChapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(631, 575);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 36);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(272, 553);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 58);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbCadastroChapa
            // 
            this.gbCadastroChapa.Controls.Add(this.btnPesquisar);
            this.gbCadastroChapa.Controls.Add(this.txtCodC);
            this.gbCadastroChapa.Controls.Add(this.label1);
            this.gbCadastroChapa.Controls.Add(this.txtNumeroChapa);
            this.gbCadastroChapa.Controls.Add(this.lblExemplo);
            this.gbCadastroChapa.Controls.Add(this.txtCaminhoFoto);
            this.gbCadastroChapa.Controls.Add(this.lblCaminhoFoto);
            this.gbCadastroChapa.Controls.Add(this.txtDescricao);
            this.gbCadastroChapa.Controls.Add(this.lblDescricaoChapa);
            this.gbCadastroChapa.Controls.Add(this.txtNomeVice);
            this.gbCadastroChapa.Controls.Add(this.lblCodChapa);
            this.gbCadastroChapa.Controls.Add(this.txtNomePresidente);
            this.gbCadastroChapa.Controls.Add(this.txtNomeChapa);
            this.gbCadastroChapa.Controls.Add(this.lblNome_Vice);
            this.gbCadastroChapa.Controls.Add(this.lblNome_Presidente);
            this.gbCadastroChapa.Controls.Add(this.lblNome_Chapa);
            this.gbCadastroChapa.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroChapa.Location = new System.Drawing.Point(8, 9);
            this.gbCadastroChapa.Name = "gbCadastroChapa";
            this.gbCadastroChapa.Size = new System.Drawing.Size(681, 538);
            this.gbCadastroChapa.TabIndex = 16;
            this.gbCadastroChapa.TabStop = false;
            this.gbCadastroChapa.Text = "Editar Chapa:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(299, 47);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 26);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodC
            // 
            this.txtCodC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodC.Location = new System.Drawing.Point(207, 47);
            this.txtCodC.MaxLength = 5;
            this.txtCodC.Name = "txtCodC";
            this.txtCodC.Size = new System.Drawing.Size(86, 26);
            this.txtCodC.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código:";
            // 
            // txtNumeroChapa
            // 
            this.txtNumeroChapa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroChapa.Location = new System.Drawing.Point(207, 145);
            this.txtNumeroChapa.MaxLength = 5;
            this.txtNumeroChapa.Name = "txtNumeroChapa";
            this.txtNumeroChapa.Size = new System.Drawing.Size(56, 26);
            this.txtNumeroChapa.TabIndex = 2;
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemplo.ForeColor = System.Drawing.Color.Red;
            this.lblExemplo.Location = new System.Drawing.Point(261, 518);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(393, 14);
            this.lblExemplo.TabIndex = 17;
            this.lblExemplo.Text = "EXEMPLO: \"C:\\\\Users\\\\pedro_000\\\\Documents\\\\0000_Fotos_votação\\\\Foto1.png\"";
            // 
            // txtCaminhoFoto
            // 
            this.txtCaminhoFoto.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCaminhoFoto.Location = new System.Drawing.Point(207, 446);
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
            this.lblCaminhoFoto.Location = new System.Drawing.Point(4, 446);
            this.lblCaminhoFoto.Name = "lblCaminhoFoto";
            this.lblCaminhoFoto.Size = new System.Drawing.Size(191, 17);
            this.lblCaminhoFoto.TabIndex = 16;
            this.lblCaminhoFoto.Text = "Caminho da Foto da Chapa:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(207, 291);
            this.txtDescricao.MaxLength = 4000;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(447, 118);
            this.txtDescricao.TabIndex = 5;
            // 
            // lblDescricaoChapa
            // 
            this.lblDescricaoChapa.AutoSize = true;
            this.lblDescricaoChapa.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblDescricaoChapa.Location = new System.Drawing.Point(49, 291);
            this.lblDescricaoChapa.Name = "lblDescricaoChapa";
            this.lblDescricaoChapa.Size = new System.Drawing.Size(146, 17);
            this.lblDescricaoChapa.TabIndex = 14;
            this.lblDescricaoChapa.Text = "Descrição da Chapa:";
            // 
            // txtNomeVice
            // 
            this.txtNomeVice.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeVice.Location = new System.Drawing.Point(207, 239);
            this.txtNomeVice.MaxLength = 50;
            this.txtNomeVice.Name = "txtNomeVice";
            this.txtNomeVice.Size = new System.Drawing.Size(447, 26);
            this.txtNomeVice.TabIndex = 4;
            // 
            // lblCodChapa
            // 
            this.lblCodChapa.AutoSize = true;
            this.lblCodChapa.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblCodChapa.Location = new System.Drawing.Point(64, 149);
            this.lblCodChapa.Name = "lblCodChapa";
            this.lblCodChapa.Size = new System.Drawing.Size(131, 17);
            this.lblCodChapa.TabIndex = 14;
            this.lblCodChapa.Text = "Número da Chapa:";
            // 
            // txtNomePresidente
            // 
            this.txtNomePresidente.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomePresidente.Location = new System.Drawing.Point(207, 188);
            this.txtNomePresidente.MaxLength = 50;
            this.txtNomePresidente.Name = "txtNomePresidente";
            this.txtNomePresidente.Size = new System.Drawing.Size(447, 26);
            this.txtNomePresidente.TabIndex = 3;
            // 
            // txtNomeChapa
            // 
            this.txtNomeChapa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeChapa.Location = new System.Drawing.Point(207, 103);
            this.txtNomeChapa.MaxLength = 50;
            this.txtNomeChapa.Name = "txtNomeChapa";
            this.txtNomeChapa.Size = new System.Drawing.Size(447, 26);
            this.txtNomeChapa.TabIndex = 1;
            // 
            // lblNome_Vice
            // 
            this.lblNome_Vice.AutoSize = true;
            this.lblNome_Vice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblNome_Vice.Location = new System.Drawing.Point(6, 243);
            this.lblNome_Vice.Name = "lblNome_Vice";
            this.lblNome_Vice.Size = new System.Drawing.Size(195, 17);
            this.lblNome_Vice.TabIndex = 2;
            this.lblNome_Vice.Text = "Nome do Vice Presidente(a):";
            // 
            // lblNome_Presidente
            // 
            this.lblNome_Presidente.AutoSize = true;
            this.lblNome_Presidente.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblNome_Presidente.Location = new System.Drawing.Point(38, 192);
            this.lblNome_Presidente.Name = "lblNome_Presidente";
            this.lblNome_Presidente.Size = new System.Drawing.Size(163, 17);
            this.lblNome_Presidente.TabIndex = 1;
            this.lblNome_Presidente.Text = "Nome do Presidente(a):";
            // 
            // lblNome_Chapa
            // 
            this.lblNome_Chapa.AutoSize = true;
            this.lblNome_Chapa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Chapa.Location = new System.Drawing.Point(77, 107);
            this.lblNome_Chapa.Name = "lblNome_Chapa";
            this.lblNome_Chapa.Size = new System.Drawing.Size(118, 17);
            this.lblNome_Chapa.TabIndex = 0;
            this.lblNome_Chapa.Text = "Nome da Chapa:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(8, 572);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 39);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "&Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmEditChapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(697, 613);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbCadastroChapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEditChapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Chapa";
            this.Load += new System.EventHandler(this.FrmEditChapa_Load);
            this.gbCadastroChapa.ResumeLayout(false);
            this.gbCadastroChapa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.GroupBox gbCadastroChapa;
        public System.Windows.Forms.TextBox txtCodC;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumeroChapa;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.TextBox txtCaminhoFoto;
        private System.Windows.Forms.Label lblCaminhoFoto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricaoChapa;
        public System.Windows.Forms.TextBox txtNomeVice;
        public System.Windows.Forms.Label lblCodChapa;
        public System.Windows.Forms.TextBox txtNomePresidente;
        public System.Windows.Forms.TextBox txtNomeChapa;
        public System.Windows.Forms.Label lblNome_Vice;
        public System.Windows.Forms.Label lblNome_Presidente;
        public System.Windows.Forms.Label lblNome_Chapa;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnLimpar;
    }
}