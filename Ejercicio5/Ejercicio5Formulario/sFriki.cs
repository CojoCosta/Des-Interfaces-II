using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5Formulario
{
    enum eAficion
    {
        Manga, SciFi, RPG, Fantasia, Terror, Tecnologia
    }
    enum eSexo
    {
        Hombre, Mujer
    }
    internal class sFriki
    {

        private string nombre;
        public String Nombre { set; get; }

        private int edad;
        public int Edad { set; get; }

        private eAficion aficion;
        public eAficion Aficion { set; get; }

        private eSexo sexo;
        public eSexo Sexo { set; get; }

        private eSexo sexoOpuesto;

        public eSexo SexoOpuesto { set; get; }

        private string foto;
        public string Foto { set; get; }

        public sFriki(string nombre, int edad, eAficion aficion, eSexo sexo, eSexo sexoOpuesto,  string foto)
        {
            Nombre = nombre;
            Edad = edad;
            Aficion = aficion;
            Sexo = sexo;
            SexoOpuesto = sexoOpuesto;
            Foto = foto;
        }
        public sFriki()
        {
        }
    }
}
