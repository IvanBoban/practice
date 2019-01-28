using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter untill witch number of the Fibonacci numbers you wish to print:");
            int.TryParse(Console.ReadLine(), out n);
            int first = 0;
            int second = 1;
            int aux=0;

            for (int i = 0; i < n; i++)
            {
                first = second;
                second = aux;
                aux = first + second;
                Console.WriteLine(aux);


            }
            

        }
    }
}
