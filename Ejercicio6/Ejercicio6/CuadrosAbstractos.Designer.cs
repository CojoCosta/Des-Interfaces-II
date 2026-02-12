namespace Ejercicio6
{
    partial class CuadrosAbstractos
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
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAumentoGrosor = new System.Windows.Forms.Button();
            this.btnMenorGrosor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(23, 20);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 0;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(23, 49);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(23, 78);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 2;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(23, 107);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(75, 23);
            this.btnLinea.TabIndex = 3;
            this.btnLinea.Text = "Linea";
            this.btnLinea.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 110);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAumentoGrosor
            // 
            this.btnAumentoGrosor.Location = new System.Drawing.Point(122, 136);
            this.btnAumentoGrosor.Name = "btnAumentoGrosor";
            this.btnAumentoGrosor.Size = new System.Drawing.Size(75, 23);
            this.btnAumentoGrosor.TabIndex = 5;
            this.btnAumentoGrosor.Text = "Grosor +";
            this.btnAumentoGrosor.UseVisualStyleBackColor = true;
            // 
            // btnMenorGrosor
            // 
            this.btnMenorGrosor.Location = new System.Drawing.Point(122, 165);
            this.btnMenorGrosor.Name = "btnMenorGrosor";
            this.btnMenorGrosor.Size = new System.Drawing.Size(75, 23);
            this.btnMenorGrosor.TabIndex = 6;
            this.btnMenorGrosor.Text = "Grosor -";
            this.btnMenorGrosor.UseVisualStyleBackColor = true;
            // 
            // CuadrosAbstractos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMenorGrosor);
            this.Controls.Add(this.btnAumentoGrosor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCirculo);
            this.Name = "CuadrosAbstractos";
            this.Size = new System.Drawing.Size(450, 221);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAumentoGrosor;
        private System.Windows.Forms.Button btnMenorGrosor;
    }
}
