namespace ProyectoFinalC_
{
    partial class FormListas
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
            listBoxTareas = new ListBox();
            txtNuevaTarea = new TextBox();
            btnAgregarTarea = new Button();
            btnEliminarTarea = new Button();
            btnLimpiarLista = new Button();
            SuspendLayout();
            // 
            // listBoxTareas
            // 
            listBoxTareas.FormattingEnabled = true;
            listBoxTareas.ItemHeight = 15;
            listBoxTareas.Location = new Point(187, 199);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(426, 214);
            listBoxTareas.TabIndex = 0;
            // 
            // txtNuevaTarea
            // 
            txtNuevaTarea.Location = new Point(201, 66);
            txtNuevaTarea.Name = "txtNuevaTarea";
            txtNuevaTarea.Size = new Size(100, 23);
            txtNuevaTarea.TabIndex = 1;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(93, 65);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(75, 23);
            btnAgregarTarea.TabIndex = 2;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(353, 66);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(75, 23);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnLimpiarLista
            // 
            btnLimpiarLista.Location = new Point(79, 115);
            btnLimpiarLista.Name = "btnLimpiarLista";
            btnLimpiarLista.Size = new Size(100, 27);
            btnLimpiarLista.TabIndex = 4;
            btnLimpiarLista.Text = "Limpiar lista";
            btnLimpiarLista.UseVisualStyleBackColor = true;
            btnLimpiarLista.Click += btnLimpiarLista_Click;
            // 
            // FormListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiarLista);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtNuevaTarea);
            Controls.Add(listBoxTareas);
            Name = "FormListas";
            Text = "FormListas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTareas;
        private TextBox txtNuevaTarea;
        private Button btnAgregarTarea;
        private Button btnEliminarTarea;
        private Button btnLimpiarLista;
    }
}