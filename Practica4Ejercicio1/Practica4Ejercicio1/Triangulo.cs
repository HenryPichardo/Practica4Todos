using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Ejercicio1
{
    class Triangulo

    {
        private int lado1, lado2, lado3;

        public void Inicializar()
        {
            Console.WriteLine("Introduzca el valor del lado 1 : ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el valor del lado 2 : ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el valor del lado 3 : ");
            lado1 = Convert.ToInt32(Console.ReadLine());
        }
        public void LadoMayor()
        {
            Console.WriteLine("Lado Mayor : ");
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine(lado1);
            }
            else if (lado2 > lado3)
            {
                Console.WriteLine(lado2);
            }
            else
            {
                Console.WriteLine(lado3);
            }
        }
        public void EsEquilatero()
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es un triangulo Equilatero");
            }
            else
            {
                Console.WriteLine("No es un triangulo Equilatero");
            }
        }

        static void Main(string[] args)
        {
            Triangulo nuevoTiangulo = new Triangulo();
            nuevoTiangulo.Inicializar();
            nuevoTiangulo.LadoMayor();
            nuevoTiangulo.EsEquilatero();
            Console.ReadKey();
        }
    }
}
