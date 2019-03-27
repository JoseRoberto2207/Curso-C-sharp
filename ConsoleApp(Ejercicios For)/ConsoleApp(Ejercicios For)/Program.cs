using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ejercicios_For_
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente la suma de los valores ingresados y su promedio.

            //int suma = 0;
            //int valor = 0;
            //int contador = 0;
            //int promedio = 0;

            //for(int i =1; i<=10; i++)
            //{
            //    Console.Write("Ingrese el valor #"+i+": ");
            //    valor= int.Parse(Console.ReadLine());

            //    suma = suma + valor;
            //    contador++;

            //    promedio = suma / contador;
            //}

            //Console.WriteLine("La suma de los valores ingresados es: "+suma);
            //Console.WriteLine("EL promedio de los valores ingresados es: "+promedio);
            //Console.ReadKey();


            //* Escribir un programa que lea 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.

            //int numNotas = 0;
            //int notasMayores = 0;
            //int notasMenores = 0;

            //for(int i=1; i<=10; i++)
            //{
            //    Console.Write("Ingrese la nota de alumno #"+i+": ");
            //    numNotas = int.Parse(Console.ReadLine());

            //    if (numNotas >= 7)
            //    {
            //        notasMayores++;
            //    }
            //    else
            //    {
            //        notasMenores++;
            //    }
            //}

            //Console.WriteLine("Los alumnos que tienen notas mayores o iguales a 7 son: "+notasMayores);
            //Console.WriteLine("Los alumnos que tienen notas menores a 7 son: "+notasMenores);
            //Console.ReadKey();


            //* Escribir un programa que lea 10 números enteros y luego muestre cuántos valores ingresados fueron múltiplos de 3 y 
            //cuántos de 5.Debemos tener en cuenta que hay números que son múltiplos de 3 y de 5 a la vez.

            //int numeros = 0;
            //int multiplos3 = 0;
            //int multiplos5 = 0;

            //for (int i=1; i<=10; i++)
            //{
            //    Console.Write("Ingrese el número entero #"+i+": ");
            //    numeros = int.Parse(Console.ReadLine());

            //    if(numeros % 3 == 0)
            //    {
            //        multiplos3++;
            //    }
            //    if (numeros % 5 == 0)
            //    {
            //        multiplos5++;
            //    }

            //}

            //Console.WriteLine("Los números ingresados múltiplos de 3 son: " + multiplos3);
            //Console.WriteLine("Los números ingresados múltilos de 5 son: " + multiplos5);
            //Console.ReadKey();


            //* Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.

            //int cont = 0;

            //Console.Write("Ingrese cantidad de números a procesar: ");
            //int numeros = int.Parse(Console.ReadLine());

            //for (int i=1; i<=numeros; i++)
            //{
            //    Console.Write("Ingrese el #"+i+": ");
            //    int numIngresado=int.Parse(Console.ReadLine());

            //    if (numIngresado >= 1000)
            //    {
            //        cont++;
            //    }
            //}

            //Console.WriteLine("La cantidad de números mayores o igual a 1000 son: "+cont);
            //Console.ReadKey();



            /*------------------------Problemas_Propuestos-------------------------*/

            //1.- Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y la altura de un triángulo. 
            //El programa deberá informar:
            //a) De cada triángulo la medida de su base, su altura y su superficie.
            //b) La cantidad de triángulos cuya superficie es mayor a 12.

            //int num1 = 0;
            //int num2 = 0;
            //int mayores12 = 0;
            //int superficie = 0;

            //Console.Write("Ingrese cantidad de pares de números: ");
            //int cantidadNum = int.Parse(Console.ReadLine());

            //for (int i=1; i<=cantidadNum; i++)
            //{
            //    Console.Write("Ingrese el número 1: ");
            //    num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Ingrese el número 2: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    superficie = (num1 * num2 / 2);

            //    Console.WriteLine("La base del triángulo es: "+num1);
            //    Console.WriteLine("La altura del triángulo es: "+num2);
            //    Console.WriteLine("La superficie del triángulo es: "+superficie);

            //    if (superficie > 12)
            //    {
            //        mayores12++;
            //    }
            //}

            //Console.WriteLine("La cantidad de triángulos cuya superficie es mayor a 12 son: "+mayores12);
            //Console.ReadLine();


            //2.- Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.

            //int sumaUltimos5 = 0;

            //for (int i=1; i<=10; i++)
            //{
            //    Console.Write("Ingrese el número "+i+": ");
            //    int numIngresado = int.Parse(Console.ReadLine());

            //    if (i>=5)
            //    {
            //        sumaUltimos5 = sumaUltimos5 + numIngresado;
            //    }
            //}

            //Console.WriteLine("La suma de los últimos 5 valores ingresados es: "+sumaUltimos5);
            //Console.ReadKey();


            //3.- Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)

            //int tabla5 = 5;

            //for(int i=5; i<=50; i++)
            //{
            //    Console.Write(tabla5*i);
            //    Console.Write("-");
            //}
            //Console.ReadKey();


            //4.- Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla de multiplicar del mismo (los primeros 12 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 36.

            //int numIngresado;

            //do
            //{
            //    Console.Write("Ingrese un valor de entre 1-10: ");
            //    numIngresado = int.Parse(Console.ReadLine());

            //} while (numIngresado<=0 || numIngresado>10);

            //for (int i=1; i<=12; i++)
            //{
            //    Console.WriteLine(numIngresado*i);
            //}
            //Console.ReadKey();


            // 5.- Realizar un programa que lea los lados de n triángulos, e informar:
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.

            int cantidadTriangulos;
            int lado1;
            int lado2;
            int lado3;
            int cantidadEquilatero = 0;
            int cantidadIsosceles = 0;
            int cantidadEscaleno = 0;
         
            Console.Write("Ingrese cantidad de triángulos a analizar: ");
            cantidadTriangulos= int.Parse(Console.ReadLine());

            for(int i=1; i<=cantidadTriangulos; i++)
            {
                Console.Write(" -Ingrese el primer lado del triángulo #"+i+": ");
                lado1= int.Parse(Console.ReadLine());
                Console.Write(" -Ingrese el segundo lado del triángulo #"+i+": ");
                lado2 = int.Parse(Console.ReadLine());
                Console.Write(" -Ingrese el tercer lado del triángulo #"+i+": ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1==lado2 && lado1==lado3 && lado2==lado3)
                {
                    Console.WriteLine("*El triángulo #"+i+" es un triángulo equilátero");
                    cantidadEquilatero++;

                }else if (lado1==lado2 || lado1==lado3 || lado2==lado3)
                {
                    Console.WriteLine("*El triángulo #"+i+" es un triángulo isósceles");
                    cantidadIsosceles++;
                }
                else
                {
                    Console.WriteLine("*El triángulo #"+i+" es un triángulo escaleno");
                    cantidadEscaleno++;
                }
            }

            Console.WriteLine("Triángulos Equiláteros: " + cantidadEquilatero);
            Console.WriteLine("Triángulos Isósceles: " + cantidadIsosceles);
            Console.WriteLine("Triángulos Escalenos: " + cantidadEscaleno);

            if (cantidadEquilatero<cantidadIsosceles && cantidadEquilatero<cantidadEscaleno)
            {
                Console.WriteLine("El tipo de trángulo con menor cantidad fue: Equilátero");
                  
            }else if (cantidadIsosceles<cantidadEquilatero && cantidadIsosceles<cantidadEscaleno)
            {
                Console.WriteLine("El tipo de triángulo con menor cantidad fue: Isósceles");

            } else if (cantidadEquilatero==cantidadIsosceles)
            {
                Console.WriteLine("El tipo de triángulo con menor cantidad fue: Equilátero e Isósceles");

            }else if (cantidadEquilatero == cantidadEscaleno)
            {
                Console.WriteLine("El tipo de triángulo con menor cantidad fue: Equilátero y Escaleno");

            }else if (cantidadIsosceles == cantidadEscaleno)
            {
                Console.WriteLine("El triángulo con menor cantidad fue: Isósceles y Escaleno");
            }
            else
            {
                Console.WriteLine("El tipo de triángulo con menor cantidad fue: Escaleno");
            }

            Console.ReadKey();

            




        }
    }
}
