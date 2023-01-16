using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Titulo
    {
        public Titulo(string nombreAutor, string nombreTitulo, string categoria, double precio, string notas)
        {
            NombreAutor = nombreAutor;
            NombreTitulo = nombreTitulo;
            Categoria = categoria;
            Precio = precio;
            Notas = notas;
        }
        public string NombreAutor { get; set; }
        public string NombreTitulo { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string Notas { get; set; }  
    }
}
