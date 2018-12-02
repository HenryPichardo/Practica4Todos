using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Ejercicio4
{
    class Operaciones
    {
        private int n1, n2;
        public void Inicializar()
        {
            Console.WriteLine("Introduzca el valor 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor 2");
            n2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Suma()
        {
            int suma = n1 + n2;
            Console.WriteLine("La suma de los dos valores es : "+ suma);
        }
        public void Resta()
        {
            int resta = n1 - n2;
            Console.WriteLine("La resta de los dos valores es : " + resta);
        }
        public void Multiplicacion()
        {
            int mult = n1 * n2;
            Console.WriteLine("La multiplicacion de los dos valores es : " + mult);
        }
        public void Division()
        {
            int div = n1 / n2;
            Console.WriteLine("La division de los dos valores es : " + div);
        }
        static void Main(string[] args)
        {
            Operaciones NuevaOp = new Operaciones();
            NuevaOp.Inicializar();
            NuevaOp.Suma();
            NuevaOp.Resta();
            NuevaOp.Multiplicacion();
            NuevaOp.Division();
            Console.ReadKey();

        }
    }
}
