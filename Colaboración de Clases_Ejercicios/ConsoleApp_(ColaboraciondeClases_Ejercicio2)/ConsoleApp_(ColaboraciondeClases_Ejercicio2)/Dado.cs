﻿using System;

namespace ConsoleApp__ColaboraciondeClases_Ejercicio2_
{
    /*Problema 2:
    Plantear un programa que permita jugar a los dados. 
    Las reglas de juego son: se tiran tres dados si los tres salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".*/

    class Dado
    {
        private int valor;
        private static Random aleatorio;

        public Dado()
        {
            aleatorio = new Random();
        }
        public void Tirar()
        {
            valor = aleatorio.Next(1, 7);
        }
        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es: "+valor);
        }
        public int RetornarValor()
        {
            return valor;
        }
    }
}
