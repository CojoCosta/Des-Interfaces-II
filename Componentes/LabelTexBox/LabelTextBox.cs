using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LabelTexBox
{
    public enum EPosicion
    {
        IZQUIERDA, DERECHA
    }
    [
        DefaultProperty("TextLbl"), 
        DefaultEvent("Load") //Le pongo la funcion asociada que yo elija
    ]
    public partial class LabelTexbox : UserControl
    {
        public LabelTexbox()
        {
            InitializeComponent();
        }


        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Nuevas")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    //PosicionChanged(this, new EventArgs());
                    //PosicionChanged(this, EventArgs.Empty);
                    OnPosicionChanged(EventArgs.Empty);
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }


        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Nuevas")] // O se puede meter en categoría Design.
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }


        [Category("Mis Propiedades")]
        [Description("Texto asociado al Label del control")]
        public string TextLbl
        {
            set { lbl.Text = value; }
            get { return lbl.Text; }
        }


        [Category("Mis Propiedades")]
        [Description("Texto asociado al Textbox del control")]
        public string TextTxt
        {
            set { txt.Text = value; }
            get { return txt.Text; }
        }


        private void recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("KeyPressed de txt");
            OnKeyPress(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;
        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }
    }
}
