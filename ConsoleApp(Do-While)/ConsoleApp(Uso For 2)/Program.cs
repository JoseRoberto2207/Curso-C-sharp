using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uso_For_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Escribir un programa que solicite la carga de un número entre 0 y 999, 
            //y nos muestre un mensaje de cuántos dígitos tiene el mismo. Finalizar el programa cuando se cargue el valor 0.

            //int numero = 0;

            //do
            //{
            //    Console.WriteLine("Ingresa un número entre 0-999:");
            //    numero = int.Parse(Console.ReadLine());

            //} while (numero < 0 || numero > 999);

            //if (numero >= 100)
            //{
            //    Console.WriteLine("El número tiene 3 dígitos");

            //}
            //else if (numero >= 10)
            //{
            //    Console.WriteLine("El número tiene 2 dígitos");
            //}
            //else if (numero <= 9)
            //{
            //    Console.WriteLine("El número tiene solo 1 dígito");
            //}
            //Console.ReadKey();


            /*-------------------------------------------------------------------------*/

            //4. Escribir un programa que solicite la carga de números por teclado, obtener su promedio. Finalizar la carga de valores cuando se cargue el valor 0.

            //int numero = 0;
            //int suma = 0;
            //int cont = 0;

            //do
            //{
            //    Console.WriteLine("Ingrese un número diferente a 0:");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero != 0)
            //    {
            //        suma = suma + numero;
            //        cont = cont + 1;
            //    }

            //} while (numero != 0);

            //if (cont != 0)
            //{
            //    int promedio = suma / cont;
            //    Console.WriteLine("El promedio de los números ingresados es: " + promedio);
            //}
            //else
            //    Console.WriteLine("No se ingresaron números diferentes a 0");

            //Console.ReadKey();


            /*-------------------------------------------------------------------------*/

            // 5. Realizar un programa que permita ingresar el peso (en kilogramos) de piezas. El proceso termina cuando ingresamos el valor 0. Se debe informar:
            //a) Cuántas piezas tienen un peso entre 9.8 Kg.y 10.2 Kg.?, cuántas con más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?
            //b) La cantidad total de piezas procesadas.

            float peso = 0;
            int entre9_10 = 0;
            int masDe10 = 0;
            int menosDe9 = 0;
            int cant = 0;

            do
            {
                Console.Write("Ingrese el peso en kg: ");
                peso= float.Parse(Console.ReadLine());

                if( peso <= 10.2 && peso >9.8)
                {
                    entre9_10++;
                }
                else if (peso > 10.2)
                {
                    masDe10++;
                }
                else if (peso < 9.8)
                {
                    if (peso!=0)
                    {
                        menosDe9++;
                    }     
                }
                if (peso!=0)
                {
                    cant++;
                }

            } while (peso!=0);

            Console.WriteLine("Piezas que tienen un peso entre 9.8-10.2 kg son: #"+entre9_10);
            Console.WriteLine("Piezas que tienen un peso mayor a 10.2k g son: #" + masDe10);
            Console.WriteLine("Piezas que tienen un peso menor a 9.8 kg son: #"+menosDe9);
            Console.WriteLine("Cantidad total de piezas procesadas son: #"+cant);

            Console.ReadKey();

        }
    }
}
