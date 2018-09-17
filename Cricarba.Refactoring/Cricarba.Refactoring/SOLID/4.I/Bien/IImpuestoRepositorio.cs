using System;
using System.Collections.Generic;
using System.Text;

namespace Cricarba.Refactoring.SOLID._4.I.Bien
{
    interface IImpuestoRepositorio
    {
        IEnumerable<int> CargarImpuestos();
        bool GuardarImpuesto();
    }
}
