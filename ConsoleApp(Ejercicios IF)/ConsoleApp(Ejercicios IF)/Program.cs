using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ejercicios_IF_
{
    class Program
    {
        static void Main(string[] args)
        {

            //*- Confeccionar un programa que pida por teclado tres notas de un alumno, calcule el promedio e imprima alguno de estos mensajes:
            //Si el promedio es >= 7 mostrar "Promocionado".
            //Si el promedio es >= 4 y < 7 mostrar "Regular".
            //Si el promedio es<4 mostrar "Reprobado".

            //int promedio = 0;

            //Console.Write("Ingrese la primera nota: ");
            //int nota1 = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese la segunda nota: ");
            //int nota2 = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese la tercera nota: ");
            //int nota3 = int.Parse(Console.ReadLine());

            //promedio = (nota1 + nota2 + nota3) / 3;

            //if (promedio>=7)
            //{
            //    Console.WriteLine("Promocionado");
            //}
            //else
            //{
            //    if (promedio >= 4 && promedio < 7)
            //    {
            //        Console.WriteLine("Regular");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprobado");
            //    }
            //}
            //Console.ReadKey();


            //*- Se cargan por teclado tres números distintos.Mostrar por pantalla el mayor de ellos.

            //Console.Write("Ingrese el primer número: ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Ingrese el segundo número:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese el tercer número: ");
            //int num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("El número mayor es: "+num1);

            //}else
            //{
            //    if (num2 > num1 && num2 > num3 )
            //    {
            //        Console.WriteLine("El número mayor es: "+num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número mayor es: "+num3);
            //    }
            //}
            //Console.ReadKey();


            //*- Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: cantidad total de preguntas que se le realizaron 
            //y la cantidad de preguntas que contestó correctamente. Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel 
            //del mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
            //Nivel máximo:	Porcentaje >= 90 %.
            //Nivel medio:	Porcentaje >= 75 % y < 90 %.
            //Nivel regular:	Porcentaje >= 50 % y < 75 %.
            //Fuera de nivel: Porcentaje < 50 %.

            float porcentaje;

            Console.Write("Ingrese cantidad total de preguntas: ");
            float cantidadPreguntas = float.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad preguntas contestadas correctamente: ");
            float preguntasCorrectas = float.Parse(Console.ReadLine());

            porcentaje = (preguntasCorrectas/ cantidadPreguntas);
            Console.WriteLine(porcentaje);

            if (porcentaje >= 0.9)
            {
                Console.WriteLine("Nivel máximo");

            } else if (porcentaje>=0.75 && porcentaje<0.90)
            {
                Console.WriteLine("Nivel medio");

            }else if (porcentaje>=0.50 && porcentaje<0.75)
            {
                Console.WriteLine("Nivel regular");
            }
            else
            {
                Console.WriteLine("Fuera de nivel");
            }
            Console.ReadKey();

            










        }
    }
}
