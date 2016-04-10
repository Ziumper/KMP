using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    class KMPNext
    {
        string s;
        int[] kMPNext; //tablica KMPnext;
        int b;

        public KMPNext(string s)
        {
            this.s = s;
            kMPNext = new int[s.Length + 1];
            kMPNext[0] = -1; //wartownik
            b = -1;
            for(int i = 1; i <= s.Length; i++)
            {
                while ((b > -1) && (s[b] != s[i-1]))
                {
                    b = kMPNext[b];
                }
                b++;
                if ((i == s.Length) || (s[i] != s[b]))
                    kMPNext[i] = b;
                else kMPNext[i] = kMPNext[b];
            }
        }

        public int[] KMP_Next
        {
            get
            {
                return kMPNext;
            }
        }
             
    }
}
