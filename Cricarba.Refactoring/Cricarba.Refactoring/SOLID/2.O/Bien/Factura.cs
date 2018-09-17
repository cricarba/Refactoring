using Cricarba.Refactoring.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cricarba.Refactoring.SOLID._2.O.Bien
{
    class Factura
    {
        public List<Producto> Productos { get; set; }
        public Dictionary<int,ICalcularImpuesto> DiccionarioImpuestos { get; set; }

        public Factura()
        {
            DiccionarioImpuestos = new Dictionary<int, ICalcularImpuesto>();
            DiccionarioImpuestos.Add(1, new Impuesto19());
            DiccionarioImpuestos.Add(2, new Impuesto10());
            DiccionarioImpuestos.Add(3, new Impuesto8());

        }
        bool CrearFactura()
        {
            var total = 0d;
            foreach (var producto in Productos)
            {
                Console.WriteLine($"{producto.Nombre}");
                total -= DiccionarioImpuestos[producto.TipoImpuesto].ObtenerImpuesto(producto);
            }
            return true;
        }
    }
}
