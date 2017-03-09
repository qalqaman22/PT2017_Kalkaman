using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PT2017_Kalkaman_Ex3
{
    class Program
    {
        public static bool checkname(string name)
        {
            int t = 0;
            int cnt = 0;
            string str = name;
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 't' && i < arr.Length - 2)
                    t = i;

                if (arr[t] == 't' && arr[t + 1] == 'e' && arr[t + 2] == 's' && arr[t + 3] == 't')
                    cnt++;
            }
            if (cnt > 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            string dirname = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(@dirname);
            FileSystemInfo[] fs = dir.GetFileSystemInfos();

            for(int i=0;i<fs.Length;i++)
            {
                if (checkname(fs[i].Name))
                    Console.WriteLine(fs[i].Name);
            }
            
            Console.ReadKey();
        }
    }
}
