namespace GestorDeTareasWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkPrioridadAlta = new System.Windows.Forms.CheckBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblContadorTareas = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(334, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(499, 83);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(96, 83);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tareas";
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.Location = new System.Drawing.Point(96, 287);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(325, 95);
            this.lstTareas.TabIndex = 7;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(12, 114);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir tarea";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(12, 155);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(75, 23);
            this.btnCompletar.TabIndex = 9;
            this.btnCompletar.Text = "Marcar como completada";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 199);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkPrioridadAlta
            // 
            this.chkPrioridadAlta.AutoSize = true;
            this.chkPrioridadAlta.Location = new System.Drawing.Point(494, 311);
            this.chkPrioridadAlta.Name = "chkPrioridadAlta";
            this.chkPrioridadAlta.Size = new System.Drawing.Size(87, 17);
            this.chkPrioridadAlta.TabIndex = 11;
            this.chkPrioridadAlta.Text = "Prioridad alta";
            this.chkPrioridadAlta.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Trabajo",
            "Personal",
            "Estudios"});
            this.cmbCategoria.Location = new System.Drawing.Point(645, 307);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 12;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblContadorTareas
            // 
            this.lblContadorTareas.AutoSize = true;
            this.lblContadorTareas.Location = new System.Drawing.Point(547, 180);
            this.lblContadorTareas.Name = "lblContadorTareas";
            this.lblContadorTareas.Size = new System.Drawing.Size(90, 13);
            this.lblContadorTareas.TabIndex = 13;
            this.lblContadorTareas.Text = "Total de tareas: 0";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(661, 175);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiarCampos.TabIndex = 14;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblContadorTareas);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.chkPrioridadAlta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkPrioridadAlta;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblContadorTareas;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}

