using Cricarba.Refactoring.Dominio;

namespace Cricarba.Refactoring.SOLID.S.Bien
{
    public class Impuesto
    {
        public double ObtenerImpuesto(Producto producto)
        {
            return producto.Valor * 19 / 100;
        }
    }
}
