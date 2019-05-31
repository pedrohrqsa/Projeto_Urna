namespace Project_Urna
{
    partial class FrmApuracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApuracao));
            this.txtChapa1 = new System.Windows.Forms.TextBox();
            this.lblVDCC = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtVotosNulos = new System.Windows.Forms.TextBox();
            this.lblnomechapa1 = new System.Windows.Forms.Label();
            this.txtNomeChapa1 = new System.Windows.Forms.TextBox();
            this.lblChapa1 = new System.Windows.Forms.Label();
            this.gbChapa1 = new System.Windows.Forms.GroupBox();
            this.gbChapa2 = new System.Windows.Forms.GroupBox();
            this.txtChapa2 = new System.Windows.Forms.TextBox();
            this.txtNomeChapa2 = new System.Windows.Forms.TextBox();
            this.lblChapa2 = new System.Windows.Forms.Label();
            this.lblnomechapa2 = new System.Windows.Forms.Label();
            this.gbChapa3 = new System.Windows.Forms.GroupBox();
            this.txtChapa3 = new System.Windows.Forms.TextBox();
            this.txtNomeChapa3 = new System.Windows.Forms.TextBox();
            this.lblnomechapa3 = new System.Windows.Forms.Label();
            this.lblChapa3 = new System.Windows.Forms.Label();
            this.gbChapa4 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChapa4 = new System.Windows.Forms.TextBox();
            this.txtNomeChapa4 = new System.Windows.Forms.TextBox();
            this.lblChapa4 = new System.Windows.Forms.Label();
            this.lblnome4 = new System.Windows.Forms.Label();
            this.gbChapa5 = new System.Windows.Forms.GroupBox();
            this.txtChapa5 = new System.Windows.Forms.TextBox();
            this.txtNomeChapa5 = new System.Windows.Forms.TextBox();
            this.lblChapa5 = new System.Windows.Forms.Label();
            this.lblnome5 = new System.Windows.Forms.Label();
            this.gbNVotosNulos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSvoto = new System.Windows.Forms.TextBox();
            this.gbChapa1.SuspendLayout();
            this.gbChapa2.SuspendLayout();
            this.gbChapa3.SuspendLayout();
            this.gbChapa4.SuspendLayout();
            this.gbChapa5.SuspendLayout();
            this.gbNVotosNulos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChapa1
            // 
            this.txtChapa1.Enabled = false;
            this.txtChapa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapa1.Location = new System.Drawing.Point(151, 30);
            this.txtChapa1.MaxLength = 6;
            this.txtChapa1.Multiline = true;
            this.txtChapa1.Name = "txtChapa1";
            this.txtChapa1.Size = new System.Drawing.Size(80, 38);
            this.txtChapa1.TabIndex = 5;
            // 
            // lblVDCC
            // 
            this.lblVDCC.AutoSize = true;
            this.lblVDCC.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVDCC.ForeColor = System.Drawing.Color.Yellow;
            this.lblVDCC.Location = new System.Drawing.Point(331, 0);
            this.lblVDCC.Name = "lblVDCC";
            this.lblVDCC.Size = new System.Drawing.Size(434, 43);
            this.lblVDCC.TabIndex = 10;
            this.lblVDCC.Text = "Número de Votos de Cada Chapa:";
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnResultado.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 19F, System.Drawing.FontStyle.Bold);
            this.btnResultado.ForeColor = System.Drawing.Color.Lime;
            this.btnResultado.Location = new System.Drawing.Point(413, 457);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(295, 75);
            this.btnResultado.TabIndex = 1;
            this.btnResultado.Text = "Visualizar Resultados";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 13F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(989, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 42);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtVotosNulos
            // 
            this.txtVotosNulos.Enabled = false;
            this.txtVotosNulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtVotosNulos.Location = new System.Drawing.Point(75, 39);
            this.txtVotosNulos.MaxLength = 6;
            this.txtVotosNulos.Multiline = true;
            this.txtVotosNulos.Name = "txtVotosNulos";
            this.txtVotosNulos.Size = new System.Drawing.Size(94, 46);
            this.txtVotosNulos.TabIndex = 14;
            this.txtVotosNulos.TabStop = false;
            // 
            // lblnomechapa1
            // 
            this.lblnomechapa1.AutoSize = true;
            this.lblnomechapa1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblnomechapa1.Location = new System.Drawing.Point(6, 83);
            this.lblnomechapa1.Name = "lblnomechapa1";
            this.lblnomechapa1.Size = new System.Drawing.Size(78, 33);
            this.lblnomechapa1.TabIndex = 15;
            this.lblnomechapa1.Text = "Nome:";
            // 
            // txtNomeChapa1
            // 
            this.txtNomeChapa1.Enabled = false;
            this.txtNomeChapa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNomeChapa1.Location = new System.Drawing.Point(90, 83);
            this.txtNomeChapa1.MaxLength = 50;
            this.txtNomeChapa1.Name = "txtNomeChapa1";
            this.txtNomeChapa1.Size = new System.Drawing.Size(252, 35);
            this.txtNomeChapa1.TabIndex = 20;
            // 
            // lblChapa1
            // 
            this.lblChapa1.AutoSize = true;
            this.lblChapa1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapa1.Location = new System.Drawing.Point(6, 40);
            this.lblChapa1.Name = "lblChapa1";
            this.lblChapa1.Size = new System.Drawing.Size(142, 32);
            this.lblChapa1.TabIndex = 0;
            this.lblChapa1.Text = "Número de Votos:";
            // 
            // gbChapa1
            // 
            this.gbChapa1.Controls.Add(this.txtChapa1);
            this.gbChapa1.Controls.Add(this.lblChapa1);
            this.gbChapa1.Controls.Add(this.lblnomechapa1);
            this.gbChapa1.Controls.Add(this.txtNomeChapa1);
            this.gbChapa1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChapa1.Location = new System.Drawing.Point(0, 55);
            this.gbChapa1.Name = "gbChapa1";
            this.gbChapa1.Size = new System.Drawing.Size(348, 128);
            this.gbChapa1.TabIndex = 25;
            this.gbChapa1.TabStop = false;
            this.gbChapa1.Text = "Chapa 1";
            // 
            // gbChapa2
            // 
            this.gbChapa2.Controls.Add(this.txtChapa2);
            this.gbChapa2.Controls.Add(this.txtNomeChapa2);
            this.gbChapa2.Controls.Add(this.lblChapa2);
            this.gbChapa2.Controls.Add(this.lblnomechapa2);
            this.gbChapa2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.gbChapa2.Location = new System.Drawing.Point(360, 55);
            this.gbChapa2.Name = "gbChapa2";
            this.gbChapa2.Size = new System.Drawing.Size(348, 131);
            this.gbChapa2.TabIndex = 26;
            this.gbChapa2.TabStop = false;
            this.gbChapa2.Text = "Chapa 2";
            // 
            // txtChapa2
            // 
            this.txtChapa2.Enabled = false;
            this.txtChapa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapa2.Location = new System.Drawing.Point(151, 30);
            this.txtChapa2.MaxLength = 6;
            this.txtChapa2.Multiline = true;
            this.txtChapa2.Name = "txtChapa2";
            this.txtChapa2.Size = new System.Drawing.Size(80, 38);
            this.txtChapa2.TabIndex = 22;
            // 
            // txtNomeChapa2
            // 
            this.txtNomeChapa2.Enabled = false;
            this.txtNomeChapa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNomeChapa2.Location = new System.Drawing.Point(90, 83);
            this.txtNomeChapa2.MaxLength = 50;
            this.txtNomeChapa2.Name = "txtNomeChapa2";
            this.txtNomeChapa2.Size = new System.Drawing.Size(252, 35);
            this.txtNomeChapa2.TabIndex = 24;
            // 
            // lblChapa2
            // 
            this.lblChapa2.AutoSize = true;
            this.lblChapa2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapa2.Location = new System.Drawing.Point(6, 40);
            this.lblChapa2.Name = "lblChapa2";
            this.lblChapa2.Size = new System.Drawing.Size(142, 32);
            this.lblChapa2.TabIndex = 21;
            this.lblChapa2.Text = "Número de Votos:";
            // 
            // lblnomechapa2
            // 
            this.lblnomechapa2.AutoSize = true;
            this.lblnomechapa2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblnomechapa2.Location = new System.Drawing.Point(6, 83);
            this.lblnomechapa2.Name = "lblnomechapa2";
            this.lblnomechapa2.Size = new System.Drawing.Size(78, 33);
            this.lblnomechapa2.TabIndex = 23;
            this.lblnomechapa2.Text = "Nome:";
            // 
            // gbChapa3
            // 
            this.gbChapa3.Controls.Add(this.txtChapa3);
            this.gbChapa3.Controls.Add(this.txtNomeChapa3);
            this.gbChapa3.Controls.Add(this.lblnomechapa3);
            this.gbChapa3.Controls.Add(this.lblChapa3);
            this.gbChapa3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.gbChapa3.Location = new System.Drawing.Point(719, 55);
            this.gbChapa3.Name = "gbChapa3";
            this.gbChapa3.Size = new System.Drawing.Size(348, 131);
            this.gbChapa3.TabIndex = 27;
            this.gbChapa3.TabStop = false;
            this.gbChapa3.Text = "Chapa 3";
            // 
            // txtChapa3
            // 
            this.txtChapa3.Enabled = false;
            this.txtChapa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapa3.Location = new System.Drawing.Point(152, 30);
            this.txtChapa3.MaxLength = 6;
            this.txtChapa3.Multiline = true;
            this.txtChapa3.Name = "txtChapa3";
            this.txtChapa3.Size = new System.Drawing.Size(80, 38);
            this.txtChapa3.TabIndex = 26;
            // 
            // txtNomeChapa3
            // 
            this.txtNomeChapa3.Enabled = false;
            this.txtNomeChapa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNomeChapa3.Location = new System.Drawing.Point(91, 83);
            this.txtNomeChapa3.MaxLength = 50;
            this.txtNomeChapa3.Name = "txtNomeChapa3";
            this.txtNomeChapa3.Size = new System.Drawing.Size(252, 35);
            this.txtNomeChapa3.TabIndex = 28;
            // 
            // lblnomechapa3
            // 
            this.lblnomechapa3.AutoSize = true;
            this.lblnomechapa3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblnomechapa3.Location = new System.Drawing.Point(7, 83);
            this.lblnomechapa3.Name = "lblnomechapa3";
            this.lblnomechapa3.Size = new System.Drawing.Size(78, 33);
            this.lblnomechapa3.TabIndex = 27;
            this.lblnomechapa3.Text = "Nome:";
            // 
            // lblChapa3
            // 
            this.lblChapa3.AutoSize = true;
            this.lblChapa3.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapa3.Location = new System.Drawing.Point(7, 40);
            this.lblChapa3.Name = "lblChapa3";
            this.lblChapa3.Size = new System.Drawing.Size(142, 32);
            this.lblChapa3.TabIndex = 25;
            this.lblChapa3.Text = "Número de Votos:";
            // 
            // gbChapa4
            // 
            this.gbChapa4.Controls.Add(this.groupBox4);
            this.gbChapa4.Controls.Add(this.txtChapa4);
            this.gbChapa4.Controls.Add(this.txtNomeChapa4);
            this.gbChapa4.Controls.Add(this.lblChapa4);
            this.gbChapa4.Controls.Add(this.lblnome4);
            this.gbChapa4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.gbChapa4.Location = new System.Drawing.Point(0, 239);
            this.gbChapa4.Name = "gbChapa4";
            this.gbChapa4.Size = new System.Drawing.Size(348, 126);
            this.gbChapa4.TabIndex = 28;
            this.gbChapa4.TabStop = false;
            this.gbChapa4.Text = "Chapa 4";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(360, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 100);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // txtChapa4
            // 
            this.txtChapa4.Enabled = false;
            this.txtChapa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapa4.Location = new System.Drawing.Point(151, 29);
            this.txtChapa4.MaxLength = 6;
            this.txtChapa4.Multiline = true;
            this.txtChapa4.Name = "txtChapa4";
            this.txtChapa4.Size = new System.Drawing.Size(80, 38);
            this.txtChapa4.TabIndex = 22;
            // 
            // txtNomeChapa4
            // 
            this.txtNomeChapa4.Enabled = false;
            this.txtNomeChapa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNomeChapa4.Location = new System.Drawing.Point(90, 82);
            this.txtNomeChapa4.MaxLength = 50;
            this.txtNomeChapa4.Name = "txtNomeChapa4";
            this.txtNomeChapa4.Size = new System.Drawing.Size(252, 35);
            this.txtNomeChapa4.TabIndex = 24;
            // 
            // lblChapa4
            // 
            this.lblChapa4.AutoSize = true;
            this.lblChapa4.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapa4.Location = new System.Drawing.Point(6, 39);
            this.lblChapa4.Name = "lblChapa4";
            this.lblChapa4.Size = new System.Drawing.Size(142, 32);
            this.lblChapa4.TabIndex = 21;
            this.lblChapa4.Text = "Número de Votos:";
            // 
            // lblnome4
            // 
            this.lblnome4.AutoSize = true;
            this.lblnome4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblnome4.Location = new System.Drawing.Point(6, 82);
            this.lblnome4.Name = "lblnome4";
            this.lblnome4.Size = new System.Drawing.Size(78, 33);
            this.lblnome4.TabIndex = 23;
            this.lblnome4.Text = "Nome:";
            // 
            // gbChapa5
            // 
            this.gbChapa5.Controls.Add(this.txtChapa5);
            this.gbChapa5.Controls.Add(this.txtNomeChapa5);
            this.gbChapa5.Controls.Add(this.lblChapa5);
            this.gbChapa5.Controls.Add(this.lblnome5);
            this.gbChapa5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.gbChapa5.Location = new System.Drawing.Point(360, 239);
            this.gbChapa5.Name = "gbChapa5";
            this.gbChapa5.Size = new System.Drawing.Size(348, 126);
            this.gbChapa5.TabIndex = 29;
            this.gbChapa5.TabStop = false;
            this.gbChapa5.Text = "Chapa 5";
            // 
            // txtChapa5
            // 
            this.txtChapa5.Enabled = false;
            this.txtChapa5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChapa5.Location = new System.Drawing.Point(151, 19);
            this.txtChapa5.MaxLength = 6;
            this.txtChapa5.Multiline = true;
            this.txtChapa5.Name = "txtChapa5";
            this.txtChapa5.Size = new System.Drawing.Size(80, 38);
            this.txtChapa5.TabIndex = 26;
            // 
            // txtNomeChapa5
            // 
            this.txtNomeChapa5.Enabled = false;
            this.txtNomeChapa5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNomeChapa5.Location = new System.Drawing.Point(90, 72);
            this.txtNomeChapa5.MaxLength = 50;
            this.txtNomeChapa5.Name = "txtNomeChapa5";
            this.txtNomeChapa5.Size = new System.Drawing.Size(252, 35);
            this.txtNomeChapa5.TabIndex = 28;
            // 
            // lblChapa5
            // 
            this.lblChapa5.AutoSize = true;
            this.lblChapa5.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapa5.Location = new System.Drawing.Point(6, 29);
            this.lblChapa5.Name = "lblChapa5";
            this.lblChapa5.Size = new System.Drawing.Size(142, 32);
            this.lblChapa5.TabIndex = 25;
            this.lblChapa5.Text = "Número de Votos:";
            // 
            // lblnome5
            // 
            this.lblnome5.AutoSize = true;
            this.lblnome5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblnome5.Location = new System.Drawing.Point(6, 72);
            this.lblnome5.Name = "lblnome5";
            this.lblnome5.Size = new System.Drawing.Size(78, 33);
            this.lblnome5.TabIndex = 27;
            this.lblnome5.Text = "Nome:";
            // 
            // gbNVotosNulos
            // 
            this.gbNVotosNulos.Controls.Add(this.txtVotosNulos);
            this.gbNVotosNulos.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNVotosNulos.Location = new System.Drawing.Point(808, 204);
            this.gbNVotosNulos.Name = "gbNVotosNulos";
            this.gbNVotosNulos.Size = new System.Drawing.Size(254, 103);
            this.gbNVotosNulos.TabIndex = 30;
            this.gbNVotosNulos.TabStop = false;
            this.gbNVotosNulos.Text = "Número de votos Nulos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSvoto);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(808, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 97);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoas que não votaram:";
            // 
            // txtSvoto
            // 
            this.txtSvoto.Enabled = false;
            this.txtSvoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtSvoto.Location = new System.Drawing.Point(85, 45);
            this.txtSvoto.MaxLength = 6;
            this.txtSvoto.Multiline = true;
            this.txtSvoto.Name = "txtSvoto";
            this.txtSvoto.Size = new System.Drawing.Size(94, 46);
            this.txtSvoto.TabIndex = 15;
            this.txtSvoto.TabStop = false;
            // 
            // FrmApuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 535);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNVotosNulos);
            this.Controls.Add(this.gbChapa5);
            this.Controls.Add(this.gbChapa4);
            this.Controls.Add(this.gbChapa3);
            this.Controls.Add(this.gbChapa2);
            this.Controls.Add(this.gbChapa1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblVDCC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApuracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado da Eleição - Urna Eletrônica - Grêmio Estudantil";
            this.gbChapa1.ResumeLayout(false);
            this.gbChapa1.PerformLayout();
            this.gbChapa2.ResumeLayout(false);
            this.gbChapa2.PerformLayout();
            this.gbChapa3.ResumeLayout(false);
            this.gbChapa3.PerformLayout();
            this.gbChapa4.ResumeLayout(false);
            this.gbChapa4.PerformLayout();
            this.gbChapa5.ResumeLayout(false);
            this.gbChapa5.PerformLayout();
            this.gbNVotosNulos.ResumeLayout(false);
            this.gbNVotosNulos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChapa1;
        private System.Windows.Forms.Label lblVDCC;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtVotosNulos;
        private System.Windows.Forms.Label lblnomechapa1;
        private System.Windows.Forms.TextBox txtNomeChapa1;
        private System.Windows.Forms.Label lblChapa1;
        private System.Windows.Forms.GroupBox gbChapa1;
        private System.Windows.Forms.GroupBox gbChapa2;
        private System.Windows.Forms.TextBox txtChapa2;
        private System.Windows.Forms.TextBox txtNomeChapa2;
        private System.Windows.Forms.Label lblChapa2;
        private System.Windows.Forms.Label lblnomechapa2;
        private System.Windows.Forms.GroupBox gbChapa3;
        private System.Windows.Forms.TextBox txtChapa3;
        private System.Windows.Forms.TextBox txtNomeChapa3;
        private System.Windows.Forms.Label lblnomechapa3;
        private System.Windows.Forms.Label lblChapa3;
        private System.Windows.Forms.GroupBox gbChapa4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtChapa4;
        private System.Windows.Forms.TextBox txtNomeChapa4;
        private System.Windows.Forms.Label lblChapa4;
        private System.Windows.Forms.Label lblnome4;
        private System.Windows.Forms.GroupBox gbChapa5;
        private System.Windows.Forms.TextBox txtChapa5;
        private System.Windows.Forms.TextBox txtNomeChapa5;
        private System.Windows.Forms.Label lblChapa5;
        private System.Windows.Forms.Label lblnome5;
        private System.Windows.Forms.GroupBox gbNVotosNulos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSvoto;
    }
}