using System;

namespace ConsoleApp__ColaboraciondeClases_Ejercicio3_
{
    /*Plantear una clase Club y otra clase Socio.
    La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años). En el constructor pedir la carga del nombre y su antigüedad.
    La clase Club debe tener como atributos 3 objetos de la clase Socio.Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.*/

    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }
        public void MayorAntiguedad()
        {
            Console.Write("Socio con mayor antiguedad: ");
            if (socio1.RetornaValores() > socio2.RetornaValores() &&
                socio1.RetornaValores() > socio3.RetornaValores())
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.RetornaValores() > socio3.RetornaValores())
                {

                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }

            }
        }
        static void Main(string[] args)
        {
            Club c = new Club();
            c.MayorAntiguedad();
            Console.ReadKey();
        }
    }
}
