using System;

namespace Funzioni
{
    public class Funzioni
    {
        public static int Input()
        {
            Console.WriteLine("Inserisci un numero intero");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public static void OutputDivisori(int a)
        {
            int cont = 1;
            int max = a / 2;
            while (cont <= max)
            {
                if (a % cont == 0)
                    Console.WriteLine(cont);
                cont++;
            }
            Console.WriteLine(a);
        }
    }
}

