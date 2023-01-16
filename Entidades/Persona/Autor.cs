using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class Autor : Persona
    {
        public Autor(string nombre, string apellido, DateTime fechaNacimiento, string domicilio, string ciudad, string pais) : base(nombre, apellido)
        {
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
            Ciudad = ciudad;
            Pais = pais;
        }

        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                   $"Apellido: {Apellido}\n" +
                   $"Fecha de Nacimiento: {FechaNacimiento:yyyy-MM-dd-}\n" +
                   $"Domicilio: {Domicilio}\n" +
                   $"Ciudad: {Ciudad}\n" +
                   $"Pais: {Pais}";
        }
    }
}
