using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGit1
{
    public class Lib1
    {
        public static string stpow(string a, int b)
        {
            string n = "";
            for(int j = 0; j < b; j++)
            {
                n = n + a;
            }
            return n;
        }

        public static string rev(string a)
        {
            string n = new string(a.ToCharArray().Reverse().ToArray());
            return n;
        }

        public static string remove(string a, string b)
        {
            if (a.Contains(b))
            {
                a = a.Replace(b, "");
            }
            return a;
        }

        public static int leng(string a)
        {
            return a.Length;
        }
    }
}
