using Cricarba.Refactoring.Dominio;
using System;
using System.Collections.Generic;

namespace Cricarba.Refactoring.SOLID.S.Mal
{
    public class Factura
    {
        public List<Producto> Productos { get; set; }
        bool CrearFactura()
        {
            var total = 0d;
            foreach (var producto in Productos)
            {
                Console.WriteLine($"{producto.Nombre}");
                producto.Valor += ObtenerImpuesto(producto);
                total += producto.Valor;
            }
            return true;
        }

        double ObtenerImpuesto(Producto producto)
        {
            return producto.Valor * 19 / 100;
        }
    }
}
