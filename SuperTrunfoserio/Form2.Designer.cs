namespace SuperTrunfoserio
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            Vercartas = new Button();
            SairJogo = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(482, 183);
            button1.Name = "button1";
            button1.Size = new Size(235, 57);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Jogo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += abrirJogo;
            // 
            // Vercartas
            // 
            Vercartas.BackColor = Color.DarkSlateGray;
            Vercartas.Font = new Font("Arial", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point);
            Vercartas.Location = new Point(482, 265);
            Vercartas.Name = "Vercartas";
            Vercartas.Size = new Size(235, 57);
            Vercartas.TabIndex = 1;
            Vercartas.Text = "Ver Cartas";
            Vercartas.UseVisualStyleBackColor = false;
            Vercartas.Click += Vercartas_Click;
            // 
            // SairJogo
            // 
            SairJogo.BackColor = Color.DarkSlateGray;
            SairJogo.Font = new Font("Arial", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point);
            SairJogo.Location = new Point(482, 353);
            SairJogo.Name = "SairJogo";
            SairJogo.Size = new Size(235, 57);
            SairJogo.TabIndex = 2;
            SairJogo.Text = "Sair jogo";
            SairJogo.UseVisualStyleBackColor = false;
            SairJogo.Click += SairJogo_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 671);
            Controls.Add(SairJogo);
            Controls.Add(Vercartas);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Vercartas;
        private Button SairJogo;
    }
}