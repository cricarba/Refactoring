using System;
using System.Collections.Generic;
using System.Text;

namespace Cricarba.Refactoring.SOLID._4.I.Bien
{
    class Impuesto : IImpuestoRepositorio
    {
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
