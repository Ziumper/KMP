using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABBBCAASDWQABAABABAABBABBAB";
            string p = "ABAABAB";
            int pp = 0;
            int b = 0;

            Console.WriteLine(p);
            Console.WriteLine(s);

            KMPNext pKMPNext = new KMPNext(p);
            int[] KMPNext = pKMPNext.KMP_Next;
            
            //foreach (int x in KMPNext)
            //    Console.Write(" " + x);

            for(int i = 0; i < s.Length; i++)
            {
                while ((b > -1) && (p[b] != s[i])) b = KMPNext[b];
                if (++b == p.Length)
                { //znalazłem wzorzec;
                    while (pp < i - b + 1)
                    {
                        Console.Write(" ");
                        pp++;
                    }
                    Console.Write("^");
                    pp++;
                    b = KMPNext[b];
                }
            }

            Console.ReadKey();
        }
    }
}
