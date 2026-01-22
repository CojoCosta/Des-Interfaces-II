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
        }
        [Category ("Clickar")]
        [Description("play click")]
        public event EventHandler PlayClick;

    }
}
