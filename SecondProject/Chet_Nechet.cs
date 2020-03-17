using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Chet_Nechet
    {
        public void ch_nech(int n)
        {
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 100);
            }
            Console.Write("Elements of array: ");
            mas.ToList().ForEach(x => Console.Write("{0} ", x));
            var tmp1 = mas.Where(x => x % 2 == 0).Select((x => x));
            var tmp2 = mas.Where(x => x % 2 != 0).Select(x => x);
            Int32[] chet = tmp1.Where(x => x % 2 == 0).Select(x => x).ToArray();
            Int32[] nechet = tmp2.Where(x => x % 2 != 0).Select(x => x).ToArray();

            Console.Write("\neven numbers: ");
            chet.ToList().ForEach(x => Console.Write("{0} ", x));

            Console.Write("\nodd numbers: ");
            nechet.ToList().ForEach(x => Console.Write("{0} ", x));
        }
    }
}
