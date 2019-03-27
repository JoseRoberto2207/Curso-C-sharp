using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__MétodosConParámetros_
{
    //Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. 
    //Finalizar el programa al ingresar el -1.


    //class TablaMultiplicar
    //{
    //    public void IngresaDatos()
    //    {
    //        int valor;
    //        do
    //        {
    //            Console.Write("Ingrese un valor entero (-1 para finalizar): ");
    //            valor = int.Parse(Console.ReadLine());

    //            if (valor != -1)
    //            {
    //                CalculoTabla(valor);
    //            }
    //        } while (valor != -1);
    //    }

    //    public void CalculoTabla(int v)
    //    {
    //        for(int i=v; i<=v*10; i=i+v)
    //        {
    //            Console.Write(i+"-");
    //        }
    //        Console.WriteLine();
    //    }

    //    static void Main(string[] args)
    //    {
    //        TablaMultiplicar multiplicar1 = new TablaMultiplicar();
    //        multiplicar1.IngresaDatos();
    //    }
    //}


    //Confeccionar una clase que permita ingresar tres valores por teclado.Luego mostrar el mayor y el menor.


    class Numeros
    {
        public void CalculaNumeros()
        {
            int mayor, menor;

            Console.Write("Ingresa el primer valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer valor: ");
            int num3 = int.Parse(Console.ReadLine());

            mayor = CalculaMayor(num1, num2, num3);
            menor = CalculaMenor(num1, num2, num3);

            Console.WriteLine("El número mayor es: "+mayor);
            Console.WriteLine("El número menor es: "+menor);
        }

        public int CalculaMayor(int v1, int v2, int v3)
        {
            int m;
            if (v1 > v2 && v1 > v3)
            {
                m = v1;
            }
            else
            {
                if (v2 > v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        public int CalculaMenor(int v1, int v2, int v3)
        {
            int m;
            if (v1 < v2 && v1 < v3)
            {
                m = v1;
            }
            else
            {
                if (v2 < v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        static void Main(string [] args)
        {
            Numeros numero1 = new Numeros();
            numero1.CalculaNumeros();
            Console.ReadKey();
        }
    }










}
