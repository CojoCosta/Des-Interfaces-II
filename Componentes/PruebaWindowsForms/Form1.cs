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

        }

        private void labelTexbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("PULSANDO");
        }

        private void labelTexbox1_PosicionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("CAMBIO DE POSICION");
        }
    }
}
