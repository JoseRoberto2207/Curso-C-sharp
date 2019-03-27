using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__Herencia_Ejercicio1_
{
    public class Resta: Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }
}
