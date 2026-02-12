using Ejercicio5Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5Formulario2
{
    public partial class Form2 : Form
    {
        enum eAficion
        {
            Manga, SciFi, RPG, Fantasia, Terror, Tecnologia
        }
        public Form2()
        {
            InitializeComponent();
            sFriki friki = new sFriki();
            cbAficiones.Items.Add("Manga");
            cbAficiones.Items.Add("SciFi");
            cbAficiones.Items.Add("RPG");
            cbAficiones.Items.Add("Fantasia");
            cbAficiones.Items.Add("ManTerrorga");
            cbAficiones.Items.Add("Tecnologia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            op.Filter = (".jpg|*.jpg");
            if (DialogResult.OK == dr)
            {
                txtFotos.Text = op.FileName;
            }
        }
    }
}
