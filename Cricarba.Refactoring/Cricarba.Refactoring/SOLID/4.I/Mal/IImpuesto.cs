using Cricarba.Refactoring.Dominio;
using System.Collections.Generic;

namespace Cricarba.Refactoring.SOLID._4.I.Mal
{
    interface IImpuesto
    {
        double CalcularImpuesto(Producto producto);
        IEnumerable<int> CargarImpuestos();
        bool GuardarImpuesto();
    }
}
