using System;

namespace ConsoleApp__Herencia_Ejercicio1_
{
    public class Operacion
    {
        protected int valor1, valor2, resultado;

        public int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }
        public int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2; 
            }
        }
        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }
}
