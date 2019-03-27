using System;

namespace ConsoleApp__ConceptodePropiedad_
{
    /*Problema 1:
    El problema era : Un banco tiene 3 clientes que pueden hacer depósitos y extracciones.También el banco requiere que al final del día calcule 
    la cantidad de dinero que hay depositada.*/
    class Cliente
    {
        private string nombre;
        private int monto;

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
        public int Monto
        {
            set
            {
                monto = value;
            }
            get
            {
                return monto;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine(Nombre+ " tiene depositado la suma de "+Monto);
        }
    }
}
