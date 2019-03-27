using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__ColaboraciondeClases_Ejercicio1_
{
    //Problema 1:
    //Un banco tiene 3 clientes que pueden hacer depósitos y extracciones.También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.
    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;
        public Banco()
        {
            cliente1 = new Cliente("María");
            cliente2 = new Cliente("Daniela");
            cliente3 = new Cliente("July");
        }
        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(150);
            cliente3.Depositar(200);
            cliente3.Extraer(150);
        }
        public void DepositosTotales()
        {
            int t = cliente3.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero en el banco es: "+t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
        static void Main(string[] args)
        {
            Banco bancos = new Banco();
            bancos.Operar();
            bancos.DepositosTotales();
            Console.ReadKey();
        }
    }
}
