namespace ProyectoFinalC_
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
            button1 = new Button();
            button2 = new Button();
            btnPilas = new Button();
            btnColas = new Button();
            btnADO = new Button();
            btnListas = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(320, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Grafos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(320, 77);
            button2.Name = "button2";
            button2.Size = new Size(71, 42);
            button2.TabIndex = 1;
            button2.Text = "Arbol Binario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPilas
            // 
            btnPilas.Location = new Point(100, 119);
            btnPilas.Name = "btnPilas";
            btnPilas.Size = new Size(75, 23);
            btnPilas.TabIndex = 2;
            btnPilas.Text = "Pilas";
            btnPilas.UseVisualStyleBackColor = true;
            btnPilas.Click += btnPilas_Click;
            // 
            // btnColas
            // 
            btnColas.Location = new Point(100, 167);
            btnColas.Name = "btnColas";
            btnColas.Size = new Size(75, 23);
            btnColas.TabIndex = 3;
            btnColas.Text = "Colas";
            btnColas.UseVisualStyleBackColor = true;
            btnColas.Click += btnColas_Click;
            // 
            // btnADO
            // 
            btnADO.Location = new Point(527, 102);
            btnADO.Name = "btnADO";
            btnADO.Size = new Size(79, 57);
            btnADO.TabIndex = 4;
            btnADO.Text = "Algoritmos de ordenamiento";
            btnADO.UseVisualStyleBackColor = true;
            btnADO.Click += btnADO_Click;
            // 
            // btnListas
            // 
            btnListas.Location = new Point(100, 77);
            btnListas.Name = "btnListas";
            btnListas.Size = new Size(75, 23);
            btnListas.TabIndex = 5;
            btnListas.Text = "Listas";
            btnListas.UseVisualStyleBackColor = true;
            btnListas.Click += btnListas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 6;
            label1.Text = "Estructuras lineales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 36);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 7;
            label2.Text = "Estructuras no lineales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 36);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 8;
            label3.Text = "Algoritmos de ordenamiento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListas);
            Controls.Add(btnADO);
            Controls.Add(btnColas);
            Controls.Add(btnPilas);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnPilas;
        private Button btnColas;
        private Button btnADO;
        private Button btnListas;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}