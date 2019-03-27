using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3__Uso_For_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Desarrollar un programa que muestre la tabla de multiplicar de un número ingresado por el teclado del 1 al 15

            //Console.WriteLine("Ingrese el número a multiplicar:");
            //int numeroMultiplica = int.Parse(Console.ReadLine());
            //Console.WriteLine("La tabla del #" + numeroMultiplica + " es:");

            //for (int i = 1; i <= 15; i++)
            //{
            //    Console.WriteLine(numeroMultiplica * i);
            //}
            //Console.ReadKey();

            // 2. Realizar un programa que permita ingresar n números enteros por el teclado y se desea conocer:
            //a) La cantidad de números positivos.
            //b) La cantidad de números negativos.
            //c) La cantidad de números pares.
            //d)La cantidad de números impares

            int nNumeros;
            do
            {
                Console.Write("Ingrese una cantidad positiva de números a evaluar:");
                nNumeros = int.Parse(Console.ReadLine());

            } while (nNumeros <=0);
            
            int numPositivos = 0;
            int numNegativos = 0;
            int numPares = 0;
            int numImpares = 0;

            for (int i = 1; i <= nNumeros; i++)
            {
                Console.Write("Ingrese el #" + i + ":");
                int numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > 0)
                {
                    numPositivos++;
                }
                else if (numeroIngresado < 0)
                {
                    numNegativos++;
                }

                if (numeroIngresado % 2 == 0)
                {
                    numPares++;
                }
                else if (numeroIngresado % 2 != 0)
                {
                    numImpares++;
                }
            }

            Console.WriteLine("La cantidad de números Positivos es:" + numPositivos);
            Console.WriteLine("La cantidad de números Negativos es:" + numNegativos);
            Console.WriteLine("La cantidad de números Pares es:" + numPares);
            Console.WriteLine("La cantidad de números Impares es:" + numImpares);

            Console.ReadKey();



            //----------------------For each-----------------------
            //string cadena = "texto de prueba";
            //foreach (char letra in cadena)
            //{
            //    Console.WriteLine(letra);
            //    //codigo
            //}


            //int i;
            //int contador = 0;
            //for (i = 0; i <= 25; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("A" + contador);
            //    contador = contador + 1;
            //}
        }
    }
}
