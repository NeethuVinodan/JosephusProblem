using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    class JosephFunctions
    {
        public int josephus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                 return (josephus(n - 1, k) + k - 1) % n + 1;
        }
    }
}

