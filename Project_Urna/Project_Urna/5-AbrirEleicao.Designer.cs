namespace Project_Urna
{
    partial class FrmAbrir_Eleicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbrir_Eleicao));
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbrir_Eleicao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbre_Apuracao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(315, 225);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 36);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAbrir_Eleicao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAbre_Apuracao);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(60, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abrir Eleição:";
            // 
            // btnAbrir_Eleicao
            // 
            this.btnAbrir_Eleicao.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAbrir_Eleicao.Location = new System.Drawing.Point(214, 50);
            this.btnAbrir_Eleicao.Name = "btnAbrir_Eleicao";
            this.btnAbrir_Eleicao.Size = new System.Drawing.Size(93, 35);
            this.btnAbrir_Eleicao.TabIndex = 5;
            this.btnAbrir_Eleicao.Text = "&Abrir";
            this.btnAbrir_Eleicao.UseVisualStyleBackColor = true;
            this.btnAbrir_Eleicao.Click += new System.EventHandler(this.btnAbrir_Eleicao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(60, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apuração:";
            // 
            // btnAbre_Apuracao
            // 
            this.btnAbre_Apuracao.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAbre_Apuracao.Location = new System.Drawing.Point(214, 133);
            this.btnAbre_Apuracao.Name = "btnAbre_Apuracao";
            this.btnAbre_Apuracao.Size = new System.Drawing.Size(93, 35);
            this.btnAbre_Apuracao.TabIndex = 1;
            this.btnAbre_Apuracao.Text = "&Exibir";
            this.btnAbre_Apuracao.UseVisualStyleBackColor = true;
            this.btnAbre_Apuracao.Click += new System.EventHandler(this.btnAbre_Apuracao_Click);
            // 
            // FrmAbrir_Eleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(376, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbrir_Eleicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Eleição & Apuração ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbre_Apuracao;
        private System.Windows.Forms.Button btnAbrir_Eleicao;
        private System.Windows.Forms.Label label1;
    }
}