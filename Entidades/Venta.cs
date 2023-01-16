using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta 
    {
        public Venta(string tienda, string numeroOrden, DateTime fecha, int cantidad, string titulo)
        {
            Tienda = tienda;
            NumeroOrden = numeroOrden;
            Fecha = fecha;
            Cantidad = cantidad;
            Titulo = titulo;
        }

        public string Tienda { get; set; }
        public string NumeroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Titulo { get; set; }
    }
}
