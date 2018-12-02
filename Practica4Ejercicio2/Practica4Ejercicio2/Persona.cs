using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Ejercicio2
{
    class Persona
    {
        private string nombre;
        private int edad;
        
        public void Inicializar()
        {
            Console.WriteLine("Introduzca el nombre : ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca la edad : ");
            edad = Convert.ToInt32(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre : ");
            Console.WriteLine(nombre);
            Console.WriteLine("Edad : ");
            Console.WriteLine(edad);
        }
        private void MayorDeEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
        }
        static void Main(string[] args)
        {
            Persona NuevaPersona = new Persona();
            NuevaPersona.Inicializar();
            NuevaPersona.Imprimir();
            NuevaPersona.MayorDeEdad();
            Console.ReadKey();
        }
    }
}
