namespace TestWF
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblManejador = new System.Windows.Forms.Label();
            this.cboManejador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(143, 34);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(125, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(274, 34);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(125, 20);
            this.txtSueldo.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(143, 243);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(125, 23);
            this.btnEmpleado.TabIndex = 3;
            this.btnEmpleado.Text = "Crear empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(140, 18);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 5;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(271, 18);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 6;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblManejador
            // 
            this.lblManejador.AutoSize = true;
            this.lblManejador.Location = new System.Drawing.Point(140, 76);
            this.lblManejador.Name = "lblManejador";
            this.lblManejador.Size = new System.Drawing.Size(57, 13);
            this.lblManejador.TabIndex = 7;
            this.lblManejador.Text = "Manejador";
            // 
            // cboManejador
            // 
            this.cboManejador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManejador.FormattingEnabled = true;
            this.cboManejador.Location = new System.Drawing.Point(143, 92);
            this.cboManejador.Name = "cboManejador";
            this.cboManejador.Size = new System.Drawing.Size(125, 21);
            this.cboManejador.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.Controls.Add(this.cboManejador);
            this.Controls.Add(this.lblManejador);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblManejador;
        private System.Windows.Forms.ComboBox cboManejador;
    }
}

