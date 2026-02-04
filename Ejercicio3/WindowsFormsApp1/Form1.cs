using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String path = "";
        int intervaloFotos = 0;
        bool flagReproduccion = false;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 21; i++)
            {
                cbIntervalo.Items.Add(i);
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecciona un directorio";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                }
            }
        }
        private void cbIntervalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            intervaloFotos = int.Parse(cbIntervalo.SelectedItem.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flagReproduccion)
            {
                
            }
        }


        private void reproductor1_PlayClick(object sender, EventArgs e)
        {
            flagReproduccion = !flagReproduccion;
            if (flagReproduccion)
            {
                
            }
        }
    }
}
