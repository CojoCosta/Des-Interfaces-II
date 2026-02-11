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
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        [Category("ZZComponentes Nuevos")]
        [Description("Enumera el número de errores")]
        private int errores;
        public int Errores
        {
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Refresh();
                }
                if (value > 7)
                {
                    value = 7;
                    Refresh();
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

        }
    }
}
