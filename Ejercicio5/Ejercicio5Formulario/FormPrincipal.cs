using Ejercicio5Formulario2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5Formulario
{
    public partial class FormPrincipal : Form
    {
        private List<sFriki> frikis = new List<sFriki>();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count; i >= 0; i--)
            {
                for (int j = frikis.Count; j >= 0 ; j--)
                {
                    if (listBox1.SelectedItems[i].ToString() == frikis[j].Nombre)
                    {
                        frikis.RemoveAt(j);
                    }
                }
            }     
            listBox1.SelectedItems.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            DialogResult dr = f2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string nombre = f2.vtNombre.Texto;
                int edad = int.Parse(f2.vtEdad.Texto);
                bool flagAficion = Enum.TryParse(f2.cbAficiones.SelectedItem.ToString(), out eAficion aficion);
                bool flagSexo = Enum.TryParse(f2.SexoHombre.Checked ? f2.SexoHombre.ToString() : f2.SexoMujer.ToString(), out eSexo sexo);
                bool flagSexoO = Enum.TryParse(f2.SexoOpuestoHombre.Checked ? f2.SexoOpuestoHombre.ToString() : f2.SexoOpuestoMujer.ToString(), out eSexo sexoOpuesto);
                string foto = f2.txtFotos.Text;

                frikis.Add( new sFriki( nombre, edad, aficion, sexo, sexoOpuesto, foto));
                listBox1.Items.Add(nombre);

            }
        }
    }
}
