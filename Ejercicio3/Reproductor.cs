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
    public partial class Reproductor: UserControl
    {
        String formatotiempo;
        public Reproductor()
        {
            InitializeComponent();
            formatotiempo = $"{Minutos:00}:{Segundos:00}";
        }
        bool playPause = true;

        [Category ("Clickar")]
        [Description("Pulsar botón")]
        public event EventHandler PlayClick;

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (playPause)
            {
                btnPlayPause.Text = "Pause";
                playPause = false;
            }
            else
            {
                btnPlayPause.Text = "Play";
                playPause = true;
            }
            Refresh();
        }

        [Category("Tiempo")]
        [Description("Nº de minutos")]
        private int minutos;
        public int Minutos
        {
            set
            {
                minutos = value;
                if (minutos > 59)
                {
                    minutos = 0;
                }
                Refresh();
            }
            get
            {
                return minutos;
            }
        }
        [Category("Tiempo")]
        [Description("Nº de segundos")]
        private int segundos;
        public int Segundos
        {
            set
            {
                segundos = value;
                if (segundos > 59)
                {
                    segundos = value % 60;
                }
                Refresh();
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

        }
    }
}
