using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioEj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            MessageBox.Show("Has clickado en el icono o imagen");
        }


        //TODO  A PARTIR DE AQUI EJERCICIO 3
        private void btnSelectdirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog directorio = new FolderBrowserDialog())
            {
                directorio.Description = "Elige un directorio";
                //if (directorio.)
                {
                    
                }
            }
        }
    }
}
