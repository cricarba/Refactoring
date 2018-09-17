using Cricarba.Refactoring.Dominio;

namespace Cricarba.Refactoring.SOLID._4.I.Bien
{
    class Impuesto19 : ICalcularImpuesto
    {
        public double CalcularImpuesto(Producto producto)
        {
            return producto.Valor * 19 / 100;
        }       
    }
}
