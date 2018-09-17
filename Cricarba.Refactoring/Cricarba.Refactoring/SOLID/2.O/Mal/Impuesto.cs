using Cricarba.Refactoring.Dominio;

namespace Cricarba.Refactoring.SOLID._2.O.Mal
{
    class Impuesto
    {
        public double ObtenerImpuesto(Producto producto)
        {
            if (producto.TipoImpuesto == 1)
                return producto.Valor * 19 / 100;
            else if (producto.TipoImpuesto == 2)
                return producto.Valor * 10 / 100;
            else if (producto.TipoImpuesto == 3)
                return producto.Valor * 8 / 100;
            return 0;
        }
    }
}
