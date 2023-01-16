using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class Empleado : Persona
    {
        public Empleado(string nombre, string apellido, string titulo, DateTime fechaIngreso) : base(nombre, apellido)
        {
            Titulo = titulo;
            FechaIngreso = fechaIngreso;
        }

        public string Titulo { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
