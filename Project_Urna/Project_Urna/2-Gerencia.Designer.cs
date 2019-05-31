namespace Project_Urna
{
    partial class FrmGerencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerencia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarChapa = new System.Windows.Forms.Button();
            this.btnCadastrarMesario = new System.Windows.Forms.Button();
            this.lblCchapa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCadastrarChapa);
            this.groupBox1.Controls.Add(this.btnCadastrarMesario);
            this.groupBox1.Controls.Add(this.lblCchapa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 235);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro:";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarAluno.Location = new System.Drawing.Point(224, 113);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(110, 35);
            this.btnCadastrarAluno.TabIndex = 6;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadastrar  Aluno:";
            // 
            // btnCadastrarChapa
            // 
            this.btnCadastrarChapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarChapa.Location = new System.Drawing.Point(224, 182);
            this.btnCadastrarChapa.Name = "btnCadastrarChapa";
            this.btnCadastrarChapa.Size = new System.Drawing.Size(110, 35);
            this.btnCadastrarChapa.TabIndex = 1;
            this.btnCadastrarChapa.Text = "Cadastrar";
            this.btnCadastrarChapa.UseVisualStyleBackColor = true;
            this.btnCadastrarChapa.Click += new System.EventHandler(this.btnCadastroChapa_Click);
            // 
            // btnCadastrarMesario
            // 
            this.btnCadastrarMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarMesario.Location = new System.Drawing.Point(224, 39);
            this.btnCadastrarMesario.Name = "btnCadastrarMesario";
            this.btnCadastrarMesario.Size = new System.Drawing.Size(110, 35);
            this.btnCadastrarMesario.TabIndex = 2;
            this.btnCadastrarMesario.Text = "Cadastrar";
            this.btnCadastrarMesario.UseVisualStyleBackColor = true;
            this.btnCadastrarMesario.Click += new System.EventHandler(this.btnCadastroMesario_Click);
            // 
            // lblCchapa
            // 
            this.lblCchapa.AutoSize = true;
            this.lblCchapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCchapa.Location = new System.Drawing.Point(78, 191);
            this.lblCchapa.Name = "lblCchapa";
            this.lblCchapa.Size = new System.Drawing.Size(129, 16);
            this.lblCchapa.TabIndex = 4;
            this.lblCchapa.Text = "Cadastrar Chapa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar  Mesário:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(301, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 36);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnListar.Location = new System.Drawing.Point(12, 241);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(383, 50);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar, Editar e Excluir Mesario, Aluno e Chapa.";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "Informações de contato e opiniões sobre o Projeto.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 442);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCchapa;
        private System.Windows.Forms.Button btnCadastrarMesario;
        private System.Windows.Forms.Button btnCadastrarChapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}