using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Vectores_Paralelos_
{

    //*- Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. 
    //Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años).

    //class VectorParalelo
    //{

    //    private string[] vectorNombres;
    //    private int[] vectorEdades;

    //    public void CargaVectores()
    //    {
    //        string nombres;
    //        int edades;

    //        vectorNombres = new string[5];
    //        vectorEdades = new int[5];

    //        Console.WriteLine("---Nombres---");
    //        for (int i = 0; i < vectorNombres.Length; i++)
    //        {
    //            Console.Write("Ingrese los nombres: ");
    //            nombres = Console.ReadLine();
    //            vectorNombres[i] = nombres;
    //        }
    //        Console.WriteLine("---Edades---");
    //        for (int i = 0; i < vectorEdades.Length; i++)
    //        {
    //            Console.Write("Ingrese las edades: ");
    //            edades = int.Parse(Console.ReadLine());
    //            vectorEdades[i] = edades;
    //        }
    //    }

    //    public void ImprimirNombres()
    //    {
    //        Console.WriteLine("Personas cuyas edades son mayores o iguales a 18: ");
    //        for (int i = 0; i < vectorNombres.Length; i++)
    //        {
    //            if (vectorEdades[i] >= 18)
    //            {
    //                Console.WriteLine(vectorNombres[i]);
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        VectorParalelo vector = new VectorParalelo();
    //        vector.CargaVectores();
    //        vector.ImprimirNombres();
    //        Console.ReadKey();
    //    }
    //}


    /*----------------------Vector (mayor y menor elemento)----------------------------*/

    //*- Confeccionar un programa que permita cargar los nombres de 5 operarios y sus sueldos respectivos. Mostrar el sueldo mayor y el nombre del operario.

    //class MayorElemento
    //{
    //    private string[] vectorNombres;
    //    private int[] vectorSueldos;
    //    private string nombre;
    //    private int sueldo;

    //    public void CargaVectores()
    //    {
    //        vectorNombres = new string[5];
    //        vectorSueldos = new int[5];

    //        Console.WriteLine("---Nombres---");
    //        for (int i = 0; i < vectorNombres.Length; i++)
    //        {
    //            Console.Write("Ingrese el nombre: ");
    //            nombre = Console.ReadLine();
    //            vectorNombres[i] = nombre;
    //        }
    //        Console.WriteLine("---Edades---");
    //        for(int i=0; i < vectorSueldos.Length; i++)
    //        {
    //            Console.Write("Ingrese el sueldo: ");
    //            sueldo = int.Parse(Console.ReadLine());
    //            vectorSueldos[i] = sueldo;
    //        }
    //    }

    //    public void Imprimir()
    //    {
    //        int mayor;
    //        int pos=0;
    //        mayor = vectorSueldos[0];

    //        for (int i = 1; i < vectorNombres.Length; i++)
    //        {
    //            if (vectorSueldos[i] > mayor)
    //            {
    //                mayor = vectorSueldos[i];
    //                pos = i;
    //            }
    //        }
    //        Console.WriteLine("El empleado con sueldo mayor es: " + vectorNombres[pos]);
    //        Console.WriteLine("Tiene un sueldo de: " + mayor);
    //    }

    //    static void Main(string[] args)
    //    {
    //        MayorElemento elemento = new MayorElemento();
    //        elemento.CargaVectores();
    //        elemento.Imprimir();
    //        Console.ReadKey();
    //    }
    //}

    //*- Cargar un vector de n elementos.imprimir el menor y un mensaje si se repite dentro del vector.

    class VectorMenor{

        private int[] vector;
        private int menor;

        public void CargaVector()
        {
            int tamañoVector, elemento;

            Console.Write("Ingrese tamaño de vector: ");
            tamañoVector = int.Parse(Console.ReadLine());

            vector = new int[tamañoVector];
            for(int i=0; i<vector.Length; i++)
            {
                Console.Write("Ingrese el elemento #"+i+": ");
                elemento = int.Parse(Console.ReadLine());
                vector[i] = elemento;
            }
        }

        public void ImprimirMenor()
        {
            menor = vector[0];
            int i;

            for(i=1; i<vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            Console.WriteLine("El número menor es: "+menor);
        }

        public void NumMenor()
        {
            int cant = 0;

            for(int i=0; i<vector.Length; i++)
            {
                if (vector[i] == menor)
                {
                    cant++;
                }
            }

            if (cant > 1)
            {
                Console.WriteLine("El número se repite en el vector");
            }
            else
            {
                Console.WriteLine("No se repite el número");
            }
        }

        static void Main(string[] args)
        {
            VectorMenor vector = new VectorMenor();
            vector.CargaVector();
            vector.ImprimirMenor();
            vector.NumMenor();
            Console.ReadKey();
        }

    }


}
