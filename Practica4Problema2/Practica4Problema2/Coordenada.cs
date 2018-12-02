using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Problema2
{
    class Coordenada
    {
        private int x, y;

        public void Cargar()
        {
            Console.WriteLine("Introduzca el valor de X ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de  Y");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void Imprimir()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("La coordenada representa un punto en el primer cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("La coordenada representa un punto en el segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("La coordenada representa un punto en el tercer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("La coordenada representa un punto en el cuarto cuadrante");
            }
        }
        static void Main(string[] args)
        {
            Coordenada NuevaCoor = new Coordenada();
            NuevaCoor.Cargar();
            NuevaCoor.Imprimir();
            Console.ReadKey();
        }
    }
}
