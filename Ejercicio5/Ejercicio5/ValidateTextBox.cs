using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class ValidateTextBox: UserControl
    {
        public ValidateTextBox()
        {
            InitializeComponent();
            Height = textBox1.Height + 20;
            Width = textBox1.Width + 20;
            Refresh();
        }
    }
}
