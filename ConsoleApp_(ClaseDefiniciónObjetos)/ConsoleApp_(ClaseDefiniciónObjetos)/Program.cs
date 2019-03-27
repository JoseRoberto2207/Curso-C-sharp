using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__ClaseDefiniciónObjetos_
{
    //*- Confeccionar una clase que permita carga el nombre y la edad de una persona.Mostrar los datos cargados.Imprimir un mensaje si es mayor de edad (edad>=18)

    //class Persona
    //{
    //    private string nombre;
    //    private int edad;

    //    public void Inicializar()
    //    {
    //        Console.Write("Ingrese su nombre: ");
    //        nombre = Console.ReadLine();
    //        Console.Write("Ingrese su edad: ");
    //        edad = int.Parse(Console.ReadLine());
    //    }

    //    public void Imprimir()
    //    {
    //        Console.WriteLine(nombre);
    //        Console.WriteLine(edad);
    //    }

    //    public void EdadMayor()
    //    {
    //        if (edad >= 18)
    //        {
    //            Console.WriteLine("Es mayor de edad");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Es menor de edad");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Persona per1 = new Persona();
    //        per1.Inicializar();
    //        per1.Imprimir();
    //        per1.EdadMayor();

    //        Console.ReadKey();
    //    }
    //}


    //*- Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos: inicializar los atributos, 
    //imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.

    //class Triangulo
    //{
    //    private int lado1, lado2, lado3;

    //    public void InicializarAtributos()
    //    {
    //        Console.Write("Ingrese el primer lado del triángulo: ");
    //        lado1 = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese el segundo lado del triángulo: ");
    //        lado2 = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese el tercer lado del triángulo: ");
    //        lado3 = int.Parse(Console.ReadLine());
    //    }

    //    public void Imprimir()
    //    {
    //        if(lado1>lado2 && lado1 > lado3)
    //        {
    //            Console.WriteLine("El lado mayor es: "+lado1);

    //        }else if (lado2>lado1 && lado2>lado3)
    //        {
    //            Console.WriteLine("El lado mayor es: "+lado2);
    //        }
    //        else
    //        {
    //            Console.WriteLine("El lado mayor es: "+lado3);
    //        }
    //    }

    //    public void Equilatero()
    //    {
    //        if(lado1 == lado2 && lado1 == lado3)
    //        {
    //            Console.WriteLine("El triángulo es Equilátero");

    //        }else
    //        {
    //            Console.WriteLine("El triángulo no es un Triángulo Equilátero");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Triangulo triangulo1 = new Triangulo();
    //        triangulo1.InicializarAtributos();
    //        triangulo1.Imprimir();
    //        triangulo1.Equilatero();
    //        Console.ReadKey();
    //    }
    //}


    //*- Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante 
    //se encuentra dicho punto (concepto matemático, primer cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.)


    //class Plano
    //{
    //    private int x,y;

    //    public void CargaValores()
    //    {
    //        Console.Write("Ingrese valor de X: ");
    //        x = int.Parse(Console.ReadLine());
    //        Console.Write("Ingrese el valor de Y: ");
    //        y = int.Parse(Console.ReadLine());
    //    }

    //    public void ImprimirCuadrante()
    //    {
    //        if(x > 0 && y > 0)
    //        {
    //            Console.WriteLine("El punto se encuentra en el primer cuandrante");

    //        }else if (x < 0 && y > 0)
    //        {
    //            Console.WriteLine("El punto se encuentra en el segundo cuadrante");

    //        }else if (x < 0 && y <0)
    //        {
    //            Console.WriteLine("El punto se encuentra en el tercer cuadrante");

    //        }else if (x > 0 && y < 0)
    //        {
    //            Console.WriteLine("El punto se encuentra en el cuarto cuadrante");

    //        }
    //        else
    //        {
    //            Console.WriteLine("El punto no se encuentra en un cuadrante");
    //        }
    //    }

    //    static  void Main(string[] args)
    //    {
    //        Plano plano1 = new Plano();
    //        plano1.CargaValores();
    //        plano1.ImprimirCuadrante();
    //        Console.ReadKey();
    //    }
    //}


    //*- Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.

    //class Cuadrado
    //{
    //    private int ladoCuadrado;
    //    private int perimetro;
    //    private int superficie;

    //    public void CargaValor()
    //    {
    //        Console.Write("Ingrese el lado del cuadrado: ");
    //        ladoCuadrado = int.Parse(Console.ReadLine());
    //    }

    //    public void Imprimir()
    //    {
    //        perimetro = ladoCuadrado * 4;
    //        superficie = ladoCuadrado * ladoCuadrado;

    //        Console.WriteLine("El perímetro del cuadrado es: "+perimetro);
    //        Console.WriteLine("La superficie del cuadrado es: "+superficie);
    //    }

    //    static void Main(string [] args)
    //    {
    //        Cuadrado cuadrado1 = new Cuadrado();
    //        cuadrado1.CargaValor();
    //        cuadrado1.Imprimir();

    //    }
    //}


    /*---------------------------Problemas propuestos----------------------*/

    //*- Confeccionar una clase que represente un empleado.Definir como atributos su nombre y su sueldo.Confeccionar los métodos para la carga, 
    //otro para imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)


    //class Empleado
    //{
    //    private string nombre;
    //    private int sueldo;

    //    public void CargaValores()
    //    {
    //        Console.Write("Ingrese su nombre: ");
    //        nombre = Console.ReadLine();
    //        Console.Write("Ingrese su sueldo: ");
    //        sueldo = int.Parse(Console.ReadLine());
    //    }

    //    public void Imprimir()
    //    {
    //        Console.WriteLine(nombre);
    //        Console.WriteLine(sueldo);
    //    }

    //    public void ImprimeImpuesto()
    //    {
    //        if (sueldo > 3000)
    //        {
    //            Console.WriteLine("Debe pagar impuesto");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No debe pagar impuestos");
    //        }
    //    }

    //    static void Main(string [] args)
    //    {
    //        Empleado empleado1 = new Empleado();
    //        empleado1.CargaValores();
    //        empleado1.Imprimir();
    //        empleado1.ImprimeImpuesto();
    //        Console.ReadKey();
    //    }
    //}


    //*- Implementar la clase operaciones.Se deben cargar dos valores enteros, calcular su suma, resta, multiplicación y división, cada una en un método, 
    //imprimir dichos resultados.


    class Operaciones{

        private float valor1, valor2, suma, resta, producto, division;

        public void CargaValores()
        {
            Console.Write("Ingrese el primer valor: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());
        }
        public void Suma()
        {
            suma = valor1 + valor2;
            Console.WriteLine(suma);
        }
        public void Resta()
        {
            resta = valor1 - valor2;
            Console.WriteLine(resta);
        }
        public void Producto()
        {
            producto = valor1 * valor2;
            Console.WriteLine(producto);
        }
        public void División()
        {
            division = valor1 / valor2;
            Console.WriteLine(division);
        }

        static void Main(string [] args)
        {
            Operaciones operaciones1 = new Operaciones();
            operaciones1.CargaValores();
            operaciones1.Suma();
            operaciones1.Resta();
            operaciones1.Producto();
            operaciones1.División();
            Console.ReadKey();
        }
    }
}
