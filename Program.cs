using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static CsharpGit1.Lib1;

namespace CsharpGit1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tВведите строку:\n");
            string str = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\n\tВыберите действие: \n\n\t\t1) Дублировать строку \n\t\t2) Перевернуть строку \n\t\t3) Удалить из строки \n\t\t4) Узнать длинну строки\n");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\n\tВведите количество повторов:\n");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\t" + stpow(str,c) + "\n");
            }

            if (num == 2)
            {
                Console.WriteLine("\n\t" + rev(str) + "\n");
            }

            if (num == 3)
            {
                Console.WriteLine("\tВведите часть строки, которую хотите удалить:\n\t");
                string str2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("\n\t" + remove(str, str2) + "\n");
            }

            if (num == 4)
            {
                Console.WriteLine("\n\tДлина данной строки: " + leng(str) + "\n");
            }
        }
    }
}
