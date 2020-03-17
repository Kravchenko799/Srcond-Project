using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class factorial
    {
        public int fact(int n)
        {
            if(n<=1)
            {
                return n;
            }
            else
            {
                return n * fact(n - 1);
            }
        }
    }
}
