using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__Herencia_Ejercicio2_
{
    class Empleado: Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("El sueldo es: "+sueldo);
        }
    }
}
