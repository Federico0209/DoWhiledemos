using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhiledemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //enunciados
            //while (epresión boolena);

            do
            {
                Console.WriteLine("Hola");
                Console.WriteLine("Fede");
            }
            while (8 > 10);

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;

            }
            while (i <= 10);

            int j = 0;
            int suma = 0;

            do
            {
                suma += j;
                j++;

            }
            while (j <= 10);

            Console.WriteLine(suma);
            Console.ReadLine();
        }
    
    
    }

}
