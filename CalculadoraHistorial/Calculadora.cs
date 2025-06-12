using System.Linq.Expressions;
using espacioCalculadora;

namespace espacioCalculadora
{

    public class Calculadora
    {
        private double valor;
        public double Resultado
        {
            get => valor;
        }

        public void Sumar(double termino)
        {
            valor += termino;
            Console.WriteLine(valor);
        }
        public void Restar(double termino)
        {
            valor -= termino;
            Console.WriteLine(valor);
        }
        public void Multiplicar(double termino)
        {
            valor *= termino;
            Console.WriteLine(valor);
        }
        public void Dividir(double termino)
        {
            while (termino == 0)
            {
                Console.WriteLine("disculpa maestro, no se puede dividir en 0");
                return;

            }

            valor /= termino;
            Console.WriteLine(valor);


        }
        public void Limpiar()
        {
            valor = 0;

        }

    }

    public class Operacion
    {
        private double resultadoAnterior;

        private double nuevoValor;

        private TipoOperacion opearcion;

        public double Resultado
        {

        }

        public double NuevoValor
        {
            get => nuevoValor;

            set => nuevoValor =;
        }

        public enum TipoOperacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar
        }
    }

}
