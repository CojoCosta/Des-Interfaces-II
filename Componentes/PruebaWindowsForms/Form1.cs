using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabelTexBox;

namespace PruebaWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = labelTexbox1.Text;
            labelTexbox1.Posicion = labelTexbox1.Posicion == EPosicion.IZQUIERDA ? EPosicion.DERECHA : EPosicion.IZQUIERDA;
        }

        private void labelTexbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("PULSANDO");
        }

        private void labelTexbox1_PosicionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("CAMBIO DE POSICION");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                base.OnPaint(e);
        }
        bool pintar = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            if (pintar)
            {
                e.Graphics.DrawString("Que liada meu", this.Font, Brushes.Magenta, 10, 10);
                e.Graphics.FillEllipse(Brushes.Magenta, 10, 30, 100, 40);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Graphics gr = this.CreateGraphics();
            //gr.DrawString("Escribo fuera del OnPaint", this.Font, Brushes.BlueViolet, 10, 60);
            //gr.DrawImage(new Bitmap(@"C:\Windows\Web\Wallpaper\Theme2\img7.jpg"), 10, 90);
            pintar = !pintar;
            this.Text = pintar.ToString();
            this.Refresh();
        }
    }
}
