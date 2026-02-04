namespace formularioEj2
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
            this.etiquetaAviso1 = new Ejercicio2.EtiquetaAviso();
            this.reproductor1 = new Ejercicio3.Reproductor();
            this.btnSelectdirectory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinal = System.Drawing.Color.Yellow;
            this.etiquetaAviso1.ColorInicial = System.Drawing.Color.Cyan;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = false;
            this.etiquetaAviso1.ImagenMarca = global::formularioEj2.Properties.Resources.img101;
            this.etiquetaAviso1.Location = new System.Drawing.Point(-3, -3);
            this.etiquetaAviso1.Marca = Ejercicio2.EtiquetaAviso.EMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(497, 76);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(147, 353);
            this.reproductor1.Minutos = 0;
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Segundos = 0;
            this.reproductor1.Size = new System.Drawing.Size(137, 85);
            this.reproductor1.TabIndex = 1;
            // 
            // btnSelectdirectory
            // 
            this.btnSelectdirectory.Location = new System.Drawing.Point(261, 373);
            this.btnSelectdirectory.Name = "btnSelectdirectory";
            this.btnSelectdirectory.Size = new System.Drawing.Size(128, 23);
            this.btnSelectdirectory.TabIndex = 2;
            this.btnSelectdirectory.Text = "Seleccionar directorio";
            this.btnSelectdirectory.UseVisualStyleBackColor = true;
            this.btnSelectdirectory.Click += new System.EventHandler(this.btnSelectdirectory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(45, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectdirectory);
            this.Controls.Add(this.reproductor1);
            this.Controls.Add(this.etiquetaAviso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio2.EtiquetaAviso etiquetaAviso1;
        private Ejercicio3.Reproductor reproductor1;
        private System.Windows.Forms.Button btnSelectdirectory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

