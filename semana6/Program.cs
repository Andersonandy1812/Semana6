using System;

namespace semana6
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio2b();

            int t1 = 1;
            int t2 = 7;
            while (t1 < 12)
            {
                Console.WriteLine(t1 * t2);
                t1++;
            }
            Console.ReadKey();
        }
        static void ejercicio2()
        {
            int var1 = 0;
            Console.WriteLine("Escriba un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    var1++;
                }
            }
            if (var1 < 2 & var1 > 0)
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es un numero primo");
            }
            Console.ReadKey();
        }
        static void ejercicio2b()
        {
            Console.WriteLine("Escriba un numero Positivo");
           string numero = Console.ReadLine();
            Console.WriteLine("La cantidad de digitos que tiene es: " + numero.Length);
        }
        static void ejercicio3()
        {

            Random rand = new Random();
            int rand1 = rand.Next(50, 100);

            Console.WriteLine(rand1);
            Console.WriteLine("Precione la letra 's' para generar otro numero de lo contrario cualquier letra para cerrar el programa");
            string sig = Console.ReadLine().ToLower();

            if (sig != "s")
            {
                Environment.Exit(0);
            }
            else
            {
                ejercicio3();
            }


        }
        static void ejercicio4()
        {
            int var1 = 0, var2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i < 100)
                {
                    var1++;
                    if (var1 == 10)
                    {
                        var2++;
                        var1 = 0;
                    }
                }
                else if (i == 100)
                {
                    Console.WriteLine("El total de 0 es:" + (var2 + 2));
                }
            }
            Console.WriteLine(var2);
            Console.ReadKey();
        }
        static void ejercicio5()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}
