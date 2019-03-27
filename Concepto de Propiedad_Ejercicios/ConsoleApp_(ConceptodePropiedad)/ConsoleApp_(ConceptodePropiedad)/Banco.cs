using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__ConceptodePropiedad_
{
    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente();
            cliente1.Nombre = "Juan";
            cliente1.Monto = 0;
            cliente2 = new Cliente();
            cliente2.Nombre = "Margarita";
            cliente2.Monto = 0;
            cliente3 = new Cliente();
            cliente3.Nombre = "Joana";
            cliente3.Monto = 0;
        }
        public void Operar()
        {
            cliente1.Monto = cliente1.Monto + 100;
            cliente2.Monto = cliente2.Monto + 150;
            cliente3.Monto = cliente3.Monto + 200;
        }
        public void DepositosTotales()
        {
            int t = cliente1.Monto + cliente2.Monto + cliente3.Monto;
            Console.WriteLine("El total de dinero en el banco es: "+t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}
