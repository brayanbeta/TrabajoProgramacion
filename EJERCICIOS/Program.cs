using System;
using System.Runtime.CompilerServices;

namespace EJERCICIOS
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //ejercicio 1
                try
                {
                    Console.WriteLine("aviso: Digite los valores con coma");
                    double N1, N2, N3, promedio;

                    Console.WriteLine("Digite la primera nota");
                    N1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite la segunda nota");
                    N2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite la tercera nota");
                    N3 = Convert.ToDouble(Console.ReadLine());

                    promedio = (N1 + N2 + N3) / 3;

                    if(promedio<3)
                        {
                        Console.WriteLine("La nota es:" + promedio);
                        Console.WriteLine("Perdio la materia");

                    }
                    else
                    {
                        Console.WriteLine("La nota es :" + promedio);
                        Console.WriteLine("Gano la materia");

                    }
                }catch(Exception e)
                {
                    Console.WriteLine("error digitando los datos");

                }

            }
            
        }
    }


