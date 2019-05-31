namespace Project_Urna
{
    partial class FrmVota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVota));
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblChapa = new System.Windows.Forms.Label();
            this.lblVice = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtChapa = new System.Windows.Forms.TextBox();
            this.txtViceP = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.btnNulo = new System.Windows.Forms.Button();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.lblPresidente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblESC = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnC5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(56, 14);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(73, 18);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // lblChapa
            // 
            this.lblChapa.AutoSize = true;
            this.lblChapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapa.Location = new System.Drawing.Point(68, 50);
            this.lblChapa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChapa.Name = "lblChapa";
            this.lblChapa.Size = new System.Drawing.Size(61, 18);
            this.lblChapa.TabIndex = 2;
            this.lblChapa.Text = "Chapa:";
            // 
            // lblVice
            // 
            this.lblVice.AutoSize = true;
            this.lblVice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVice.Location = new System.Drawing.Point(-2, 139);
            this.lblVice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVice.Name = "lblVice";
            this.lblVice.Size = new System.Drawing.Size(131, 18);
            this.lblVice.TabIndex = 3;
            this.lblVice.Text = "Vice-Presidente:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(131, 9);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 30);
            this.txtNumero.TabIndex = 0;
            // 
            // txtChapa
            // 
            this.txtChapa.Enabled = false;
            this.txtChapa.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapa.Location = new System.Drawing.Point(131, 45);
            this.txtChapa.MaxLength = 50;
            this.txtChapa.Name = "txtChapa";
            this.txtChapa.Size = new System.Drawing.Size(234, 30);
            this.txtChapa.TabIndex = 0;
            // 
            // txtViceP
            // 
            this.txtViceP.Enabled = false;
            this.txtViceP.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViceP.Location = new System.Drawing.Point(131, 134);
            this.txtViceP.MaxLength = 50;
            this.txtViceP.Name = "txtViceP";
            this.txtViceP.Size = new System.Drawing.Size(234, 30);
            this.txtViceP.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(602, 499);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 74);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.BackColor = System.Drawing.Color.Gold;
            this.btnCorrigir.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold);
            this.btnCorrigir.ForeColor = System.Drawing.Color.Black;
            this.btnCorrigir.Location = new System.Drawing.Point(720, 499);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(113, 74);
            this.btnCorrigir.TabIndex = 7;
            this.btnCorrigir.Text = "CORRIGIR";
            this.btnCorrigir.UseVisualStyleBackColor = false;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // btnNulo
            // 
            this.btnNulo.BackColor = System.Drawing.Color.Red;
            this.btnNulo.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold);
            this.btnNulo.ForeColor = System.Drawing.Color.White;
            this.btnNulo.Location = new System.Drawing.Point(839, 499);
            this.btnNulo.Name = "btnNulo";
            this.btnNulo.Size = new System.Drawing.Size(112, 74);
            this.btnNulo.TabIndex = 8;
            this.btnNulo.Text = "NULO";
            this.btnNulo.UseVisualStyleBackColor = false;
            this.btnNulo.Click += new System.EventHandler(this.btnNulo_Click);
            // 
            // txtPresidente
            // 
            this.txtPresidente.Enabled = false;
            this.txtPresidente.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresidente.Location = new System.Drawing.Point(131, 90);
            this.txtPresidente.MaxLength = 50;
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(234, 30);
            this.txtPresidente.TabIndex = 0;
            // 
            // lblPresidente
            // 
            this.lblPresidente.AutoSize = true;
            this.lblPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresidente.Location = new System.Drawing.Point(36, 95);
            this.lblPresidente.Name = "lblPresidente";
            this.lblPresidente.Size = new System.Drawing.Size(93, 18);
            this.lblPresidente.TabIndex = 4;
            this.lblPresidente.Text = "Presidente:";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Caslon Pro", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 293);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição da Chapa:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Adobe Garamond Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(6, 35);
            this.txtDescricao.MaxLength = 4000;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(350, 252);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblESC
            // 
            this.lblESC.AutoSize = true;
            this.lblESC.BackColor = System.Drawing.Color.Transparent;
            this.lblESC.Font = new System.Drawing.Font("Bradley Hand ITC", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESC.ForeColor = System.Drawing.Color.Aqua;
            this.lblESC.Location = new System.Drawing.Point(422, 9);
            this.lblESC.Name = "lblESC";
            this.lblESC.Size = new System.Drawing.Size(387, 50);
            this.lblESC.TabIndex = 0;
            this.lblESC.Text = "Escolha sua Chapa!!!";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(393, 77);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(405, 386);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 33;
            this.pb1.TabStop = false;
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(814, 96);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(127, 43);
            this.btnC1.TabIndex = 1;
            this.btnC1.Text = "Chapa 1";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(814, 173);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(127, 43);
            this.btnC2.TabIndex = 2;
            this.btnC2.Text = "Chapa 2";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(814, 250);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(127, 43);
            this.btnC3.TabIndex = 3;
            this.btnC3.Text = "Chapa 3";
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // btnC4
            // 
            this.btnC4.Location = new System.Drawing.Point(814, 327);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(127, 43);
            this.btnC4.TabIndex = 4;
            this.btnC4.Text = "Chapa 4";
            this.btnC4.UseVisualStyleBackColor = true;
            this.btnC4.Click += new System.EventHandler(this.btnC4_Click);
            // 
            // btnC5
            // 
            this.btnC5.Location = new System.Drawing.Point(814, 403);
            this.btnC5.Name = "btnC5";
            this.btnC5.Size = new System.Drawing.Size(127, 43);
            this.btnC5.TabIndex = 5;
            this.btnC5.Text = "Chapa 5";
            this.btnC5.UseVisualStyleBackColor = true;
            this.btnC5.Click += new System.EventHandler(this.btnC5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verde - Confirma o voto.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(2, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amarelo - Corrige para refazer o processo de votação.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nulo - Anula o voto.";
            // 
            // FrmVota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(953, 574);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnC5);
            this.Controls.Add(this.btnC4);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblESC);
            this.Controls.Add(this.lblVice);
            this.Controls.Add(this.lblChapa);
            this.Controls.Add(this.txtViceP);
            this.Controls.Add(this.txtChapa);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblPresidente);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNulo);
            this.Controls.Add(this.btnCorrigir);
            this.Controls.Add(this.btnConfirmar);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.Load += new System.EventHandler(this.FrmVota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblChapa;
        private System.Windows.Forms.Label lblVice;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.Button btnNulo;
        private System.Windows.Forms.Label lblPresidente;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtChapa;
        public System.Windows.Forms.TextBox txtViceP;
        public System.Windows.Forms.TextBox txtPresidente;
        private System.Windows.Forms.Label lblESC;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnC5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}