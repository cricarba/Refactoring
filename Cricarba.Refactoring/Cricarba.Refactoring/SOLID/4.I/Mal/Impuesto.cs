using System;
using System.Collections.Generic;
using System.Text;
using Cricarba.Refactoring.Dominio;

namespace Cricarba.Refactoring.SOLID._4.I.Mal
{
    class Impuesto : IImpuesto
    {
       
        public double CalcularImpuesto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> CargarImpuestos()
        {
            return new List<int>();
        }

        public bool GuardarImpuesto()
        {
            return true;
        }
    }
}
