namespace Ejercicio3
{
    partial class Reproductor
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(31, 20);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "Play";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(53, 46);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(34, 13);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "00:00";
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnPlayPause);
            this.Name = "Reproductor";
            this.Size = new System.Drawing.Size(137, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPlayPause;
        public System.Windows.Forms.Label lblTiempo;
    }
}
