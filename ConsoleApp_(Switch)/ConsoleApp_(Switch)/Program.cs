using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Switch_
{
    //*- Ingresar un valor entero entre 1 y 5. Luego mostrar en castellano el valor ingresado.Si se ingresa un valor fuera de dicho rango mostrar un mensaje 
    //indicando tal situación

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int valor;

    //        Console.Write("Ingrese un valor de entre 1-5: ");
    //        valor = int.Parse(Console.ReadLine());

    //        switch (valor)
    //        {
    //            case 1:
    //                Console.WriteLine("Uno");
    //                break;
    //            case 2:
    //                Console.WriteLine("Dos");
    //                break;
    //            case 3:
    //                Console.WriteLine("Tres");
    //                break;
    //            case 4:
    //                Console.WriteLine("Cuatro");
    //                break;
    //            case 5:
    //                Console.WriteLine("Cinco");
    //                break;
    //            default:
    //                Console.WriteLine("Número fuera del rango");
    //                break;
    //        }
    //    }
    //}


    //*- Ingresar un número entre uno y cinco en castellano. Luego mostrar en formato numérico. Si se ingresa un valor fuera de dicho rango mostrar un mensaje
    //indicando tal situación

    class Switch
    {
        static void Main(string[] args)
        {
            string valor;

            Console.Write("Ingrese un número entre 1-5 en castellano: ");
            valor = Console.ReadLine();
            
            switch (valor)
            {
                case "uno":
                    Console.WriteLine("1");
                    break;
                case "dos":
                    Console.WriteLine("2");
                    break;
                case "tres":
                    Console.WriteLine("3");
                    break;
                case "cuatro":
                    Console.WriteLine("4");
                    break;
                case "cinco":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Número fuera del rango");
                    break;
            }
        }
    }
}
