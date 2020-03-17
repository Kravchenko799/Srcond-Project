using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    enum countries
    {
        Абхазия, Австралия , Бельгия, Украина, Германия, Италия , Австрия, Албания, Македония
    }
    class model
    {
        
        public void resh()
        {
            

            Dictionary<string, int> d = new Dictionary<string, int>();
            Console.WriteLine("Enter the number of population in each country:");
            foreach (string res in Enum.GetNames(typeof(countries)))
            {
                Console.WriteLine(res);
                int st = int.Parse(Console.ReadLine());
                d.Add(res, st);
            }


            var StepsGroup = from a in d
                             group a by d.Values;
            Console.WriteLine("Violence in each country:");
            foreach (var dic in StepsGroup)
            {
                foreach (KeyValuePair<string, int> keyValue in dic)
                    Console.WriteLine(keyValue.Key + " " + keyValue.Value);

            }

        }
    }
}
