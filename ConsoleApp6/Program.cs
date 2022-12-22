using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmp=0;
            Console.WriteLine("enter the number to start counting from : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter the number to stop counting to : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = num1; i <= num2; i++)
            {
                for (int c = 1; c <= i; c++)
                {
                    if (i % c == 0)

                        tmp++;
                    
                }
                if (tmp == 2)
                {
                    double perfect = Math.Pow(2, i) - 1;
                    double perfect2 = Math.Pow(2, i - 1);
                    Console.WriteLine(perfect * perfect2);
                    tmp = 0;
                }
                else
                {
                    tmp = 0;
                }
            }





        }
    }
}
