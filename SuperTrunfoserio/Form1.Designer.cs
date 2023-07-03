namespace SuperTrunfoserio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Atributo1 = new RadioButton();
            Atributo2 = new RadioButton();
            Atributo3 = new RadioButton();
            Atributo4 = new RadioButton();
            btnComparar = new Button();
            Sortearcartas = new Button();
            Prxrodada = new Button();
            qtdjogador = new Label();
            qtdmaquina = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Image = Properties.Resources.CARTA_VAZIA;
            pictureBox1.Location = new Point(73, 50);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 438);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.AppWorkspace;
            pictureBox2.Image = Properties.Resources.CARTA_VAZIA;
            pictureBox2.Location = new Point(833, 50);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(332, 438);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Atributo1
            // 
            Atributo1.AutoSize = true;
            Atributo1.Font = new Font("MV Boli", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point);
            Atributo1.Location = new Point(73, 531);
            Atributo1.Margin = new Padding(4);
            Atributo1.Name = "Atributo1";
            Atributo1.Size = new Size(108, 30);
            Atributo1.TabIndex = 2;
            Atributo1.TabStop = true;
            Atributo1.Text = "Torcida";
            Atributo1.UseVisualStyleBackColor = true;
            // 
            // Atributo2
            // 
            Atributo2.AutoSize = true;
            Atributo2.Font = new Font("MV Boli", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point);
            Atributo2.Location = new Point(269, 531);
            Atributo2.Margin = new Padding(4);
            Atributo2.Name = "Atributo2";
            Atributo2.Size = new Size(178, 30);
            Atributo2.TabIndex = 3;
            Atributo2.TabStop = true;
            Atributo2.Text = "QualidadeTime";
            Atributo2.UseVisualStyleBackColor = true;
            // 
            // Atributo3
            // 
            Atributo3.AutoSize = true;
            Atributo3.Font = new Font("MV Boli", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point);
            Atributo3.Location = new Point(73, 588);
            Atributo3.Margin = new Padding(4);
            Atributo3.Name = "Atributo3";
            Atributo3.Size = new Size(104, 30);
            Atributo3.TabIndex = 4;
            Atributo3.TabStop = true;
            Atributo3.Text = "Titulos";
            Atributo3.UseVisualStyleBackColor = true;
            // 
            // Atributo4
            // 
            Atributo4.AutoSize = true;
            Atributo4.Font = new Font("MV Boli", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point);
            Atributo4.Location = new Point(269, 588);
            Atributo4.Margin = new Padding(4);
            Atributo4.Name = "Atributo4";
            Atributo4.Size = new Size(108, 30);
            Atributo4.TabIndex = 5;
            Atributo4.TabStop = true;
            Atributo4.Text = "Estadio";
            Atributo4.UseVisualStyleBackColor = true;
            // 
            // btnComparar
            // 
            btnComparar.BackColor = Color.PapayaWhip;
            btnComparar.Font = new Font("Segoe Print", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point);
            btnComparar.Location = new Point(478, 546);
            btnComparar.Margin = new Padding(4);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(148, 55);
            btnComparar.TabIndex = 6;
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = false;
            btnComparar.Click += BtnComparar;
            // 
            // Sortearcartas
            // 
            Sortearcartas.BackColor = Color.RosyBrown;
            Sortearcartas.Font = new Font("Segoe Print", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point);
            Sortearcartas.Location = new Point(524, 328);
            Sortearcartas.Name = "Sortearcartas";
            Sortearcartas.Size = new Size(177, 54);
            Sortearcartas.TabIndex = 7;
            Sortearcartas.Text = "Sortear Cartas";
            Sortearcartas.UseVisualStyleBackColor = false;
            Sortearcartas.Click += BtnSortearcartas;
            // 
            // Prxrodada
            // 
            Prxrodada.BackColor = Color.LightGreen;
            Prxrodada.Font = new Font("Segoe Print", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point);
            Prxrodada.Location = new Point(680, 547);
            Prxrodada.Name = "Prxrodada";
            Prxrodada.Size = new Size(194, 54);
            Prxrodada.TabIndex = 8;
            Prxrodada.Text = "Proxima Rodada";
            Prxrodada.UseVisualStyleBackColor = false;
            Prxrodada.Click += ProximaRodada;
            // 
            // qtdjogador
            // 
            qtdjogador.Font = new Font("MV Boli", 8.861538F, FontStyle.Regular, GraphicsUnit.Point);
            qtdjogador.Location = new Point(454, 99);
            qtdjogador.Name = "qtdjogador";
            qtdjogador.Size = new Size(108, 68);
            qtdjogador.TabIndex = 9;
            qtdjogador.Text = "O JOGADOR POSSUI 4 CARTAS";
            // 
            // qtdmaquina
            // 
            qtdmaquina.Font = new Font("MV Boli", 8.861538F, FontStyle.Regular, GraphicsUnit.Point);
            qtdmaquina.Location = new Point(655, 99);
            qtdmaquina.Name = "qtdmaquina";
            qtdmaquina.Size = new Size(116, 68);
            qtdmaquina.TabIndex = 10;
            qtdmaquina.Text = "A MAQUINA POSSUI 4 CARTAS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(441, 203);
            label1.Name = "label1";
            label1.Size = new Size(340, 73);
            label1.TabIndex = 11;
            label1.Text = "Para Começar o Jogo clique em Sortear Cartas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 671);
            Controls.Add(label1);
            Controls.Add(qtdmaquina);
            Controls.Add(qtdjogador);
            Controls.Add(Prxrodada);
            Controls.Add(Sortearcartas);
            Controls.Add(btnComparar);
            Controls.Add(Atributo4);
            Controls.Add(Atributo3);
            Controls.Add(Atributo2);
            Controls.Add(Atributo1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RadioButton Atributo1;
        private RadioButton Atributo2;
        private RadioButton Atributo3;
        private RadioButton Atributo4;
        private Button btnComparar;
        private Button Sortearcartas;
        private Button Prxrodada;
        private Label qtdjogador;
        private Label qtdmaquina;
        private Label label1;
    }
}