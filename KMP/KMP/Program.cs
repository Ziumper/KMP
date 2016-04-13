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
            string s = "aaaxxxxxxzzzzaaaaeeeaadddaaababaaaadddaaaabbbcccaaabbbaaaccbbbaaabbba";
            string p = "aabaacab";
            int pp = 0;
            int b = 0;
            int max=0,tmpMax;
            bool flaga = true;
            Console.WriteLine(p);
            Console.WriteLine(s);

            KMPNext pKMPNext = new KMPNext(p);
            int[] KMPNext = pKMPNext.KMP_Next;
            
            //foreach (int x in KMPNext)
            //    Console.Write(" " + x);

            for(int i = 0; i < s.Length; i++)
            {
                if (flaga) pp = i;
                while ((b > -1) && (p[b] != s[i])) {
                    b = KMPNext[b];
                    if(flaga) pp = b;
                    flaga = false;
                }
                b++;
                if (b == p.Length)
                { //znalazłem wzorzec;
                    //while (pp < i - b + 1)
                    //{
                    //    Console.Write(" ");
                    //    pp++;
                    //}
                    //Console.Write("^");
                    //pp++;
                    //b = KMPNext[b];
                }
                if (b > max)  max = b;
            }
            
            Console.ReadKey();
        }
    }
}
