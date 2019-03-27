using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__ColaboraciondeClases_Ejercicio3_
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su antiguedad: ");
            antiguedad = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine(nombre+ " tiene una antiguedad de "+antiguedad+" años");
        }
        public int RetornaValores()
        {
            return antiguedad;
           
        }
    }
}
