using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class ComponenteAhorcado : UserControl
    {
        public ComponenteAhorcado()
        {
            InitializeComponent();
        }

        private int errores;
        [Category("ZZComponentes Nuevos")]
        [Description("Enumera el número de errores")]
        public int Errores
        {
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 7)
                {
                    value = 7;
                    OnAhorcado(this, EventArgs.Empty);
                }
                if (errores != value)
                {
                    OnCambiaError(this, EventArgs.Empty);

                }
                errores = value;
                Refresh();
            }
            get
            {
                return errores;
            }

        }


        [Category("Errores")]
        [Description("Cambia cada vez que se comete un error")]
        public EventHandler CambiaError;
        public virtual void OnCambiaError(object sender, EventArgs e)
        {
            if (CambiaError != null)
            {
                CambiaError(this, EventArgs.Empty);
            }
        }

        [Category("Errores")]
        [Description("Finaliza la ronda por numero máximo de errores")]
        public EventHandler Ahorcado;
        public virtual void OnAhorcado(object sender, EventArgs e)
        {
            if (Ahorcado != null)
            {
                Ahorcado(this, EventArgs.Empty);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.Black);
            switch (errores)
            {
                case 0:
                    e.Graphics.Clear(DefaultBackColor);
                    break;
                case 1:
                    e.Graphics.DrawLine(pen, Width * 0.1f, Height * 0.9f, Width * 0.9f, Height * 0.9f);
                    break;
                case 2:
                    e.Graphics.DrawLine(pen, Width * 0.45f, Height * 0.9f, Width * 0.45f, Height * 0.1f);
                    goto case 1;
                case 3:
                    e.Graphics.DrawLine(pen, Width * 0.45f, Height * 0.1f, Width * 0.75f, Height * 0.1f);
                    goto case 2;
                case 4:
                    e.Graphics.DrawLine(pen, Width * 0.75f, Height * 0.1f, Width * 0.75f, Height * 0.25f);
                    goto case 3;
                case 5:
                    e.Graphics.DrawEllipse(pen, Width * 0.70f, Height * 0.25f, Width * 0.1f, Width * 0.1f);
                    goto case 4;
                case 6:
                    e.Graphics.DrawLine(pen, Width * 0.75f, Height * 0.25f + Width * 0.1f, Width * 0.75f, Height * 0.65f);
                    goto case 5;
                case 7:
                    //BRAZOS
                    e.Graphics.DrawLine(pen, Width * 0.75f, Height * 0.25f + Width * 0.1f, Width * 0.55f, Height * 0.5f);
                    e.Graphics.DrawLine(pen, Width * 0.75f, Height * 0.25f + Width * 0.1f, Width * 0.95f, Height * 0.5f);
                    //PIERNAS
                    e.Graphics.DrawLine(pen, Width * 0.75f, Height * 0.65f, Width * 0.55f, Height * 0.85f);
                    e.Graphics.DrawLine(pen, Width * 0.75f, Height * 0.65f, Width * 0.95f, Height * 0.85f);
                    goto case 6;

            }
        }
    }
}
