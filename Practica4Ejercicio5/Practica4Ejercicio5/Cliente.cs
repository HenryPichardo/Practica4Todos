using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Ejercicio5
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente (string nom)
        {
            nombre = nom;
            monto = 0;
        }
        public void Depositar(int m)
        {
            monto = monto + m;
        }
        public void Extraer(int m)
        {
            monto = monto - m;
        }
        public int RetornarMonto()
        {
            return monto;
        }
        public void Imprimir()
        {
            Console.WriteLine(nombre+ "tiene depositado la suma de RD$"+monto);
        }
        class Banco
        {
            private Cliente cliente1, cliente2, cliente3;
            public Banco()
            {
                cliente1 = new Cliente("Juan ");
                cliente2 = new Cliente("Ana ");
                cliente3 = new Cliente("Pedro ");

            }
            public void Operar()
            {
                cliente1.Depositar(500);
                cliente2.Depositar(700);
                cliente3.Depositar(850);
                cliente3.Extraer(75);
            }
            public void DepositosTotales()
            {
                int t = cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
                Console.WriteLine("El total del dinero depositado en el banco es : RD$" + t);
                cliente1.Imprimir();
                cliente2.Imprimir();
                cliente3.Imprimir();
            }

            static void Main(string[] args)
            {
                Banco NuevoBanco = new Banco();
                NuevoBanco.Operar();
                NuevoBanco.DepositosTotales();
                Console.ReadKey();
            }

        }
    }
}
