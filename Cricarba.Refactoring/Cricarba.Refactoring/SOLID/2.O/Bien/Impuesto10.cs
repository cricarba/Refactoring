using System;
using System.Collections.Generic;
using System.Text;
using Cricarba.Refactoring.Dominio;

namespace Cricarba.Refactoring.SOLID._2.O.Bien
{
    class Impuesto10 : ICalcularImpuesto
    {
        public double ObtenerImpuesto(Producto producto)
        {
            return producto.Valor * 10 / 100;
        }
    }
}
