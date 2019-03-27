using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Suma(1, 2));
            
        }

        static int Suma(int num1, int num2) => num1 + num2;
        static int Suma(int num1, int num2,int num3) => num1 + num2;



        //sumaNumeros(5, 10);
        //Console.WriteLine(sumaNumeros(500, 200));

        //static int sumaNumeros(int num1, int num2)
        //{
        //    int resultado = num1 + num2;
        //    //Console.WriteLine(resultado);
        //    return resultado;
        //}

        //static void sumaNumero()
        //{
        //    int num1 = 7;
        //    int num2 = 9;
        //    int resultado = num1 + num2;
        //    Console.WriteLine(resultado);
        //}



        /*---------------------------*/

        //const double PI = 3.1416;
        //Console.WriteLine("Introduce el radio del círculo a calcular:");
        //double radio = double.Parse(Console.ReadLine());

        ////double area = (radio * radio) * PI;
        //double area = Math.Pow(radio,2)*PI;
        //Console.WriteLine("El  área del circulo es: " + area);


        //int a = 5;
        //int b = 10;
        //Console.WriteLine("El valor de la constante es: {0}", a);
        //Console.WriteLine($"El valor de la constante es: {b}");

        // var a = 5;
        //Console.WriteLine(a);



    }
}
