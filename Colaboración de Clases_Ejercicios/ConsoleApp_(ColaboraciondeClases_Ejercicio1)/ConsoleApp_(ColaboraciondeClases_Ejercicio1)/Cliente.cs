using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__ColaboraciondeClases_Ejercicio1_
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string nom)
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
            Console.WriteLine(nombre+" Tiene depositado la suma de: "+monto);
        }
    }
}
