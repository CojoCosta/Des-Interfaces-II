namespace PruebaWindowsForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelTexbox1 = new LabelTexBox.LabelTexbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTexbox1
            // 
            this.labelTexbox1.Location = new System.Drawing.Point(31, 41);
            this.labelTexbox1.Name = "labelTexbox1";
            this.labelTexbox1.Posicion = LabelTexBox.EPosicion.IZQUIERDA;
            this.labelTexbox1.Separacion = 20;
            this.labelTexbox1.Size = new System.Drawing.Size(303, 20);
            this.labelTexbox1.TabIndex = 2;
            this.labelTexbox1.TextLbl = "label1";
            this.labelTexbox1.TextTxt = "";
            this.labelTexbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTexbox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTexbox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private LabelTexBox.LabelTexbox labelTexbox1;
    }
}

