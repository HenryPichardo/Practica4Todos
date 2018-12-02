using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Problema1
{
    class Empleado
    {
        private string nombre;
        private int sueldo;
        public void Inicializar()
        {
            Console.WriteLine("Introduzca el nombre del empleado : ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el sueldo : ");
            sueldo = Convert.ToInt32(Console.ReadLine());
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Sueldo : "+sueldo);
        }
        public void Impuestos()
        {
            if (sueldo > 30000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No bede pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado NuevoEmp = new Empleado();
            NuevoEmp.Inicializar();
            NuevoEmp.ImprimirDatos();
            NuevoEmp.Impuestos();
            Console.ReadKey();
        }
    }
}
