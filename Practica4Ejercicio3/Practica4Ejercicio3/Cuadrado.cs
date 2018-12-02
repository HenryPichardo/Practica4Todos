using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Ejercicio3
{
    class Cuadrado
    {
        private int lado;
        public void Inicializar()
        {
            Console.WriteLine("Ingrese el valor del lado : ");
            lado = Convert.ToInt32(Console.ReadLine());
        }
        public void ImprimirPerimetro()
        {
            int perimetro = lado * 4;
            Console.WriteLine("El perimetro es = " + perimetro);
        }
        public void ImprimirSuperficie()
        {
            int superficie = lado * lado;
            Console.WriteLine("La superficie es = " + superficie);
        }

        static void Main(string[] args)
        {
            Cuadrado NuevoCuadrado = new Cuadrado();
            NuevoCuadrado.Inicializar();
            NuevoCuadrado.ImprimirPerimetro();
            NuevoCuadrado.ImprimirSuperficie();
            Console.ReadKey();

        }
    }
}
