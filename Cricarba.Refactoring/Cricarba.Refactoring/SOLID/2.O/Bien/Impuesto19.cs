using System;
using System.Collections.Generic;
using System.Text;
using Cricarba.Refactoring.Dominio;

namespace Cricarba.Refactoring.SOLID._2.O.Bien
{
    class Impuesto19 : ICalcularImpuesto
    {
        public double ObtenerImpuesto(Producto producto)
        {
            return producto.Valor * 19 / 100;
        }
    }
}
