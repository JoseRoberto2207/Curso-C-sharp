using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__Herencia_Ejercicio2_
{
    public class Ejecuta
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Pepe";
            p.Edad = 25;
            Console.WriteLine("Los datos de la persona son: ");
            p.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "María";
            empleado1.Edad = 20;
            empleado1.Sueldo = 6560;
            Console.WriteLine("Los datos del empleado son: ");
            empleado1.Imprimir();
            Console.ReadKey();
        }
    }
}
