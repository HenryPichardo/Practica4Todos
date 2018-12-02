using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Problema3
{
    class Socio
    {
        private string nombre;
        private int antig;
        public  Socio (string nombre)
        {            
            Console.WriteLine("Ingrese el nombre del socio ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Cuantos años de antiguedad tiene en el club");
            antig = Convert.ToInt32(Console.ReadKey());
            
        }

        class Club
        {
            private Socio socio1, socio2, socio3;
            public Club()
            {
                socio1 = new Socio(nombre);
                socio2 = new Socio();
                socio3 = new Socio();
            }
            public void MayorAntiguedad()
            {
                if (socio1.antig > socio2.antig && socio1.antig > socio3.antig)
                {
                    Console.WriteLine("El socio 1 es el de mayor antiguedad ");
                }
                else if (socio2.antig > socio3.antig)
                {
                    Console.WriteLine("El socio 2 es el de mayor antiguedad ");
                }
                else
                {
                    Console.WriteLine("El socio 3 es el de mayor antiguedad ");
                }
            }

            static void Main(string[] args)
            {
                Club NuevoClub = new Club();
                NuevoClub.Club();
            }
        }

    }
}
