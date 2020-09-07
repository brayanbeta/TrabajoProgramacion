using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio2

            try
            {
                int edad;
                String sexo;
                double pulsacion;

                Console.WriteLine("digite edad:");
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("digite  sexo(f/m)");
                sexo = Console.ReadLine();

                if(sexo.Equals("f")){

                    pulsacion = (220 - edad) / 10;
                }
                else if (sexo.Equals("m"))

                {
                    pulsacion = (210 - edad) / 10;
                }
                else
                {
                    pulsacion = 0; 
                }
                Console.WriteLine("Las pulsaciones de una persona por cada 10 segundos de ejercicio de aerobico es:" + pulsacion);
            }catch(Exception e)
            {
                Console.WriteLine("error digitado los datos.");
            }
        }
    }
}
