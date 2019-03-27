using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ejercicios_Repaso_General_
{

    /*--------Do-While-------*/
    //* En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada cuenta corriente se conoce: número de cuenta y saldo actual. 
    //El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
    //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
    //a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
    //Estado de la cuenta 'Acreedor' si el saldo es > 0.
    //'Deudor' si el saldo es<0.
    //'Nulo' si el saldo es = 0.
    //b) La suma total de los saldos acreedores.

    //class Banco{

    //    public void IngresaCuentas()
    //    {
    //        int cuenta;
    //        int saldo;
    //        int sumaAcreedores=0;
    //        do
    //        {
    //            Console.Write("*Ingrese el #cuenta: ");
    //            cuenta = int.Parse(Console.ReadLine());

    //            if (cuenta>0)
    //            {
    //                Console.Write("*Ingrese el saldo actual: ");
    //                saldo = int.Parse(Console.ReadLine());

    //                Console.WriteLine("-Cuenta #" + cuenta);

    //                if (saldo > 0)
    //                {
    //                    Console.WriteLine("-Saldo Acreedor");
    //                    sumaAcreedores = sumaAcreedores + saldo;
    //                }else
    //                    if (saldo<0)
    //                    {
    //                        Console.WriteLine("-Saldo Deudor");
    //                    }
    //                    else
    //                    {
    //                        Console.WriteLine("-Saldo Nulo");
    //                    }
    //            }
    //        } while (cuenta>0);
    //        Console.WriteLine("Suma total de Acreecores: "+sumaAcreedores);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Banco banco1 = new Banco();
    //        banco1.IngresaCuentas();
    //        Console.ReadLine();
    //    }
    //}


    //*- Se desea guardar los sueldos de 5 operarios, en un vector posteriormente, ordenarlo de menor a mayor, y de mayor a menor.

    class Sueldos
    {
        private int[] vector;

        public void CargaVector()
        {
            Console.Write("Ingrese cantidad de sueldos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            vector = new int[cantidad];
            for(int i=0; i < vector.Length; i++)
            {
                Console.Write("Ingrese sueldo #"+i+": ");
                int sueldos= Convert.ToInt32(Console.ReadLine());
                vector[i] = sueldos;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Sueldos: ");
            for(int i=0; i<vector.Length; i++)
            {
                Console.WriteLine("Sueldo #" +i+": "+vector[i]);
            }
        }
        public void OrdenarMenor()
        {
            for(int j=0; j<vector.Length; j++)
            {
                for (int i=0; i < vector.Length -1 -j; i++)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        int aux;
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                    }
                }
            }   
        }
        public void ImprimeMenor()
        {
            Console.WriteLine("Sueldo Ordenado de Menor a Mayor: ");
            for(int i=0; i < vector.Length; i++)
            {
                Console.WriteLine("Sueldo #"+i+": "+vector[i]);
            }
        }
        public void OrdenaMayor()
        {
            for(int j=0; j<vector.Length; j++)
            {
                for (int i = 0; i < vector.Length -1-j; i++)
                {
                    if (vector[i] < vector[i + 1])
                    {
                        int aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                    }
                }
            }
        }
        public void ImprimeMayor()
        {
            Console.WriteLine("Sueldo ordenado de Mayor a Menor: ");
            for(int i=0; i < vector.Length; i++)
            {
                Console.WriteLine("Sueldo #"+i+": "+vector[i]);
            }
        } 
        static void Main(string [] args)
        {
            Sueldos sueldo = new Sueldos();
            sueldo.CargaVector();
            sueldo.Imprimir();
            sueldo.OrdenarMenor();
            sueldo.ImprimeMenor();
            sueldo.OrdenaMayor();
            sueldo.ImprimeMayor();
            Console.ReadKey();
        }
    }




}
