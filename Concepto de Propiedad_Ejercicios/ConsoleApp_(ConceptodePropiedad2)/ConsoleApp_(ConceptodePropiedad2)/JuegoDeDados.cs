using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__ConceptodePropiedad2_
{
    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }
        public void Jugar()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();
            if (dado1.Valor == dado2.Valor && dado1.Valor == dado3.Valor)
            {
                Console.WriteLine("Ganó");
            }
            else
            {
                Console.WriteLine("Perdió");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            JuegoDeDados j = new JuegoDeDados();
            j.Jugar();
        }
    }
}
