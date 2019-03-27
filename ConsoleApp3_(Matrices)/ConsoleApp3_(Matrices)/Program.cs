using System;

namespace ConsoleApp3__Matrices_
{
    //--------------------------Estructura de datos tipo matriz-----------------------
    //1.- Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes y luego imprimirlas.

    //class Matriz1
    //{
    //    private int[,] matriz;
    //    private int filas, columnas;

    //    public void CargaMatriz()
    //    {
    //        int valores;

    //        Console.Write("Ingrese #Filas: ");
    //        filas = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Ingrese #Columnas: ");
    //        columnas = Convert.ToInt32(Console.ReadLine());

    //        matriz = new int[filas, columnas];

    //        for(int f=0; f<filas; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.Write("*-Ingrese valor fila #" +f+ " columna #" +c+": ");
    //                valores= int.Parse(Console.ReadLine());
    //                matriz[f, c] = valores;
    //            }
    //        }
    //    }
    //    public void ImprimirMatriz()
    //    {
    //        for(int f=0; f<filas; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.Write(matriz[f,c]+" ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matriz1 mat = new Matriz1();
    //        mat.CargaMatriz();
    //        mat.ImprimirMatriz();
    //        Console.ReadKey();
    //    }
    //}


    //2.- Crear y cargar una matriz de 4 filas por 4 columnas. Imprimir la diagonal principal.


    //class Matriz2
    //{
    //    private int filas, columnas;
    //    private int[,] matriz;

    //    public void CargaMatriz()
    //    {
    //        Console.Write("Ingrese #Filas: ");
    //        filas = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese #Columnas: ");
    //        columnas = int.Parse(Console.ReadLine());

    //        matriz = new int[filas, columnas];

    //        for(int f=0; f < filas; f++)
    //        {
    //            for(int c=0; c < columnas; c++)
    //            {
    //                Console.Write("Ingrese la fila #"+f+" y columna #"+c+": ");
    //                int valores= Convert.ToInt32(Console.ReadLine());
    //                matriz[f, c] = valores;
    //            }
    //        }
    //    }
    //    public void ImprimeMatriz()
    //    {
    //        for(int f=0; f < filas; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.Write(matriz[f,c]+" ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    public void ImprimirDiagonal()
    //    {    
    //        for(int c=0; c<columnas; c++)
    //        {
    //            Console.WriteLine(matriz[c,c]+" ");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matriz2 mat = new Matriz2();
    //        mat.CargaMatriz();
    //        mat.ImprimeMatriz();
    //        mat.ImprimirDiagonal();
    //        Console.ReadKey();
    //    }
    //}


    //3.- Crear y cargar una matriz de 3 filas por 4 columnas. Imprimir la primer fila. Imprimir la última fila e imprimir la primer columna.

    //class Matriz3
    //{
    //    private int filas, columnas;
    //    private int[,] matriz;

    //    public void CargaMatriz()
    //    {
    //        Console.Write("Ingrese #Filas: ");
    //        filas = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese #Columnas: ");
    //        columnas = int.Parse(Console.ReadLine());

    //        matriz = new int[filas, columnas];

    //        for(int f=0; f<filas; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.Write("Ingrese fila #"+f+" y columna #"+c+": ");
    //                int valores = int.Parse(Console.ReadLine());
    //                matriz[f, c] = valores;
    //            }
    //        }
    //    }
    //    public void ImprimirMatriz()
    //    {
    //        for(int f=0; f<filas; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.Write(matriz[f,c]+" ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    public void ImprimirPartes()
    //    {
    //        Console.WriteLine("Primer fila: ");
    //        for(int f=0; f<1; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.WriteLine(matriz[f,c]);
    //            }
    //        }
    //        Console.WriteLine("Última fila: ");
    //        for(int f=0; f<filas; f++)
    //        {
    //            for (int c = 0; c < columnas; c++)
    //            {
    //                if (f == filas-1)
    //                {
    //                    Console.WriteLine(matriz[f, c]);
    //                }  
    //            }
    //        }
    //        Console.WriteLine("Primer columna: ");
    //        for(int c=0; c<1; c++)
    //        {
    //            for(int f=0; f<filas; f++)
    //            {
    //                Console.WriteLine(matriz[f,c]);
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matriz3 mat = new Matriz3();
    //        mat.CargaMatriz();
    //        mat.ImprimirMatriz();
    //        mat.ImprimirPartes();
    //        Console.ReadKey();
    //    }
    //}


    //Crear una matriz de 2 filas y 5 columnas.Realizar la carga de componentes por columna(es decir primero ingresar toda la primer columna, luego la segunda columna y 
    //así sucesivamente). Imprimir luego la matriz.

    //public class Matriz4
    //{
    //    private int filas, columnas;
    //    private int[,] matriz;

    //    public void CargaMatriz()
    //    {
    //        Console.Write("Ingrese #Filas: ");
    //        filas = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese #Columnas: ");
    //        columnas = int.Parse(Console.ReadLine());

    //        matriz = new int[filas, columnas];
    //        for(int c=0; c<columnas; c++)
    //        {
    //            for(int f=0; f<filas; f++)
    //            {
    //                Console.Write("Ingrese columna #"+c+" y fila #"+f+": ");
    //                int valores = Convert.ToInt32(Console.ReadLine());
    //                matriz[f,c] = valores;
    //            }
    //        }
    //    }
    //    public void ImprimirMatriz()
    //    {
    //        for(int f=0; f < filas; f++)
    //        {
    //            for(int c=0; c<columnas; c++)
    //            {
    //                Console.Write(matriz[f,c]+" ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matriz4 mat = new Matriz4();
    //        mat.CargaMatriz();
    //        mat.ImprimirMatriz();
    //        Console.ReadKey();
    //    }
    //}


    //-----------------------------Matrices (cantidad de filas y columnas)--------------------------------

    //1.-Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila.

    //class Matrices1
    //{
    //    private int n, m;
    //    private int[,] matriz;

    //    public void CargaMatriz()
    //    {
    //        Console.Write("Ingrese #filas: ");
    //        n = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese #columnas: ");
    //        m = int.Parse(Console.ReadLine());

    //        matriz = new int[n, m];

    //        for(int n=0; n < matriz.GetLength(0); n++)
    //        {
    //            for(int m=0; m<matriz.GetLength(1); m++)
    //            {
    //                Console.Write("Ingresar fila #"+n+" y columna #"+m+": ");
    //                int valores = int.Parse(Console.ReadLine());
    //                matriz[n, m] = valores;
    //            }
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        Console.WriteLine("Matriz completa: ");
    //        for(int n=0; n<matriz.GetLength(0); n++)
    //        {
    //            for (int m = 0; m < matriz.GetLength(1); m++)
    //            {
    //                Console.Write(matriz[n, m]+" ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.WriteLine("Última fila: ");

    //        for (int m = 0; m < matriz.GetLength(1); m++)
    //        {
    //            if (n == matriz.GetLength(0))
    //            {
    //                Console.Write(matriz[matriz.GetLength(0) - 1, m] + " ");
    //            }
    //        }    
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matrices1 mat = new Matrices1();
    //        mat.CargaMatriz();
    //        mat.Imprimir();
    //        Console.ReadKey();
    //    }
    //}

    //2.- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir el mayor elemento y la fila y columna donde se almacena.

    //class Matrices2
    //{
    //    private int n,m;
    //    private int[,] matriz;

    //    public void CargaMatriz()
    //    {
    //        Console.Write("Ingrese #filas: ");
    //        n = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese #columnas: ");
    //        m = int.Parse(Console.ReadLine());

    //        matriz = new int[n, m];

    //        for(int f=0; f < matriz.GetLength(0); f++)
    //        {
    //            for(int c=0; c<matriz.GetLength(1); c++)
    //            {
    //                Console.Write("Ingrese los valores en la fila #"+f+" columna #"+c+": ");
    //                int valores = int.Parse(Console.ReadLine());
    //                matriz[f, c] = valores;
    //            }
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        int mayor = matriz[0, 0];
    //        int fila=0, columna=0;
    //        for(int f=0; f < matriz.GetLength(0); f++)
    //        {
    //            for(int c=0; c < matriz.GetLength(1); c++)
    //            {
    //                if (matriz[f, c]>mayor)
    //                {
    //                    mayor = matriz[f, c];
    //                    fila =f;
    //                    columna = c; 
    //                }
    //            }
    //        }
    //        Console.WriteLine("El elemento mayor es: "+mayor);
    //        Console.WriteLine("Y se almacena en la fila #"+fila+" y columna #"+columna);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Matrices2 mat = new Matrices2();
    //        mat.CargaMatriz();
    //        mat.Imprimir();
    //        Console.ReadKey();
    //    }
    //}


    /* ----------------Matrices y vectores paralelos-----------------------*/
    //Problema 1:
    //Se tiene la siguiente información:
    //· Nombres de 4 empleados.
    //· Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
    //Confeccionar el programa para:

    //a) Realizar la carga de la información mencionada.
    //b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada empleado.
    //c) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses
    //d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado

    class MatrizYVector
    {
        private string[] nombres;
        private int[] totalSueldos;
        private int[,] matriz;

        public void CargaDatos()
        {
            int totalSl = 0;
            Console.Write("Ingrese #empleados: ");
            int cantNombres = int.Parse(Console.ReadLine());
            Console.Write("Ingrese #meses de sueldo: ");
            int cantSueldos = int.Parse(Console.ReadLine());

            nombres = new string[cantNombres];
            matriz = new int[cantNombres,cantSueldos];
            totalSueldos = new int[cantSueldos];

            for(int e=0; e<cantNombres; e++)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                nombres[e] = Console.ReadLine(); 
                for(int c=0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese sueldo en fila #"+e+" columna #"+c+": ");
                    int sueldos = int.Parse(Console.ReadLine());
                    matriz[e, c] = sueldos;
                    totalSl = totalSl + sueldos;   
                }
                totalSueldos[e] = totalSl;
                totalSl = 0;
            }
        }
        public void Imprimir()
        {
            string nombreMayor="";
            for (int s=0; s<totalSueldos.Length -1; s++)
            {
                Console.WriteLine("Total de sueldos por empledo: "+nombres[s]+": "+totalSueldos[s]);
                int aux = totalSueldos[0];
                if (totalSueldos[s]+1 > aux)
                {
                    aux = totalSueldos[s];
                    nombreMayor= nombres[s];
                }   
            }
            Console.WriteLine("El empleado con el mayor ingreso acumulado es: "+nombreMayor);
        }
        static void Main(string[] args)
        {
            MatrizYVector met = new MatrizYVector();
            met.CargaDatos();
            met.Imprimir();
        }
    }
}
