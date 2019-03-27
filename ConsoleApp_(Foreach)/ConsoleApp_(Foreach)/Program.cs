using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Foreach_
{
    //*- Almacenar los sueldos de 5 operarios en un vector, imprimir los elementos recorriendo el vector con la estructura repetitiva foreach.

    //class Foreach1
    //{
    //    private int[] vector;

    //    public void CargaVector()
    //    {
    //        int cantidadSueldos, sueldosVector;

    //        Console.Write("Ingrese cantidad de sueldos a guardar: ");
    //        cantidadSueldos = int.Parse(Console.ReadLine());

    //        vector = new int[cantidadSueldos];
    //        for(int i=0; i < vector.Length; i++)
    //        {
    //            Console.Write("Ingrese elemento #"+i+": ");
    //            sueldosVector = int.Parse(Console.ReadLine());
    //            vector[i] = sueldosVector;
    //        }
    //    }
    //    public void ImprimirVector()
    //    {
    //        Console.WriteLine("Impresión vector: ");
    //        foreach(int v in vector)
    //        {
    //            Console.WriteLine(v);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Foreach1 vector = new Foreach1();
    //        vector.CargaVector();
    //        vector.ImprimirVector();
    //        Console.ReadKey();
    //    }
    //}


    //*- Crear un vector de n elementos de tipo entero(n se ingresa por teclado) Mostrar cuantos elementos son superiores a 100 (emplear el foreach para recorrer el vector)

    class Foreach2 {

        private int[] vector;

        public void CargaVector()
        {
            int cantidadElementos, elemento;

            Console.Write("Ingrese cantidad de elementos: ");
            cantidadElementos = int.Parse(Console.ReadLine());
            vector = new int[cantidadElementos];

            for(int i=0; i<vector.Length; i++)
            {
                Console.Write("Ingrese elemento #"+i+": ");
                elemento = int.Parse(Console.ReadLine());
                vector[i] = elemento;
            }
        }
        public void ImprimirVector()
        {
            int cont = 0;

            foreach(int v in vector)
            {
                if (v > 100)
                {
                    cont++;
                }
            }
            Console.WriteLine("Elementos superiores a 100: "+cont);
        }
        static void Main()
        {
            Foreach2 vector = new Foreach2();
            vector.CargaVector();
            vector.ImprimirVector();
            Console.ReadKey();      
        }
    }
}
