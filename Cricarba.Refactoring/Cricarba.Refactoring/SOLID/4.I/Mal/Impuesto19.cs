using Cricarba.Refactoring.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cricarba.Refactoring.SOLID._4.I.Mal
{
    class Impuesto19 : IImpuesto
    {
        public double CalcularImpuesto(Producto producto)
        {
            return producto.Valor * 19 / 100;
        }

        public IEnumerable<int> CargarImpuestos()
        {
            throw new NotImplementedException();
        }

        public bool GuardarImpuesto()
        {
            throw new NotImplementedException();
        }
    }
}
