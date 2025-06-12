using System.Linq.Expressions;
using System.Xml.Schema;
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

        public double Sumar(double termino)
        {
            valor += termino;
            Console.WriteLine(valor);
            return valor;
        }
        public double Restar(double termino)
        {
            valor -= termino;
            Console.WriteLine(valor);
            return valor;
        }
        public double Multiplicar(double termino)
        {
            valor *= termino;
            Console.WriteLine(valor);
            return valor;
        }
        public double Dividir(double termino)
        {
            while (termino == 0)
            {
                Console.WriteLine("disculpa maestro, no se puede dividir en 0");
                return termino;

            }

            valor /= termino;
            Console.WriteLine(valor);
            return valor;


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

        private TipoOperacion operacion;



        public double resultado_anterior
        {
            get => resultadoAnterior;

            set => resultadoAnterior = value;
        }

        public double nuevo_valor
        {
            get => nuevoValor;

            set => nuevoValor = value;
        }

        public TipoOperacion OperacionTipo
        {
            get => operacion;

            set => operacion = value;
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
