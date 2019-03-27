using System;

namespace ConsoleApp__ConstructordelaClase_
{
    /*-----------Constructor de la clase----------*/
    //1. Se desea guardar los sueldos de 5 operarios en un vector. Realizar la creación y carga del vector en el constructor.

    //class Operacion
    //{
    //    private int[] vector;

    //    public Operacion()
    //    {
    //        Console.Write("Ingrese cantidad de operarios: ");
    //        int cantidad = int.Parse(Console.ReadLine());
    //        vector = new int[cantidad];

    //        for(int i=0; i < vector.Length; i++)
    //        {
    //            Console.Write("Ingrese elemento #"+i+": ");
    //            int elemento = int.Parse(Console.ReadLine());
    //            vector[i] = elemento;
    //        }
    //    }
    //    public void Imprimir()
    //    {
    //        for(int i=0; i < vector.Length; i++)
    //        {
    //            Console.WriteLine(vector[i]);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Operacion op = new Operacion();
    //        op.Imprimir();
    //    }
    //}


    //2.- Plantear una clase llamada Alumno y definir como atributos su nombre y su edad. En el constructor realizar la carga de datos. 
    //Definir otros dos métodos para imprimir los datos ingresados y un mensaje si es mayor o no de edad (edad >=18)

    //class Alumno
    //{
    //    private string nombre;
    //    private int edad;

    //    public Alumno()
    //    {
    //        Console.Write("Ingrese el nombre: ");
    //        nombre = Console.ReadLine();
    //        Console.Write("Ingrese la edad: ");
    //        edad = int.Parse(Console.ReadLine());
    //    }
    //    public void ImprimirNombre()
    //    {
    //        Console.WriteLine("Nombre: "+nombre);
    //    }
    //    public void ImprimirEdad()
    //    {
    //        if (edad >= 18)
    //        {
    //            Console.WriteLine("Es mayor de edad: " + edad);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Es menor de edad: "+edad);
    //        }

    //    }
    //    static void Main(string[] args)
    //    {
    //        Alumno alum = new Alumno();
    //        alum.ImprimirNombre();
    //        alum.ImprimirEdad();
    //    }
    //}


    //3.- Confeccionar una clase que represente un empleado. 
    //Definir como atributos su nombre y su sueldo. En el constructor cargar los atributos y luego en otro método imprimir sus datos y por último uno que 
    //imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)

    //class Empleado
    //{
    //    private string nombre;
    //    private int sueldo;

    //    public Empleado()
    //    {
    //        Console.Write("Ingrese nombre: ");
    //        nombre = Console.ReadLine();
    //        Console.Write("Ingrese sueldo: ");
    //        sueldo = Convert.ToInt32(Console.ReadLine());
    //    }
    //    public void ImprimirDatos()
    //    {
    //        Console.WriteLine("Nombre: "+nombre);
    //        Console.WriteLine("Sueldo: "+sueldo);
    //    }
    //    public void ImprimirImpuestos()
    //    {
    //        if (sueldo > 3000)
    //        {
    //            Console.WriteLine("Debe pagar impuestos");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No debe pagar impuestos");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Empleado emp = new Empleado();
    //        emp.ImprimirDatos();
    //        emp.ImprimirImpuestos();
    //        Console.ReadKey();
    //    }
    //}


    //4.- Implementar la clase operaciones.
    //Se deben cargar dos valores enteros en el constructor, calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.

    class Operaciones
    {
        private float valor1, valor2, suma, resta, producto, division;

        public Operaciones()
        {
            Console.Write("Ingrese valor1: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese valor2: ");
            valor2 = float.Parse(Console.ReadLine());
        }
        public void Suma()
        {
            suma = valor1 + valor1;
        }
        public void Resta()
        {
            resta = valor1 - valor2;
        }
        public void Producto()
        {
            producto = valor1 * valor2;
        }
        public void Division()
        {
            division = valor1 / valor2;
        }
        public void Imprimir()
        {
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("División: " + division);
        }
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Suma();
            op.Resta();
            op.Producto();
            op.Division();
            op.Imprimir();
        }
    }








}
