using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Reproductor : UserControl//Revisar minutos y segundos.
    {
        public Reproductor()
        {
            InitializeComponent();
        }


        [Category("Clickar")]
        [Description("Pulsar botón")]
        public event EventHandler PlayClick;

        public virtual void OnPlayClick(object sender, EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, EventArgs.Empty);
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            btnPlayPause.Text = btnPlayPause.Text == "Play" ? "Pause" : "Play";
            OnPlayClick(sender, e);
        }

        private int minutos;
        [Category("Tiempo")]
        [Description("Nº de minutos")]
        public int Minutos
        {
            set
            {
                if (value < 0)
                {
                    new ArgumentException();
                }
                if (value > 59)
                {
                   // if (value % 60 == 0)
                    {
                        OnDesbordaTiempo(this, EventArgs.Empty);
                    }
                    value = 0;
                }
                minutos = value;
                lblTiempo.Text = $"{Minutos:00}:{Segundos:00}";
            }
            get
            {
                return minutos;
            }
        }
        private int segundos;
        [Category("Tiempo")]
        [Description("Nº de segundos")]
        public int Segundos
        {
            set
            {
                if (value < 0)
                {
                    new ArgumentException();
                }
                if (value > 59)
                {
                    if (value % 60 == 0)
                    {
                        OnDesbordaTiempo(this, EventArgs.Empty);
                    }
                    segundos = value % 60;
                  //  minutos++;
                }
                else
                {
                    segundos = value;
                }
                lblTiempo.Text = $"{Minutos:00}:{Segundos:00}";
            }
            get
            {
                return segundos;
            }
        }
        [Category("Desbordar")]
        [Description("Se lanza cuando segundos superan a 59")]
        public event EventHandler DesbordaTiempo;

        public virtual void OnDesbordaTiempo(object sender, EventArgs e)
        {
            if (DesbordaTiempo != null)
            {
                DesbordaTiempo(this, EventArgs.Empty);
            }
        }
        
    }
}
