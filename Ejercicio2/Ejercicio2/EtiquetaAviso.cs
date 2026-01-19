using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio2
{
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }
        Color colorInicial = Color.Blue;
        Color colorFinal = Color.Green;
        public enum EMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Refresh();
        }
        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                Refresh();
            }
            get
            {
                return marca;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    graphics.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    graphics.DrawLine(lapiz, grosor, grosor, h, h);
                    graphics.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case EMarca.Imagen:

                    break;
            }
            //gradiente
            LinearGradientBrush gradiente = new LinearGradientBrush(new Point(0, 20), new Point(20, 40), colorInicial, colorFinal);
            SolidBrush solidBrush = new SolidBrush(this.ForeColor);
            if (Gradiente)
            {
                graphics.DrawString(this.Text, this.Font, gradiente, offsetX + grosor, offsetY);
                gradiente.Dispose();
            }
            else
            {
                graphics.DrawString(this.Text, this.Font, solidBrush, offsetX + grosor, offsetY);
                solidBrush.Dispose();
            }
            Size tam = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
        }
        [Category("Colores")]
        [Description("Elegir si el colore es gradiente entre 2 colores o es un color unico")]
        private bool gradiente;
        public bool Gradiente
        {
            set
            {
                this.gradiente = value;
            }
            get
            {
                return this.gradiente;
            }
        }
    }
}