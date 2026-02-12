using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio5
{
    public partial class ValidateTextBox : UserControl //TODO icono, nombre del formulario
    {
        public ValidateTextBox()
        {
            InitializeComponent();
            recolocar();
        }
        private void recolocar()
        {
            Height = textBox1.Height + 20;
            textBox1.Width = Width - 20;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
        }

        [Category("Mis propiedades")]
        [Description("Acceder al texto del textbox")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
                Refresh();
            }
            get
            {
                return textBox1.Text;
            }
        }


        [Category("Mis propiedades")]
        [Description("Hacer el textbox multilinea")]
        public bool Multilinea
        {
            set
            {
                
                textBox1.Multiline = value;
                Refresh();
            }
            get
            {
                return textBox1.Multiline;
            }


        }
    }
}
