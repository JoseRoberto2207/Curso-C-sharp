using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__Herencia_Ejercicio1_
{
    public class Prueba
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();
            suma1.Valor1 = 10;
            suma1.Valor2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma de "+suma1.Valor1+" y "+suma1.Valor2+" es "+suma1.Resultado);

            Resta resta1 = new Resta();
            resta1.Valor1 = 10;
            resta1.Valor2 = 7;
            resta1.Operar();
            Console.WriteLine("La resta de "+resta1.Valor1+" y "+resta1.Valor2+" es "+resta1.Resultado);
        }
    }
}
