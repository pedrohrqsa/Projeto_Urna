namespace Project_Urna
{
    partial class FrmContatoOpinioes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContatoOpinioes));
            this.dgvOP = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisuOp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpaLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOP
            // 
            this.dgvOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOP.Location = new System.Drawing.Point(12, 49);
            this.dgvOP.Name = "dgvOP";
            this.dgvOP.Size = new System.Drawing.Size(961, 354);
            this.dgvOP.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(903, 453);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 29);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnVisuOp
            // 
            this.btnVisuOp.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisuOp.Location = new System.Drawing.Point(410, 427);
            this.btnVisuOp.Name = "btnVisuOp";
            this.btnVisuOp.Size = new System.Drawing.Size(187, 55);
            this.btnVisuOp.TabIndex = 3;
            this.btnVisuOp.Text = "Visualizar ";
            this.btnVisuOp.UseVisualStyleBackColor = true;
            this.btnVisuOp.Click += new System.EventHandler(this.btnVisuOp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visualização de Contato e Opiniões sobre o Projeto.";
            // 
            // btnLimpaLista
            // 
            this.btnLimpaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaLista.ForeColor = System.Drawing.Color.Black;
            this.btnLimpaLista.Location = new System.Drawing.Point(12, 439);
            this.btnLimpaLista.Name = "btnLimpaLista";
            this.btnLimpaLista.Size = new System.Drawing.Size(107, 43);
            this.btnLimpaLista.TabIndex = 5;
            this.btnLimpaLista.Text = "Limpar lista.";
            this.btnLimpaLista.UseVisualStyleBackColor = true;
            this.btnLimpaLista.Click += new System.EventHandler(this.btnLimpaLista_Click);
            // 
            // FrmContatoOpinioes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 491);
            this.Controls.Add(this.btnLimpaLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisuOp);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvOP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmContatoOpinioes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato/Opiniões";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisuOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpaLista;
    }
}