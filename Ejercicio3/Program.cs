using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 3
            string NombreCliente;
            string NumeroCuenta;
            double SaldoInicial, Consignar, Retirar;

            Console.WriteLine("Datos del cliente ");

            Console.WriteLine("Digite el nombre ");
            NombreCliente = Console.ReadLine();

            Console.WriteLine("Digite el numero de cuenta ");
            NumeroCuenta = Console.ReadLine();

            Console.WriteLine("Digite saldo inicial");
            SaldoInicial = Convert.ToDouble(Console.ReadLine());

            int op;

            do
            {
                Console.WriteLine("consignar 1");
                Console.WriteLine("retirar 2");
                Console.WriteLine("salir  3");
                Console.WriteLine("digite la opcion ");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        Console.WriteLine("cantidad a consignar:");
                        Consignar = Convert.ToDouble(Console.ReadLine());

                        if (Consignar < 0)
                        {

                            Console.WriteLine("valor tiene que ser mayor a (0)");
                        }
                        else
                        {
                            SaldoInicial = (SaldoInicial + Consignar);
                        }
                        Console.WriteLine("El nuevo saldo es:" + SaldoInicial);
                        break;

                    case 2:
                        Console.WriteLine("cantidad a retirar :");
                        Retirar = Convert.ToDouble(Console.ReadLine());

                        if (Retirar > SaldoInicial || Retirar < 0)
                        {
                            Console.WriteLine("cantidad insuficiente");
                        }
                        else
                        {
                            SaldoInicial = (SaldoInicial - Retirar);

                        }
                        Console.WriteLine("El nuevo saldo es: " + SaldoInicial);
                        break;
                    default:
                        Console.WriteLine("Dedault case");
                        break;


                }
            } while (op != 3);

        }
    }
}
