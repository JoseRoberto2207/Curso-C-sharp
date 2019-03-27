using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Do_While__Ejercicios_
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). 
            //Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            //int numero = 0;
            //int suma = 0;

            //do
            //{
            //    Console.Write("Ingrese el valor a sumar: ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero!=9999)
            //    {
            //        suma = suma + numero;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ha finalizado la carga");
            //    }

            //} while (numero!=9999);

            //Console.WriteLine("El valor acumulado es: "+suma);

            //if (suma==0)
            //{
            //    Console.WriteLine("El valor de la suma es igual : 0");

            //}else if (suma>0)
            //{
            //    Console.WriteLine("El valor es Positivo");
            //}
            //else if(suma<0)
            //{
            //    Console.WriteLine("El valor es Negativo");
            //}

            //Console.ReadKey();


            //* En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada cuenta corriente se conoce: número de cuenta y saldo actual. 
            //El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            //a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            //Estado de la cuenta 'Acreedor' si el saldo es > 0.
            //'Deudor' si el saldo es<0.
            //'Nulo' si el saldo es = 0.
            //b) La suma total de los saldos acreedores.


            int numCuenta = 0;
            int saldoActual = 0;
            int saldoAcreedor = 0;

            do
            {
                Console.Write("Ingrese el número de cuenta: ");
                numCuenta = int.Parse(Console.ReadLine());

                if (numCuenta>0)
                {
                    Console.Write("Saldo alctual:");
                    saldoActual = int.Parse(Console.ReadLine());

                    if (saldoActual > 0)
                    {
                        Console.WriteLine("Saldo Acreedor");
                        saldoAcreedor = saldoAcreedor + saldoActual;

                    }
                    else if (saldoActual < 0)
                    {
                        Console.WriteLine("Saldo deudor");

                    }
                    else if (saldoActual == 0)
                    {
                        Console.WriteLine("Saldo Nulo");
                    }
                }
            } while (numCuenta>=0);

            Console.WriteLine("Suma total de los Acreedores es: "+saldoAcreedor);



        }
    }
}
