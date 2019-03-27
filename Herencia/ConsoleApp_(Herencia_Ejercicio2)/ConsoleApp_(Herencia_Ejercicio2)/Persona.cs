using System;

namespace ConsoleApp__Herencia_Ejercicio2_
{
    /*Problema 2:
    Confeccionar una clase Persona que tenga como atributos el nombre y la edad(definir las propiedades para poder acceder a dichos atributos). Definir como responsabilidad un método para imprimir.
    Plantear una segunda clase Empleado que herede de la clase Persona.Añadir un atributo sueldo(y su propiedad) y el método para imprimir su sueldo.
    Definir un objeto de la clase Persona y llamar a sus métodos y propiedades.También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.*/

    public class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine(nombre+" tiene una edad de: "+edad);
        }
    }
}
