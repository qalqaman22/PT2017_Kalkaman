using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PT2017_Kalkaman_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string str = sr.ReadLine();
            string[] arr = str.Split();

            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            //not important a or b in for, but in projects it is good to paste less number
            for(int i=1;i<a;i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    sw.Write(i + " ");
                }
            }
            sw.Close();

            Console.WriteLine("Press key");
            Console.ReadKey();
        }
    }
}
