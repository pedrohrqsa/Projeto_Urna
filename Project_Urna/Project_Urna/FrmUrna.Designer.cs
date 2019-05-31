namespace Project_Urna
{
    partial class FrmUrna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrna));
            this.lblEleitor = new System.Windows.Forms.Label();
            this.btnVota = new System.Windows.Forms.Button();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEleitor
            // 
            resources.ApplyResources(this.lblEleitor, "lblEleitor");
            this.lblEleitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEleitor.Name = "lblEleitor";
            // 
            // btnVota
            // 
            resources.ApplyResources(this.btnVota, "btnVota");
            this.btnVota.ForeColor = System.Drawing.Color.Black;
            this.btnVota.Name = "btnVota";
            this.btnVota.UseVisualStyleBackColor = true;
            this.btnVota.Click += new System.EventHandler(this.btnVota_Click);
            // 
            // txtRM
            // 
            resources.ApplyResources(this.txtRM, "txtRM");
            this.txtRM.Name = "txtRM";
            this.txtRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRM_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Name = "lblSenha";
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmUrna
            // 
            this.AcceptButton = this.btnVota;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.btnVota);
            this.Controls.Add(this.lblEleitor);
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEleitor;
        private System.Windows.Forms.Button btnVota;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

