using Cricarba.Refactoring.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cricarba.Refactoring.SOLID._2.O.Mal
{
    class Factura
    {

        public List<Producto> Productos { get; set; }
        bool CrearFactura()
        {
            var total = 0d;
            foreach (var producto in Productos)
            {
                Console.WriteLine($"{producto.Nombre}");
                total -= new Impuesto().ObtenerImpuesto(producto);
            }
            return true;
        }
    }
}
