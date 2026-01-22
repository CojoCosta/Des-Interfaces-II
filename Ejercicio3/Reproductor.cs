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
        public Reproductor()
        {
            InitializeComponent();
        }
        bool playPause = true;
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
        [Category ("Clickar")]
        [Description("play click")]
        public event System.EventHandler PlayClick;

        [Category("Tiempo")]
        [Description("Nº de minutos")]
        private int minutos;
        public int Minutos
        {
            set
            {
                minutos = value;
                if (minutos / 60 == 0)
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
                if (segundos / 60 == 0)
                {
                    segundos = 0;
                }
                Refresh();
            }
            get
            {
                return segundos;
            }
        }
    }
}
