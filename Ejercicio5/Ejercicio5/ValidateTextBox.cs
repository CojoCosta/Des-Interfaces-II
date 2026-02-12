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
    public enum eTipo
    {
        Numerico, Textual
    }
    public partial class ValidateTextBox : UserControl //TODO icono, nombre del formulario
    {
        bool isChecked = false;
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
            Graphics grapchis = e.Graphics;
            Pen pen = new Pen(Color.Red);
            Point punto = new Point(5, 5);
            int w = Width - 6;
            int h = Height - 6;
            if (isChecked)
            {
                pen.Color = Color.Green;
            }
            else
            {
                pen.Color = Color.Red;
            }
                grapchis.DrawRectangle(pen, new Rectangle(5, 5, w, h));
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

        private eTipo tipo;
        [Category("Mis propiedades")]
        [Description("Tipo de caracter de entrada")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                Refresh();
            }
            get
            {
                return tipo;
            }
        }

        [Category("Mis eventos")]
        [Description("Cambio de texto")]
        public event EventHandler txt_TextChanged;
        protected virtual void Ontxt_TextChanged(object sender, EventArgs e)
        {
            if (txt_TextChanged != null)
            {
                txt_TextChanged(this, e);
            }
        }
        public bool checkFormatoTextual(string contenido)
        {
            foreach (char c in contenido)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return contenido != "";
        }
        public bool checkFormatoNumerico(string contenido)
        {
            return int.TryParse(contenido.Trim(), out _);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tipo == eTipo.Numerico)
            {
                isChecked = checkFormatoNumerico(textBox1.Text);
            }
            else if (tipo == eTipo.Textual)
            {
                isChecked = checkFormatoTextual(textBox1.Text);
            }
            Refresh();
            Ontxt_TextChanged(sender, e);
        }

    }
}
