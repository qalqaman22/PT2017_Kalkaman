using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2017_Kalkaman_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            int x = int.Parse(str);

            for(int i=1;i<=x;i++)
            {
                if (x % i == 0)
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
