using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String path = "";
        int tiempoParaCambiar = 0;
        int intervaloFotos = 0;
        int indiceFotos = 0;
        FileInfo[] fotos;
        DirectoryInfo d;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 21; i++)
            {
                cbIntervalo.Items.Add(i);
            }
            cbIntervalo.SelectedItem = 1;
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Selecciona un directorio";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        path = dialog.SelectedPath;
                        d = new DirectoryInfo(path);
                        fotos = d.GetFiles();
                        cambiarImagen();
                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Error con el directorio");
            }

        }
        private void cbIntervalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            intervaloFotos = int.Parse(cbIntervalo.SelectedItem.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reproductor1.Segundos++;
            tiempoParaCambiar++;
            if (tiempoParaCambiar == intervaloFotos)
            {
                tiempoParaCambiar = 0;
                cambiarImagen();
            }
        }

        public void cambiarImagen()
        {
            try
            {
                if (fotos != null && fotos.Length != 0)
                {
                    string extension = Path.GetExtension(fotos[indiceFotos].FullName).ToLower();
                    if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".jfif")
                    {
                        pbFotos.ImageLocation = fotos[indiceFotos].FullName;
                    }
                    else 
                    {
                        indiceFotos++;
                    }
                    indiceFotos++;
                }
                if (indiceFotos >= fotos.Length)
                {
                    indiceFotos = 0;
                }
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is OutOfMemoryException || ex is NullReferenceException || ex is IndexOutOfRangeException)
            {
                MessageBox.Show("Error", "Directorio inexistente o directorio sin imagenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reproductor1_PlayClick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
