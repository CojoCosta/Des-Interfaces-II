using ComponenteEj1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = lblTxt.Posicion.ToString();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if(lblTxt.Posicion == EPosicion.IZQUIERDA)
            {
                lblTxt.Posicion = EPosicion.DERECHA;
            }
            else
            {
                lblTxt.Posicion = EPosicion.IZQUIERDA;
            }
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            lblTxt.Separacion += 2;
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            lblTxt.Separacion -= 2;
        }

        
    }
}
