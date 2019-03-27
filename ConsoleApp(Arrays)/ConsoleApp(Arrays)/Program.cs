using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Arrays_
{
    //*- Se desea guardar los sueldos de 5 operarios e imprimirlos despues.

    //class SueldoEmpleados
    //{
    //    private int[] sueldos;

    //    public void Cargar()
    //    {
    //        sueldos = new int [5];

    //        for(int i=0; i<5; i++)
    //        {
    //            Console.Write("Ingrese valor del componente: ");
    //            int valorIngresado = int.Parse(Console.ReadLine());
    //            sueldos[i] = valorIngresado;
    //        }
    //    }

    //    public void Imprimir()
    //    {
    //        for (int i=0; i<5; i++)
    //        {
    //            Console.WriteLine(sueldos[i]);
    //        }
    //        Console.ReadKey();
    //    }

    //    static void Main(string[] args)
    //    {
    //        SueldoEmpleados sueldo1 = new SueldoEmpleados();
    //        sueldo1.Cargar();
    //        sueldo1.Imprimir();    
    //    }
    //}


    //*- Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
    //Obtener el promedio de las mismas.Contar cuántas personas son más altas que el promedio y cuántas más bajas.

    //class Alturas
    //{
    //    private float[] alturas;
    //    private float promedio;

    //    public void CargaDatos()
    //    {
    //        alturas = new float[5];

    //        for(int i=0; i<5; i++)
    //        {
    //            Console.Write("Ingrese la altura #" +i+": ");
    //            float alturaIngresada= float.Parse(Console.ReadLine());
    //            alturas[i] = alturaIngresada;   
    //        }
    //    }

    //    public void CalculaPromedio()
    //    {
    //        float suma = 0;
    //        int i;

    //        for (i=0; i<5;i++)
    //        {
    //            suma = suma + alturas[i];
    //        }
    //        promedio = suma / i;
    //        Console.WriteLine("El promedio de las 5 personas es: "+promedio);
    //    }

    //    public void MasMenosPromedio()
    //    {
    //       int masAltas = 0; 
    //       int masBajas = 0;

    //       for(int i=0; i < 5; i++)
    //        {
    //            if (alturas[i]>promedio)
    //            {
    //                masAltas++;
    //            }
    //            else
    //            {
    //                masBajas++;
    //            }
    //        }

    //        Console.WriteLine("Personas que son más altas que el promedio: "+masAltas);
    //        Console.WriteLine("Personas que son más bajas que el promedio: "+masBajas);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Alturas altura1 = new Alturas();
    //        altura1.CargaDatos();
    //        altura1.CalculaPromedio();
    //        altura1.MasMenosPromedio();
    //        Console.ReadKey();
    //    }
    //}


    //*- Una empresa tiene dos turnos(mañana y tarde) en los que trabajan 8 empleados(4 por la mañana y 4 por la tarde)
    //Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
    //Imprimir los gastos en sueldos de cada turno.

    //class Turnos
    //{
    //    private int[] turno1;
    //    private int[] turno2;

    //    public void CargaDatosTurnos()
    //    {
    //        int sueldoMañana, sueldoTarde;
    //        turno1 = new int[4];
    //        turno2 = new int[4];

    //        Console.WriteLine("--Sueldos Turno Matutino--");
    //        for (int i=0; i<4; i++)
    //        {
    //            Console.Write("Ingrese el sueldo #"+i+": ");
    //            sueldoMañana = int.Parse(Console.ReadLine());
    //            turno1[i] = sueldoMañana;
    //        }
    //        Console.WriteLine("--Sueldos Turno Vespertino--");
    //        for (int i=0; i<4; i++)
    //        {
    //            Console.Write("Ingrese el sueldo #"+i+": ");
    //            sueldoTarde = int.Parse(Console.ReadLine());
    //            turno2[i] = sueldoTarde;
    //        }
    //    }

    //    public void ImprimirGastos()
    //    {
    //        int sumaMañana = 0;
    //        int sumaTarde = 0;

    //        for(int i=0; i<4; i++)
    //        {
    //            sumaMañana = sumaMañana+ turno1[i];
    //            sumaTarde = sumaTarde + turno2[i];
    //        }
    //        Console.WriteLine("Gastos en sueldos de la Mañana: "+sumaMañana);
    //        Console.WriteLine("Gastos en sueldos de la Tarde: "+sumaTarde);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Turnos turno = new Turnos();
    //        turno.CargaDatosTurnos();
    //        turno.ImprimirGastos();
    //        Console.ReadKey();
    //    }
    //}


    /*--------------------------------Problemas propuestos-------------------------------*/
    //1.- Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    //El valor acumulado de todos los elementos del vector.
    //El valor acumulado de los elementos del vector que sean mayores a 36.
    //Cantidad de valores mayores a 50.

    //class ValoresAcumulados
    //{
    //    private int[] vector;

    //    public void CargaVector()
    //    {
    //        vector = new int[8];

    //        for (int i=0; i<8; i++)
    //        {
    //            Console.Write("Ingrese el elemento #"+i+" del vector: ");
    //            int elemento = int.Parse(Console.ReadLine());
    //            vector[i] = elemento;
    //        }
    //    }

    //    public void ImprimirTotalElementos()
    //    {
    //        int valorAcumulado=0;

    //        for(int i=0; i<8; i++)
    //        {
    //            valorAcumulado = valorAcumulado + vector[i];
    //        }
    //        Console.WriteLine("Valor acumulado de todos los elementos del vector: " + valorAcumulado);
    //    }

    //    public void ElementosMayores36_50()
    //    {
    //        int mayores36=0;
    //        int mayor50 = 0;

    //        for(int i=0; i<8; i++)
    //        {
    //            if (vector[i] > 36)
    //            {
    //                mayores36 = mayores36 + vector[i];
    //            }
    //            if (vector[i] > 50)
    //            {
    //                mayor50++;
    //            }
    //        }
    //        Console.WriteLine("Valor acumulado de elementos mayores a 36: "+mayores36);
    //        Console.WriteLine("Cantidad de elementos mayores a 50: "+mayor50);
    //    }

    //    static void Main(string[] args)
    //    {
    //        ValoresAcumulados valor = new ValoresAcumulados();
    //        valor.CargaVector();
    //        valor.ImprimirTotalElementos();
    //        valor.ElementosMayores36_50();
    //        Console.ReadKey();
    //    }
    //}


    //2.- Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.Obtener la suma de los dos vectores, 
    //dicho resultado guardarlo en un tercer vector del mismo tamaño.Sumar componente a componente.

    //class TresVectores
    //{
    //    private int[] vector1;
    //    private int[] vector2;
    //    private int[] vector3;

    //    public void CargaVectores()
    //    {
    //        int valor1, valor2;

    //        vector1 = new int[4];
    //        vector2 = new int[4];

    //        Console.WriteLine("---Primer Vector---");
    //        for(int i=0; i<4; i++)
    //        {
    //            Console.Write("Ingrese el elemento #"+i+": ");
    //            valor1 = int.Parse(Console.ReadLine());
    //            vector1[i] = valor1;
    //        }
    //        Console.WriteLine("---Segundo Vector---");
    //        for (int i=0; i<4; i++)
    //        {
    //            Console.Write("Ingrese el elemento #" + i + ": ");
    //            valor2 = int.Parse(Console.ReadLine());
    //            vector2[i] = valor2;

    //        }
    //    }

    //    public void SumaVectores()
    //    {
    //        vector3 = new int[4];

    //        int sumaVectores=0;

    //        for(int i=0; i<4; i++)
    //        {
    //            sumaVectores = (vector1[i] + vector2[i]);
    //            vector3[i] = sumaVectores;
    //        }
    //    }

    //    public void ImprimirVector3()
    //    {
    //        Console.WriteLine("---Tercer vector---");
    //        for(int i=0; i<4; i++)
    //        {
    //            Console.WriteLine("Tercer vector elemento #"+i+": "+vector3[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        TresVectores vectores = new TresVectores();
    //        vectores.CargaVectores();
    //        vectores.SumaVectores();
    //        vectores.ImprimirVector3();
    //        Console.ReadKey();
    //    }
    //}


    //3.- Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.
    //Realizar un programa que muestre el curso que obtuvo el mayor promedio general.

    //class Parciales{

    //    private float[] cursoA;
    //    private float[] cursoB;
    //    private float promedioA, promedioB;

    //    public void cargaCursos()
    //    {
    //        cursoA = new float[5];
    //        cursoB = new float[5];
    //        float valorA,valorB;

    //        Console.WriteLine("---Curso A---");
    //        for (int i=0; i<5; i++)
    //        {
    //            Console.Write("Ingrese los promedios de los alumnos: ");
    //            valorA = float.Parse(Console.ReadLine());
    //            cursoA[i] = valorA;
    //        }
    //        Console.WriteLine("---Curso B---");
    //        for(int i=0; i<5; i++)
    //        {
    //            Console.Write("Ingrese los promedios de los alumnos: ");
    //            valorB = float.Parse(Console.ReadLine());
    //            cursoB[i] = valorB;
    //        }
    //    }

    //    public void ObtienePromedios()
    //    {
    //        int i;
    //        float sumaA = 0;
    //        float sumaB = 0;

    //        for (i=0; i<5; i++)
    //        {
    //            sumaA = sumaA + cursoA[i];
    //            sumaB = sumaB + cursoB[i];
    //        }
    //        promedioA = sumaA / i;
    //        promedioB = sumaB / i;
    //    }

    //    public void ImprimeMejorCurso()
    //    {
    //        if (promedioA > promedioB)
    //        {
    //            Console.WriteLine("El mejor promedio general es: "+promedioA+" del grupo A");
    //        }
    //        else
    //        {
    //            Console.WriteLine("El mejor promedio general es: "+promedioB+" del grupo B");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Parciales parcial = new Parciales();
    //        parcial.cargaCursos();
    //        parcial.ObtienePromedios();
    //        parcial.ImprimeMejorCurso();
    //        Console.ReadKey();
    //    }
    //}


    //4.- Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor.

    //class VectorOrdenado
    //{
    //    private int[] vector10;

    //    public void CargaVector()
    //    {
    //        vector10 = new int[10];

    //        for(int i=0; i<vector10.Length; i++)
    //        {
    //            Console.Write("Ingrese el elemento #"+i+": ");
    //            int valor = int.Parse(Console.ReadLine());
    //            vector10[i] = valor;
    //        }
    //    }

    //    public void VerificaOrdenado()
    //    {
    //        int orden = 1;

    //        for(int i=0; i<9; i++)
    //        {
    //            if (vector10[i + 1] < vector10[i])
    //            {
    //                orden = 0;
    //            }
    //        }
    //        if (orden == 1)
    //        {
    //            Console.WriteLine("Estan ordenados de Menor a Mayor");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No están ordendos de Menor a Meyor");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        VectorOrdenado vector = new VectorOrdenado();
    //        vector.CargaVector();
    //        vector.VerificaOrdenado();
    //        Console.ReadKey();
    //    }
    //}


    /*-------------------------------------------------------------------------*/


    //*- Se desea almacenar los sueldos de operarios.Cuando se ejecuta el programa se debe pedir la cantidad de sueldos a ingresar.Luego crear un vector con dicho tamaño.

    //class CantidadSueldos
    //{
    //    private int[] vector;
    //    private int cantidadSueldos;

    //    public void IngresaSueldos()
    //    {    
    //        Console.Write("Ingrese cantidad de sueldos a guardar: ");
    //        cantidadSueldos = int.Parse(Console.ReadLine());

    //        vector = new int[cantidadSueldos];
    //        int sueldo;

    //        for (int i=0; i<vector.Length; i++)
    //        {
    //            Console.Write("Ingrese el sueldo #"+i+": ");
    //            sueldo = int.Parse(Console.ReadLine());
    //            vector[i] = sueldo;
    //        }
    //    }

    //    public void ImprimirVector()
    //    {
    //        for(int i=0; i<vector.Length; i++)
    //        {
    //            Console.WriteLine(vector[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        CantidadSueldos sueldos = new CantidadSueldos();
    //        sueldos.IngresaSueldos();
    //        sueldos.ImprimirVector();
    //    }
    //}


    //*- Desarrollar un programa que permita ingresar un vector de n elementos, ingresar n por teclado. Luego imprimir la suma de todos sus elementos.

    class NElementos {

        private int[] vector;
        int nElementos;

        public void CargaVector()
        {
            int elementosVector;

            Console.Write("Ingrese tamaño de vector: ");
            nElementos = int.Parse(Console.ReadLine());

            vector = new int[nElementos];
            for (int i=0; i<vector.Length; i++)
            {
                Console.Write("Ingrese el elemento #"+i+": ");
                elementosVector = int.Parse(Console.ReadLine());
                vector[i] = elementosVector;
            }
        }

        public void ImprimirSuma()
        {
            int suma = 0;

            for(int i=0; i<vector.Length; i++)
            {
                suma = suma + vector[i];
            }
            Console.WriteLine("La suma de todos sus elementos es: "+suma);
        }

        public static void Main()
        {
            NElementos elementos = new NElementos();
            elementos.CargaVector();
            elementos.ImprimirSuma();
            Console.ReadKey();
        }
        
    }















}
