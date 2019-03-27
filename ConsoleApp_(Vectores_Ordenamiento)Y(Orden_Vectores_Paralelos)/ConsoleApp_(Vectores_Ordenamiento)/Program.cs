using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Vectores_Ordenamiento_
{
    //*- Se debe crear un vector donde almacenar 5 sueldos.Ordenar el vector sueldos de menor a mayor.

    //class VectorOrdenamiento
    //{
    //    private int[] vector;
    //    public void CargaVector()
    //    {
    //        int cantidadSueldos;
    //        int valor;

    //        Console.Write("Ingrese cantidad de sueldos: ");
    //        cantidadSueldos = int.Parse(Console.ReadLine());
    //        vector = new int[cantidadSueldos];

    //        for (int i=0; i<vector.Length; i++)
    //        {
    //            Console.Write("Ingrese el sueldo #"+i+": ");
    //            valor = int.Parse(Console.ReadLine());
    //            vector[i] = valor;
    //        }
    //    }

    //    public void OrdenaVector()
    //    {
    //        int aux;
    //        for(int j=0; j<vector.Length; j++) { 

    //            for(int i=0; i<vector.Length-1-j; i++)
    //            {
    //                if (vector[i] > vector[i + 1])
    //                {
    //                    aux = vector[i];
    //                    vector[i] = vector[i + 1];
    //                    vector[i + 1] = aux;
    //                }
    //            }
    //        }
    //    }

    //    public void ImprimirVectorOrdenado()
    //    {
    //        Console.WriteLine("Vector ordenado de menor a mayor: ");
    //        for(int i=0; i<vector.Length; i++)
    //        {
    //            Console.WriteLine(vector[i]);
    //        }

    //        string cad1 = "juan";
    //        string cad2 = "analia";
    //        if (cad1.CompareTo(cad2) > 0)
    //        {
    //            Console.Write(cad1 + " es mayor alfabéticamente que " + cad2);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        VectorOrdenamiento vector = new VectorOrdenamiento();
    //        vector.CargaVector();
    //        vector.OrdenaVector();
    //        vector.ImprimirVectorOrdenado();
    //        Console.ReadKey();
    //    }
    //}

    //*- Definir un vector donde almacenar los nombres de 5 paises.Confeccionar el algoritmo de ordenamiento alfabético.

    //class OrdenAlfabetico
    //{
    //    private string[] vectorAlfabetico;

    //    public void CargaVector()
    //    {
    //        Console.Write("Ingrese cantidad de paises: ");
    //        int cantidadP = int.Parse(Console.ReadLine());

    //        vectorAlfabetico = new string[cantidadP];
    //        Console.WriteLine("---Países---");
    //        for(int i=0; i < vectorAlfabetico.Length; i++)
    //        {
    //            Console.Write("Ingrese el país # "+i+": ");
    //            vectorAlfabetico[i] = Console.ReadLine();
    //        }
    //    }

    //    public void OrdenaVector()
    //    {
    //        string aux;
    //        Console.WriteLine("Vector ordenado Alfabeticamente: ");
    //        for(int j=0; j < vectorAlfabetico.Length; j++) { 

    //            for(int i=0; i<vectorAlfabetico.Length-1-j; i++)
    //            {
    //                if (vectorAlfabetico[i].CompareTo(vectorAlfabetico[i+1]) > 0)
    //                {
    //                    aux = vectorAlfabetico[i];
    //                    vectorAlfabetico[i] = vectorAlfabetico[i + 1];
    //                    vectorAlfabetico[i + 1] = aux;
    //                }       
    //            }
    //        }
    //    }

    //    public void ImprimirVector()
    //    {
    //        for(int i=0; i<vectorAlfabetico.Length; i++)
    //        {
    //            Console.WriteLine(vectorAlfabetico[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        OrdenAlfabetico valor = new OrdenAlfabetico();
    //        valor.CargaVector();
    //        valor.OrdenaVector();
    //        valor.ImprimirVector();
    //        Console.ReadKey();
    //    }
    //}


    //*- Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector.

    //class nElementos{

    //    private int[] vectorN;

    //    public void CargaVector()
    //    {
    //        int cantidadElementos, elementos;
    //        Console.Write("Ingrese la cantidad de: ");
    //        cantidadElementos = int.Parse(Console.ReadLine());

    //        vectorN = new int[cantidadElementos];

    //        for(int i=0; i<vectorN.Length; i++)
    //        {
    //            Console.Write("Ingrese el elemento del vector #"+i+": ");
    //            elementos = int.Parse(Console.ReadLine());
    //            vectorN[i] = elementos;
    //        }
    //    }

    //    public void OrdenaVEctor()
    //    {
    //        for (int j=0; j<vectorN.Length; j++) {
    //            for (int i=0; i < vectorN.Length -1 -j; i++)
    //            {
    //                if (vectorN[i] < vectorN[i + 1])
    //                {
    //                    int aux = vectorN[i];
    //                    vectorN[i] = vectorN[i + 1];
    //                    vectorN[i + 1] = aux;
    //                }
    //            }
    //        }
    //    }

    //    public void ImprimeVector()
    //    {
    //        Console.WriteLine("Vector ordenado de mayor a menor: ");
    //        for(int i=0; i<vectorN.Length; i++)
    //        {
    //            Console.WriteLine(vectorN[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        nElementos elemento = new nElementos();
    //        elemento.CargaVector();
    //        elemento.OrdenaVEctor();
    //        elemento.ImprimeVector();
    //        Console.ReadKey();
    //    }
    //}


    /*----------------------Vectores (ordenamiento con vectores paralelos)-------------------*/
    //*- Confeccionar un programa que permita cargar los nombres de 5 alumnos y sus notas respectivas.
    //Luego ordenar las notas de mayor a menor.Imprimir las notas y los nombres de los alumnos.

    //class OrdenamientoParalelo
    //{
    //    private string[] vectorAlumnos;
    //    private int[] vectorNotas;

    //    public void CargaVectores()
    //    {
    //        int cantidadAlumnos;
    //        string nombreAlumno;
    //        int notaAlumno;

    //        Console.Write("Ingrese cantidad de alumnos: ");
    //        cantidadAlumnos = int.Parse(Console.ReadLine());

    //        vectorAlumnos = new string[cantidadAlumnos];
    //        vectorNotas = new int[cantidadAlumnos];
    //        for(int i=0; i<vectorAlumnos.Length; i++)
    //        {
    //            Console.Write("*Ingrese el nombre del alumno: ");
    //            nombreAlumno = Console.ReadLine();
    //            vectorAlumnos[i] = nombreAlumno;

    //            Console.Write(" -Ingrese la nota del alumno: ");
    //            notaAlumno = int.Parse(Console.ReadLine());
    //            vectorNotas[i] = notaAlumno;
    //        }
    //    }

    //    public void OrdenaVectores()
    //    {
    //        for (int j=0; j<vectorNotas.Length; j++) {
    //            for (int i = 0; i < vectorNotas.Length -1-j; i++)
    //            {
    //                if (vectorNotas[i] < vectorNotas[i + 1])
    //                {
    //                    int aux = vectorNotas[i];
    //                    vectorNotas[i] = vectorNotas[i + 1];
    //                    vectorNotas[i + 1] = aux;

    //                    string aux2 = vectorAlumnos[i];
    //                    vectorAlumnos[i] = vectorAlumnos[i + 1];
    //                    vectorAlumnos[i + 1] = aux2;
    //                }
    //            }
    //        }
    //        Console.WriteLine();
    //    }

    //    public void ImprimirVectores()
    //    {
    //        Console.WriteLine("Vectores ordenados de mayor a menor: ");
    //        for(int i=0; i<vectorNotas.Length; i++)
    //        {
    //            Console.WriteLine("Alumno: "+vectorAlumnos[i]);
    //            Console.WriteLine("Nota: " + vectorNotas[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        OrdenamientoParalelo orden = new OrdenamientoParalelo();
    //        orden.CargaVectores();
    //        orden.OrdenaVectores();
    //        orden.ImprimirVectores();
    //        Console.ReadKey();
    //    }
    //}

    //*- Cargar en un vector los nombres de 5 paises y en otro vector paralelo la cantidad de habitantes del mismo. Ordenar alfabéticamente e imprimir los resultados.
    //Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.

    class DobleOrdenamiento
    {
        private string[] vectorPaises;
        private int[] vectorHabitantes;

        public void CargaVectores()
        {
            int cantidadPaises;
            string paises;
            int habitantes;
     
            Console.Write("Ingrese cantidad de países: ");
            cantidadPaises = int.Parse(Console.ReadLine());
            vectorPaises = new string[cantidadPaises];
            vectorHabitantes = new int[cantidadPaises];

            for(int i=0; i < vectorPaises.Length; i++)
            {
                Console.Write("Ingrese el país:  ");
                paises = Console.ReadLine();
                vectorPaises[i] = paises;
                Console.Write("Ingrese los habitantes: ");
                habitantes = int.Parse(Console.ReadLine());
                vectorHabitantes[i] = habitantes;
            }
        }
        public void OrdenAlfabetico()
        {
            for (int j=0; j<vectorPaises.Length; j++) {
                for (int i = 0; i < vectorPaises.Length -1-j; i++)
                {
                    if (vectorPaises[i].CompareTo(vectorPaises[i + 1]) > 0)
                    {
                        string aux = vectorPaises[i];
                        vectorPaises[i] = vectorPaises[i + 1];
                        vectorPaises[i + 1] = aux;

                        int aux2 = vectorHabitantes[i];
                        vectorHabitantes[i] = vectorHabitantes[i + 1];
                        vectorHabitantes[i + 1] = aux2;
                    }
                }
            }
        }
        public void ImprimirOrdenAlfabetico()
        {
            Console.WriteLine();
            Console.WriteLine("Vector ordenado alfabéticamente: ");
            for(int i=0; i<vectorPaises.Length; i++)
            {
                Console.WriteLine("País: "+vectorPaises[i]);
                Console.WriteLine("Habitantes: "+vectorHabitantes[i]);
            }
        }
        public void OrdenHabitantes()
        {
            for (int j=0; j<vectorHabitantes.Length; j++) {
                for (int i = 0; i < vectorHabitantes.Length-1-j; i++)
                {
                    if (vectorHabitantes[i] < vectorHabitantes[i + 1])
                    {
                        int aux = vectorHabitantes[i];
                        vectorHabitantes[i] = vectorHabitantes[i + 1];
                        vectorHabitantes[i + 1] = aux;
                        string aux2 = vectorPaises[i];
                        vectorPaises[i] = vectorPaises[i + 1];
                        vectorPaises[i + 1] = aux2;
                    }
                }
            }
        }
        public void ImprirHabitantes()
        {
            Console.WriteLine();
            Console.WriteLine("Vector ordenado de mayor a menor #habitantes: ");
            for(int i=0; i<vectorHabitantes.Length; i++)
            {
                Console.WriteLine("Habitantes: " + vectorHabitantes[i]);
                Console.WriteLine("País: "+vectorPaises[i]);
            }
        }
        static void Main(string[] args)
        {
            DobleOrdenamiento vectores = new DobleOrdenamiento();
            vectores.CargaVectores();
            vectores.OrdenAlfabetico();
            vectores.ImprimirOrdenAlfabetico();
            vectores.OrdenHabitantes();
            vectores.ImprirHabitantes();
            Console.ReadKey();
        }
    }
}




