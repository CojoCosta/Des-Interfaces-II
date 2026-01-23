using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;//Revisar offset nada,

namespace Ejercicio2
{
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }
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
        int offsetX = 0; //Desplazamiento a la derecha del texto
        int offsetY = 0; //Desplazamiento hacia abajo del texto

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
                            // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            LinearGradientBrush gradiente = new LinearGradientBrush(new Point(0, 0), new Point(260, 200), colorInicial, colorFinal);
            if (Gradiente)
            {
                graphics.FillRectangle(gradiente, new Rectangle(0, 0, Width, Height));
            }
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 3;
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
                    if (ImagenMarca != null)
                    {
                        grosor = 3;
                        graphics.DrawImage(ImagenMarca, 0, 0, h, h);
                        offsetX = h;
                    }
                    break;
            }
            SolidBrush solidBrush = new SolidBrush(this.ForeColor);
            graphics.DrawString(this.Text, this.Font, solidBrush, offsetX + grosor, offsetY);
            solidBrush.Dispose();
            Size tam = graphics.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
        }
        [Category("Clickar")]
        [Description("Solo poder hacer click en la imagen")]
        public event System.EventHandler ClickEnMarca;
        protected virtual void OnClickEnMarca()
        {
            if (ClickEnMarca != null)
            {
                ClickEnMarca(this, EventArgs.Empty);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int x = e.X;
            int y = e.Y;

            if (marca != EMarca.Nada && x < offsetX)
            {
                OnClickEnMarca();
            }
        }

        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        private EMarca marca = EMarca.Nada;
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

        [Category("Colores")]
        [Description("Elegir color es el inicial")]
        private Color colorInicial;
        public Color ColorInicial
        {
            set
            {
                this.colorInicial = value;
                Refresh();
            }
            get
            {
                return this.colorInicial;
            }
        }
        [Category("Colores")]
        [Description("Elegir color es el inicial")]
        private Color colorFinal;
        public Color ColorFinal
        {
            set
            {
                this.colorFinal = value;
                Refresh();
            }
            get
            {
                return this.colorFinal;
            }
        }

        [Category("Colores")]
        [Description("Elegir si el color es gradiente entre 2 colores o es un color unico")]
        private bool gradiente;
        public bool Gradiente
        {
            set
            {
                this.gradiente = value;
                Refresh();
            }
            get
            {
                return this.gradiente;
            }
        }

        [Category("Imagen")]
        [Description("Elegir una imagen para usar en la etiqueta")]
        private System.Drawing.Image imagenMarca;
        public System.Drawing.Image ImagenMarca
        {
            set
            {
                this.imagenMarca = value;
                Refresh();
            }
            get
            {
                return this.imagenMarca;
            }
        }
    }
}