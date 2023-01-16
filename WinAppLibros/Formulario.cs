using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Persona;

namespace WinAppLibros
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Mostrar(object sender, EventArgs e)
        {
            var a = new Autor("Gabriel", "García Márquez", new DateTime(1967, 03, 05), "Calle De la Loma 19 en San Ángel", "Aracataca", "Colombia");
            MessageBox.Show(a.ToString());
        }
    }
}
