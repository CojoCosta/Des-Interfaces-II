namespace Ejercicio6Formulario
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
            this.btnMenorGrosor = new System.Windows.Forms.Button();
            this.btnAumentoGrosor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenorGrosor
            // 
            this.btnMenorGrosor.Location = new System.Drawing.Point(269, 248);
            this.btnMenorGrosor.Name = "btnMenorGrosor";
            this.btnMenorGrosor.Size = new System.Drawing.Size(75, 23);
            this.btnMenorGrosor.TabIndex = 13;
            this.btnMenorGrosor.Text = "Grosor -";
            this.btnMenorGrosor.UseVisualStyleBackColor = true;
            // 
            // btnAumentoGrosor
            // 
            this.btnAumentoGrosor.Location = new System.Drawing.Point(152, 248);
            this.btnAumentoGrosor.Name = "btnAumentoGrosor";
            this.btnAumentoGrosor.Size = new System.Drawing.Size(75, 23);
            this.btnAumentoGrosor.TabIndex = 12;
            this.btnAumentoGrosor.Text = "Grosor +";
            this.btnAumentoGrosor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(152, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 194);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(498, 19);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(75, 23);
            this.btnLinea.TabIndex = 10;
            this.btnLinea.Text = "Linea";
            this.btnLinea.UseVisualStyleBackColor = true;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(386, 19);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 9;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(269, 19);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 8;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(152, 19);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 7;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            // 
            // btnRelleno
            // 
            this.btnRelleno.Location = new System.Drawing.Point(386, 247);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(75, 23);
            this.btnRelleno.TabIndex = 14;
            this.btnRelleno.Text = "Rellenar";
            this.btnRelleno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelleno);
            this.Controls.Add(this.btnMenorGrosor);
            this.Controls.Add(this.btnAumentoGrosor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCirculo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenorGrosor;
        private System.Windows.Forms.Button btnAumentoGrosor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnRelleno;
    }
}

