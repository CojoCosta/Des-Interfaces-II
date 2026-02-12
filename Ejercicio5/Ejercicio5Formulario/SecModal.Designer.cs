namespace Ejercicio5Formulario2
{
    partial class Form2
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
            this.vtNombre = new Ejercicio5.ValidateTextBox();
            this.vtEdad = new Ejercicio5.ValidateTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAficiones = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SexoMujer = new System.Windows.Forms.RadioButton();
            this.SexoHombre = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SexoOpuestoMujer = new System.Windows.Forms.RadioButton();
            this.SexoOpuestoHombre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFotos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vtNombre
            // 
            this.vtNombre.Location = new System.Drawing.Point(114, 25);
            this.vtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vtNombre.Multilinea = false;
            this.vtNombre.Name = "vtNombre";
            this.vtNombre.Size = new System.Drawing.Size(233, 46);
            this.vtNombre.TabIndex = 0;
            this.vtNombre.Texto = "";
            this.vtNombre.Tipo = Ejercicio5.eTipo.Textual;
            // 
            // vtEdad
            // 
            this.vtEdad.Location = new System.Drawing.Point(114, 81);
            this.vtEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vtEdad.Multilinea = false;
            this.vtEdad.Name = "vtEdad";
            this.vtEdad.Size = new System.Drawing.Size(233, 46);
            this.vtEdad.TabIndex = 1;
            this.vtEdad.Texto = "";
            this.vtEdad.Tipo = Ejercicio5.eTipo.Numerico;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // cbAficiones
            // 
            this.cbAficiones.FormattingEnabled = true;
            this.cbAficiones.Location = new System.Drawing.Point(114, 152);
            this.cbAficiones.Name = "cbAficiones";
            this.cbAficiones.Size = new System.Drawing.Size(233, 28);
            this.cbAficiones.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SexoMujer);
            this.groupBox1.Controls.Add(this.SexoHombre);
            this.groupBox1.Location = new System.Drawing.Point(114, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // SexoMujer
            // 
            this.SexoMujer.AutoSize = true;
            this.SexoMujer.Location = new System.Drawing.Point(119, 25);
            this.SexoMujer.Name = "SexoMujer";
            this.SexoMujer.Size = new System.Drawing.Size(73, 24);
            this.SexoMujer.TabIndex = 9;
            this.SexoMujer.TabStop = true;
            this.SexoMujer.Text = "Mujer";
            this.SexoMujer.UseVisualStyleBackColor = true;
            // 
            // SexoHombre
            // 
            this.SexoHombre.AutoSize = true;
            this.SexoHombre.Location = new System.Drawing.Point(6, 25);
            this.SexoHombre.Name = "SexoHombre";
            this.SexoHombre.Size = new System.Drawing.Size(91, 24);
            this.SexoHombre.TabIndex = 8;
            this.SexoHombre.TabStop = true;
            this.SexoHombre.Text = "Hombre";
            this.SexoHombre.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SexoOpuestoMujer);
            this.groupBox2.Controls.Add(this.SexoOpuestoHombre);
            this.groupBox2.Location = new System.Drawing.Point(114, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo Opuesto";
            // 
            // SexoOpuestoMujer
            // 
            this.SexoOpuestoMujer.AutoSize = true;
            this.SexoOpuestoMujer.Location = new System.Drawing.Point(119, 25);
            this.SexoOpuestoMujer.Name = "SexoOpuestoMujer";
            this.SexoOpuestoMujer.Size = new System.Drawing.Size(73, 24);
            this.SexoOpuestoMujer.TabIndex = 11;
            this.SexoOpuestoMujer.TabStop = true;
            this.SexoOpuestoMujer.Text = "Mujer";
            this.SexoOpuestoMujer.UseVisualStyleBackColor = true;
            // 
            // SexoOpuestoHombre
            // 
            this.SexoOpuestoHombre.AutoSize = true;
            this.SexoOpuestoHombre.Location = new System.Drawing.Point(6, 25);
            this.SexoOpuestoHombre.Name = "SexoOpuestoHombre";
            this.SexoOpuestoHombre.Size = new System.Drawing.Size(91, 24);
            this.SexoOpuestoHombre.TabIndex = 10;
            this.SexoOpuestoHombre.TabStop = true;
            this.SexoOpuestoHombre.Text = "Hombre";
            this.SexoOpuestoHombre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aficion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seleccionar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFotos
            // 
            this.txtFotos.Location = new System.Drawing.Point(114, 373);
            this.txtFotos.Name = "txtFotos";
            this.txtFotos.Size = new System.Drawing.Size(233, 26);
            this.txtFotos.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(114, 445);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 35);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(233, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 546);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtFotos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbAficiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vtEdad);
            this.Controls.Add(this.vtNombre);
            this.Name = "Form2";
            this.Text = "Introduccion de datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Ejercicio5.ValidateTextBox vtNombre;
        public Ejercicio5.ValidateTextBox vtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbAficiones;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton SexoHombre;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton SexoOpuestoMujer;
        public System.Windows.Forms.RadioButton SexoOpuestoHombre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtFotos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.RadioButton SexoMujer;
    }
}

