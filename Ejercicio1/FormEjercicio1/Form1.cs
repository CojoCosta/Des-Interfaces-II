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
    public partial class Form1 : Form//Probar bien separacion y keyup
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                this.Text = "Aumento de separación";
            }
            else
            {
                this.Text = "Reducción de la separación";
            }
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = lblTxt.Posicion.ToString();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (lblTxt.Posicion == EPosicion.IZQUIERDA)
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
            flag = true;
            lblTxt.Separacion += 2;
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            if (lblTxt.Separacion > 0)
            {
                flag = false;
                lblTxt.Separacion -= 2;
            }
        }

        private void lblTxt_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "KeyUp usado";
        }
    }
}