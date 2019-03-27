using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un Número positivo:");
            int numeroPositivo = int.Parse(Console.ReadLine());

            do
            {
                if (numeroPositivo > 0)
                {

                    if (numeroPositivo % 2 == 0)
                    {
                        Console.WriteLine($"El número: {numeroPositivo} es Par");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El Número: "+numeroPositivo+" es Impar");
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un Número valido:");
                    numeroPositivo = int.Parse(Console.ReadLine());
                    Console.ReadKey();

                    if (numeroPositivo > 0)
                    {
                        if (numeroPositivo % 2 == 0)
                        {
                            Console.WriteLine($"El número: {numeroPositivo} es Par");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("El Número: " + numeroPositivo + " es Impar");
                            Console.ReadKey();
               
                        }
                    }
                }
            } while (numeroPositivo<=1);


            /*double temperatura = 35.9;
            int intemperatura;


            int a = 1000;
            long b = a;

            intemperatura = (int)temperatura;

            Console.WriteLine(intemperatura+b);
            Console.ReadKey();*/

                        /*int i = 0;

                        do{
                            Console.WriteLine("A");

                            i = i + 1;

                        } while (i<=10);

                        Console.ReadKey();*/
        }
    }
}
