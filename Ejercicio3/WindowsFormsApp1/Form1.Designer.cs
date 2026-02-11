namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbIntervalo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reproductor1 = new Ejercicio3.Reproductor();
            this.pbFotos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(194, 385);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(141, 23);
            this.btnSelectDirectory.TabIndex = 2;
            this.btnSelectDirectory.Text = "Selección de directorio";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbIntervalo
            // 
            this.cbIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervalo.FormattingEnabled = true;
            this.cbIntervalo.Location = new System.Drawing.Point(363, 385);
            this.cbIntervalo.Name = "cbIntervalo";
            this.cbIntervalo.Size = new System.Drawing.Size(152, 21);
            this.cbIntervalo.TabIndex = 3;
            this.cbIntervalo.SelectedIndexChanged += new System.EventHandler(this.cbIntervalo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intervalo de paso de imágenes";
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(60, 364);
            this.reproductor1.Minutos = 66;
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Segundos = 0;
            this.reproductor1.Size = new System.Drawing.Size(137, 85);
            this.reproductor1.TabIndex = 0;
            this.reproductor1.PlayClick += new System.EventHandler(this.reproductor1_PlayClick);
            // 
            // pbFotos
            // 
            this.pbFotos.Location = new System.Drawing.Point(60, 39);
            this.pbFotos.Name = "pbFotos";
            this.pbFotos.Size = new System.Drawing.Size(526, 284);
            this.pbFotos.TabIndex = 5;
            this.pbFotos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.pbFotos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIntervalo);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.reproductor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ejercicio3.Reproductor reproductor1;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbIntervalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFotos;
    }
}

